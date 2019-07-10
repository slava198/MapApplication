using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;


namespace MapApplication.Entities
{
    public class BankRepository
    {
        BindingList<Bank> banks;

        public BankRepository(CourseRepository courseRepository, DepartmentRepository departmentRepository)
        {

            banks = new BindingList<Bank>();
            foreach (var item in courseRepository.GetCourses())
            {
                banks.Add(new Bank() { id = item.BankID, currentCourse = item, departmens = new List<Departmen>() });
            }
            banks.ToList().ForEach(b => b.SetName());

            foreach (var bank in banks)
            {
                foreach (var department in departmentRepository.GetDepartments())
                {
                    if (bank.name == department.bankName)
                    {
                        bank.AddDepartment(department);
                    }
                }
            }
        }


        public BankRepository()
        {
            banks = new BindingList<Bank>();
        }


        public BankRepository(BindingList<Bank> banks)
        {
            this.banks = banks;
        }


        public IEnumerable<Bank> GetBanks()
        {
            return banks;
        }
    }
}
