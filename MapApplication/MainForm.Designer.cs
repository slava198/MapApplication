namespace MapApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEurSell = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEurBuy = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRurSell = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRurBuy = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.gbDeveloper = new System.Windows.Forms.GroupBox();
            this.btnLoadCourses = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.btnLoadDepartments = new System.Windows.Forms.Button();
            this.btnDBcreate = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnUnselectAll = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsdSell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsdBuy = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.btnCloserDep = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.clbBanks = new System.Windows.Forms.CheckedListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.приложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiAddDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmiAddPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.gbDeveloper.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbEurSell);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbEurBuy);
            this.groupBox2.Location = new System.Drawing.Point(6, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 51);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EUR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "BYN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Продажа:";
            // 
            // tbEurSell
            // 
            this.tbEurSell.Location = new System.Drawing.Point(247, 19);
            this.tbEurSell.Name = "tbEurSell";
            this.tbEurSell.ReadOnly = true;
            this.tbEurSell.Size = new System.Drawing.Size(37, 20);
            this.tbEurSell.TabIndex = 2;
            this.tbEurSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "BYN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Покупка:";
            // 
            // tbEurBuy
            // 
            this.tbEurBuy.Location = new System.Drawing.Point(74, 19);
            this.tbEurBuy.Name = "tbEurBuy";
            this.tbEurBuy.ReadOnly = true;
            this.tbEurBuy.Size = new System.Drawing.Size(37, 20);
            this.tbEurBuy.TabIndex = 0;
            this.tbEurBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbRurSell);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbRurBuy);
            this.groupBox3.Location = new System.Drawing.Point(6, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 51);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RUR (100 RUR)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "BYN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Продажа:";
            // 
            // tbRurSell
            // 
            this.tbRurSell.Location = new System.Drawing.Point(247, 19);
            this.tbRurSell.Name = "tbRurSell";
            this.tbRurSell.ReadOnly = true;
            this.tbRurSell.Size = new System.Drawing.Size(37, 20);
            this.tbRurSell.TabIndex = 2;
            this.tbRurSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "BYN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Покупка:";
            // 
            // tbRurBuy
            // 
            this.tbRurBuy.Location = new System.Drawing.Point(74, 19);
            this.tbRurBuy.Name = "tbRurBuy";
            this.tbRurBuy.ReadOnly = true;
            this.tbRurBuy.Size = new System.Drawing.Size(37, 20);
            this.tbRurBuy.TabIndex = 0;
            this.tbRurBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.gbDeveloper);
            this.splitContainer.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer.Panel1.Controls.Add(this.groupBox6);
            this.splitContainer.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer.Panel1.Controls.Add(this.clbBanks);
            this.splitContainer.Panel1.Controls.Add(this.splitter1);
            this.splitContainer.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer.Size = new System.Drawing.Size(1127, 599);
            this.splitContainer.SplitterDistance = 356;
            this.splitContainer.TabIndex = 0;
            // 
            // gbDeveloper
            // 
            this.gbDeveloper.Controls.Add(this.btnLoadCourses);
            this.gbDeveloper.Controls.Add(this.btnDeserialize);
            this.gbDeveloper.Controls.Add(this.btnLoadDepartments);
            this.gbDeveloper.Controls.Add(this.btnDBcreate);
            this.gbDeveloper.Enabled = false;
            this.gbDeveloper.Location = new System.Drawing.Point(9, 455);
            this.gbDeveloper.Name = "gbDeveloper";
            this.gbDeveloper.Size = new System.Drawing.Size(344, 140);
            this.gbDeveloper.TabIndex = 0;
            this.gbDeveloper.TabStop = false;
            this.gbDeveloper.Text = "Меню разработчика";
            // 
            // btnLoadCourses
            // 
            this.btnLoadCourses.Enabled = false;
            this.btnLoadCourses.Location = new System.Drawing.Point(6, 22);
            this.btnLoadCourses.Name = "btnLoadCourses";
            this.btnLoadCourses.Size = new System.Drawing.Size(165, 35);
            this.btnLoadCourses.TabIndex = 4;
            this.btnLoadCourses.Text = "Загрузить курсы валют с сайта";
            this.btnLoadCourses.UseVisualStyleBackColor = true;
            this.btnLoadCourses.Click += new System.EventHandler(this.btnLoadCourses_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Enabled = false;
            this.btnDeserialize.Location = new System.Drawing.Point(6, 63);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(332, 31);
            this.btnDeserialize.TabIndex = 1;
            this.btnDeserialize.Text = "Создать объекты банков на основе обменников и курсов";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // btnLoadDepartments
            // 
            this.btnLoadDepartments.Enabled = false;
            this.btnLoadDepartments.Location = new System.Drawing.Point(177, 22);
            this.btnLoadDepartments.Name = "btnLoadDepartments";
            this.btnLoadDepartments.Size = new System.Drawing.Size(161, 35);
            this.btnLoadDepartments.TabIndex = 8;
            this.btnLoadDepartments.Text = "Загрузить список обменников из XML-файла";
            this.btnLoadDepartments.UseVisualStyleBackColor = true;
            this.btnLoadDepartments.Click += new System.EventHandler(this.btnLoadDepartments_Click);
            // 
            // btnDBcreate
            // 
            this.btnDBcreate.Enabled = false;
            this.btnDBcreate.Location = new System.Drawing.Point(6, 100);
            this.btnDBcreate.Name = "btnDBcreate";
            this.btnDBcreate.Size = new System.Drawing.Size(332, 31);
            this.btnDBcreate.TabIndex = 2;
            this.btnDBcreate.Text = "Создать базу данных банков, обменников и курсов";
            this.btnDBcreate.UseVisualStyleBackColor = true;
            this.btnDBcreate.Click += new System.EventHandler(this.btnDBcreate_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSelectAll);
            this.groupBox5.Controls.Add(this.btnUnselectAll);
            this.groupBox5.Location = new System.Drawing.Point(197, 220);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(156, 90);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выбор банков";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(9, 19);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(136, 28);
            this.btnSelectAll.TabIndex = 16;
            this.btnSelectAll.Text = "Выбрать все";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnUnselectAll
            // 
            this.btnUnselectAll.Location = new System.Drawing.Point(9, 53);
            this.btnUnselectAll.Name = "btnUnselectAll";
            this.btnUnselectAll.Size = new System.Drawing.Size(136, 28);
            this.btnUnselectAll.TabIndex = 16;
            this.btnUnselectAll.Text = "Очистить выделение";
            this.btnUnselectAll.UseVisualStyleBackColor = true;
            this.btnUnselectAll.Click += new System.EventHandler(this.btnUnselectAll_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Location = new System.Drawing.Point(9, 27);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 187);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Курсы валют";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbUsdSell);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbUsdBuy);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 51);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "BYN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Продажа:";
            // 
            // tbUsdSell
            // 
            this.tbUsdSell.Location = new System.Drawing.Point(247, 19);
            this.tbUsdSell.Name = "tbUsdSell";
            this.tbUsdSell.ReadOnly = true;
            this.tbUsdSell.Size = new System.Drawing.Size(37, 20);
            this.tbUsdSell.TabIndex = 2;
            this.tbUsdSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "BYN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Покупка:";
            // 
            // tbUsdBuy
            // 
            this.tbUsdBuy.Location = new System.Drawing.Point(74, 19);
            this.tbUsdBuy.Name = "tbUsdBuy";
            this.tbUsdBuy.ReadOnly = true;
            this.tbUsdBuy.Size = new System.Drawing.Size(37, 20);
            this.tbUsdBuy.TabIndex = 0;
            this.tbUsdBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCurrency);
            this.groupBox4.Controls.Add(this.cbOperation);
            this.groupBox4.Controls.Add(this.btnCloserDep);
            this.groupBox4.Controls.Add(this.btnFind);
            this.groupBox4.Location = new System.Drawing.Point(197, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 134);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск обменных пунктов";
            // 
            // cbCurrency
            // 
            this.cbCurrency.BackColor = System.Drawing.SystemColors.Control;
            this.cbCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(83, 19);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(65, 21);
            this.cbCurrency.TabIndex = 13;
            // 
            // cbOperation
            // 
            this.cbOperation.BackColor = System.Drawing.SystemColors.Control;
            this.cbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(9, 19);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(61, 21);
            this.cbOperation.TabIndex = 12;
            // 
            // btnCloserDep
            // 
            this.btnCloserDep.Location = new System.Drawing.Point(9, 99);
            this.btnCloserDep.Name = "btnCloserDep";
            this.btnCloserDep.Size = new System.Drawing.Size(139, 28);
            this.btnCloserDep.TabIndex = 9;
            this.btnCloserDep.Text = "Найти ближайший пункт";
            this.btnCloserDep.UseVisualStyleBackColor = true;
            this.btnCloserDep.Click += new System.EventHandler(this.btnCloserDep_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(9, 46);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(139, 47);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Найти ближайший пункт с лучшим курсом";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // clbBanks
            // 
            this.clbBanks.FormattingEnabled = true;
            this.clbBanks.Location = new System.Drawing.Point(9, 220);
            this.clbBanks.Name = "clbBanks";
            this.clbBanks.Size = new System.Drawing.Size(182, 229);
            this.clbBanks.TabIndex = 6;
            this.clbBanks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbBanks_ItemCheck);
            this.clbBanks.SelectedIndexChanged += new System.EventHandler(this.clbBanks_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 574);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приложениеToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3);
            this.menuStrip1.Size = new System.Drawing.Size(356, 25);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // приложениеToolStripMenuItem
            // 
            this.приложениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.приложениеToolStripMenuItem.Name = "приложениеToolStripMenuItem";
            this.приложениеToolStripMenuItem.Size = new System.Drawing.Size(91, 19);
            this.приложениеToolStripMenuItem.Text = "Приложение";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 19);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // ctxmiAddDepartment
            // 
            this.ctxmiAddDepartment.Name = "ctxmiAddDepartment";
            this.ctxmiAddDepartment.Size = new System.Drawing.Size(32, 19);
            // 
            // ctxmiAddPosition
            // 
            this.ctxmiAddPosition.Name = "ctxmiAddPosition";
            this.ctxmiAddPosition.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MapApplication.Properties.Resources.close;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.CheckOnClick = true;
            this.developerToolStripMenuItem.Image = global::MapApplication.Properties.Resources.tools;
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.developerToolStripMenuItem.Text = "Режим разработчика";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::MapApplication.Properties.Resources.info;
            this.оПрограммеToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 599);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лучший курс";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMap_MouseClick);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.gbDeveloper.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEurSell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEurBuy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRurSell;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRurBuy;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button btnCloserDep;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUsdSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsdBuy;
        private System.Windows.Forms.Button btnUnselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnLoadDepartments;
        private System.Windows.Forms.CheckedListBox clbBanks;
        private System.Windows.Forms.Button btnLoadCourses;
        private System.Windows.Forms.Button btnDBcreate;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem приложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctxmiAddDepartment;
        private System.Windows.Forms.ToolStripMenuItem ctxmiAddPosition;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbDeveloper;
    }
}

