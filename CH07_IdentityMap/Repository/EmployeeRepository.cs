using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class EmployeeRepository : IEmployeeRepository
    {
        private IdentityMap<Employee> _employeeMap;
        public EmployeeRepository()
        {
            _employeeMap = new IdentityMap<Employee>();
        }
        public Employee FindBy(Guid Id)
        {
            Employee employee = _employeeMap.GetById(Id);
            if (employee == null)
            {
                employee = DatastoreFindBy(Id);
                if (employee != null)
                    _employeeMap.Store(employee, employee.Id);
            }
            return employee;
        }
        private Employee DatastoreFindBy(Guid Id)
        {
            Employee employee = default(Employee);
            // Code to hydrate employee from datastore...
            return employee;
        }
    }

}
