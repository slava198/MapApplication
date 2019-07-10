using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using MapApplication.BLL;
using MapApplication.Context;
using MapApplication.DAL;
using MapApplication.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MapApplication
{
    public enum OperationType { Buy, Sell };
    public enum CurrencyType { USD, EUR, RUR };

    public partial class MainForm : Form
    {
        readonly GMapOverlay _userPositionOverlay;
        readonly GMapOverlay _departmentsPositionOverlay;
        readonly GMapOverlay _closerDepartmentOverlay;

        readonly GMapControl _mapControl;

        internal BankRepository banks;
        internal CourseRepository courses;
        internal DepartmentRepository departments;


        public MainForm()
        {
            InitializeComponent();
            
            _mapControl = new GMapControl();
            _userPositionOverlay = new GMapOverlay();
            _departmentsPositionOverlay = new GMapOverlay();
            _closerDepartmentOverlay = new GMapOverlay();

            _mapControl.Overlays.Add(_userPositionOverlay);
            _mapControl.Overlays.Add(_departmentsPositionOverlay);
            _mapControl.Overlays.Add(_closerDepartmentOverlay);
            _mapControl.Dock = DockStyle.Fill;

            splitContainer.Panel2.Controls.Add(_mapControl);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbCurrency.DataSource = Enum.GetNames(typeof(CurrencyType));
            cbOperation.DataSource = Enum.GetNames(typeof(OperationType));

            courses = new CourseRepository();
            departments = new DepartmentRepository();

            if (courses != null && departments != null)
            {
                banks = new BankRepository(courses, departments);
                clbBanks.DataSource = banks.GetBanks();
            }
            
            _mapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            _mapControl.ShowCenter = false;
            _mapControl.MaxZoom = 18;
            _mapControl.MinZoom = 2;
            _mapControl.Zoom = 17;
            _mapControl.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            _mapControl.CanDragMap = true;
            _mapControl.DragButton = MouseButtons.Left;
            _mapControl.Position = new PointLatLng(53.902800, 27.561759);
            _mapControl.MarkersEnabled = true;
            _mapControl.MouseClick += OnMap_MouseClick;
        }


        private void ClbBanks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            _departmentsPositionOverlay.Markers.Clear();
            foreach (Bank bank in clbBanks.CheckedItems)
            {
                foreach (var department in bank.departmens)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(department.latitude, department.longitude), GMarkerGoogleType.green);
                    marker.ToolTip = new GMapRoundedToolTip(marker);
                    marker.ToolTipText = String.Format($"{bank.name}{Environment.NewLine}{department.address}{Environment.NewLine}" +
                        $"USD покупка/продажа: {bank.currentCourse.USD.Buy:N3}/{bank.currentCourse.USD.Sell:N3}{Environment.NewLine}" +
                        $"EUR покупка/продажа: {bank.currentCourse.EUR.Buy:N3}/{bank.currentCourse.EUR.Sell:N3}{Environment.NewLine}" +
                        $"RUR покупка/продажа: {bank.currentCourse.RUR.Buy:N3}/{bank.currentCourse.RUR.Sell:N3}");
                    _departmentsPositionOverlay.Markers.Add(marker);
                }
            }
        }


        private void OnMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var x = _mapControl.FromLocalToLatLng(e.X, e.Y).Lat;
                var y = _mapControl.FromLocalToLatLng(e.X, e.Y).Lng;

                _closerDepartmentOverlay.Clear();
                _userPositionOverlay.Markers.Clear();

                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.red);
                marker.ToolTip = new GMapRoundedToolTip(marker);
                marker.ToolTipText = "Ваше местоположение";
                _userPositionOverlay.Markers.Add(marker);
            }
        }

        
        private void btnDBcreate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите создать базу данных?", "Создать базу данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (banks == null) return;

                using (BankContext db = new BankContext())
                {
                    foreach (var item in banks.GetBanks())
                    {
                        if (item.id != 0)
                        {
                            db.Banks.Add(item);
                        }
                    }
                    db.SaveChanges();
                    MessageBox.Show("Объекты успешно сохранены");
                }
            }
        }

      
        private void RefreshMap()
        {
            _departmentsPositionOverlay.Markers.Clear();
            foreach (Bank bank in clbBanks.CheckedItems)
            {
                foreach (var department in bank.departmens)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(department.latitude, department.longitude), GMarkerGoogleType.green);
                    marker.ToolTip = new GMapRoundedToolTip(marker);
                    marker.ToolTipText = String.Format($"{bank.name}{Environment.NewLine}{department.address}{Environment.NewLine}" +
                        $"USD покупка/продажа: {bank.currentCourse.USD.Buy:N3}/{bank.currentCourse.USD.Sell:N3}{Environment.NewLine}" +
                        $"EUR покупка/продажа: {bank.currentCourse.EUR.Buy:N3}/{bank.currentCourse.EUR.Sell:N3}{Environment.NewLine}" +
                        $"RUR покупка/продажа: {bank.currentCourse.RUR.Buy:N3}/{bank.currentCourse.RUR.Sell:N3}");
                    _departmentsPositionOverlay.Markers.Add(marker);
                }
            }
        }


        List<Bank> GetCheckedBanks()
        {
            List<Bank> banks = new List<Bank>();
            foreach (Bank bank in clbBanks.CheckedItems)
            {
                banks.Add(bank);
            }
            return banks;
        }


        List<Departmen> GetCheckedDepartments()
        {
            List<Departmen> departmens = new List<Departmen>();
            if (clbBanks.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите необходимые банки для отображения их обменных пунктов.", "Не выбраны банки!",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }

            foreach (Bank bank in clbBanks.CheckedItems)
            {
                foreach (var department in bank.departmens)
                {
                    departmens.Add(department);
                }
            }
            return departmens;
        }


        private void btnCloserDep_Click(object sender, EventArgs e)
        {
            if (_userPositionOverlay.Markers.Count == 0)
            {
                MessageBox.Show("Укажите местоположение пользователя с помощью правой кнопкой мыши.", "Не установлена позиция пользователя!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var closerDep = MapObjectHandler.FindCloserDepartment(_userPositionOverlay.Markers.Single().Position, GetCheckedDepartments());

            if (closerDep != null)
            {
                _closerDepartmentOverlay.Clear();
                GMarkerGoogle depMarker = new GMarkerGoogle(closerDep.DepartmentPosition, GMarkerGoogleType.yellow);
                depMarker.ToolTip = new GMapBaloonToolTip(depMarker);
                depMarker.ToolTipText = String.Format($"{Environment.NewLine}Расстояние до обменного пункта: {closerDep.Distantion * 1000:N0} м{Environment.NewLine}" +
                    $"{_departmentsPositionOverlay.Markers.Where(m => m.Position == closerDep.DepartmentPosition).Single().ToolTipText}");
                _closerDepartmentOverlay.Markers.Add(depMarker);
            }
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            if (_userPositionOverlay.Markers.Count == 0)
            {
                MessageBox.Show("Укажите местоположение пользователя с помощью правой кнопкой мыши.", "Не установлена позиция пользователя!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            OperationType operation;
            CurrencyType currency;
            Enum.TryParse(cbOperation.SelectedValue.ToString(), out operation);
            Enum.TryParse(cbCurrency.SelectedValue.ToString(), out currency);

            var closerDep = MapObjectHandler.FindCloserBestCourseDepartment(_userPositionOverlay.Markers.Single().Position,
                GetCheckedBanks(), GetCheckedDepartments(), operation, currency);

            if (closerDep != null)
            {
                _closerDepartmentOverlay.Clear();
                GMarkerGoogle depMarker = new GMarkerGoogle(closerDep.DepartmentPosition, GMarkerGoogleType.yellow);
                depMarker.ToolTip = new GMapBaloonToolTip(depMarker);

                depMarker.ToolTipText = String.Format($"{Environment.NewLine}Расстояние до обменного пункта: {closerDep.Distantion * 1000:N0} м{Environment.NewLine}" +
                    $"{_departmentsPositionOverlay.Markers.Where(m => m.Position == closerDep.DepartmentPosition).Single().ToolTipText}");
                _closerDepartmentOverlay.Markers.Add(depMarker);
            }
        }


        private void clbBanks_ItemCheck(object sender, ItemCheckEventArgs e)
        { 
            Bank checkedBank = clbBanks.Items[e.Index] as Bank;
            if (e.NewValue == CheckState.Checked)
            {
                foreach (var department in checkedBank.departmens)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(department.latitude, department.longitude), GMarkerGoogleType.green);
                    marker.ToolTip = new GMapRoundedToolTip(marker);
                    marker.ToolTipText = String.Format($"{checkedBank.name}{Environment.NewLine}{department.address}{Environment.NewLine}" +
                        $"USD покупка/продажа: {checkedBank.currentCourse.USD.Buy:N3}/{checkedBank.currentCourse.USD.Sell:N3}{Environment.NewLine}" +
                        $"EUR покупка/продажа: {checkedBank.currentCourse.EUR.Buy:N3}/{checkedBank.currentCourse.EUR.Sell:N3}{Environment.NewLine}" +
                        $"RUR покупка/продажа: {checkedBank.currentCourse.RUR.Buy:N3}/{checkedBank.currentCourse.RUR.Sell:N3}");
                    _departmentsPositionOverlay.Markers.Add(marker);
                }
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                _departmentsPositionOverlay.Markers.Clear();
                _closerDepartmentOverlay.Markers.Clear();
                foreach (Bank bank in clbBanks.CheckedItems)
                {
                    if (bank != checkedBank)
                    {
                        foreach (var department in bank.departmens)
                        {
                            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(department.latitude, department.longitude), GMarkerGoogleType.green);
                            marker.ToolTip = new GMapRoundedToolTip(marker);
                            marker.ToolTipText = String.Format($"{bank.name}{Environment.NewLine}{department.address}{Environment.NewLine}" +
                                $"USD покупка/продажа: {bank.currentCourse.USD.Buy:N3}/{bank.currentCourse.USD.Sell:N3}{Environment.NewLine}" +
                                $"EUR покупка/продажа: {bank.currentCourse.EUR.Buy:N3}/{bank.currentCourse.EUR.Sell:N3}{Environment.NewLine}" +
                                $"RUR покупка/продажа: {bank.currentCourse.RUR.Buy:N3}/{bank.currentCourse.RUR.Sell:N3}");
                            _departmentsPositionOverlay.Markers.Add(marker);
                        }
                    }
                }
            }
        }


        private void clbBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bank selectedBank = clbBanks.SelectedItem as Bank;
            tbUsdBuy.Text = selectedBank.currentCourse.USD.Buy.ToString("N3");
            tbEurBuy.Text = selectedBank.currentCourse.EUR.Buy.ToString("N3");
            tbRurBuy.Text = selectedBank.currentCourse.RUR.Buy.ToString("N3");
            tbUsdSell.Text = selectedBank.currentCourse.USD.Sell.ToString("N3");
            tbEurSell.Text = selectedBank.currentCourse.EUR.Sell.ToString("N3");
            tbRurSell.Text = selectedBank.currentCourse.RUR.Sell.ToString("N3");
        }


        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbBanks.Items.Count; i++)
            {
                clbBanks.SetItemChecked(i, true);
            }
        }


        private void btnUnselectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbBanks.Items.Count; i++)
            {
                clbBanks.SetItemChecked(i, false);
            }
        }


        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            banks = new BankRepository(courses, departments);
            clbBanks.DataSource = banks.GetBanks();
        }


        private void btnLoadCourses_Click(object sender, EventArgs e)
        {
            courses = new CourseRepository();
        }


        private void btnLoadDepartments_Click(object sender, EventArgs e)
        {
            departments = new DepartmentRepository(XmlHelper.DeserializeDepartments("banks.xml"));
        }


        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (developerToolStripMenuItem.CheckState == CheckState.Checked)
            {
                gbDeveloper.Enabled = true;
                btnDBcreate.Enabled = true;
                btnDeserialize.Enabled = true;
                btnLoadCourses.Enabled = true;
                btnLoadDepartments.Enabled = true;
            }
            else
            {
                gbDeveloper.Enabled = false;
                btnDBcreate.Enabled = false;
                btnDeserialize.Enabled = false;
                btnLoadCourses.Enabled = false;
                btnLoadDepartments.Enabled = false;
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}
