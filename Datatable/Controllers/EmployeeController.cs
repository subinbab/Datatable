using Datatable.Data;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Datatable.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> employeeList = null;
        public List<Employee> Get()
        {
            employeeList = EmployeeData.GetEMployee();
            return employeeList;
        }
        public HttpResponseMessage Post([FromBody] Employee employee)
        {
            return EmployeeData.AddEmployee(employee);
        }
    }
}
