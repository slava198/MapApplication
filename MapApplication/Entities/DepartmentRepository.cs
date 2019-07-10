using MapApplication.DAL;
using System.Collections.Generic;

namespace MapApplication.Entities
{
    public class DepartmentRepository
    {
        List<Departmen> departmens;


        public DepartmentRepository()
        {
            departmens = DbHelper.DepsLoad();
        }


        public DepartmentRepository(List<Departmen> departmens)
        {
            this.departmens = departmens;
        }


        public List<Departmen> GetDepartments()
        {
            return departmens;
        }
    }
}
