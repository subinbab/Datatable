using Datatable.Models;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Datatable.Data
{
    public class EmployeeData
    {
       public static List<Employee> GetEMployee()
        {
            using (EmployeeDbContext db = new EmployeeDbContext())
            {
                return db.employeeTable.ToList();
            }
        }
        public static HttpResponseMessage AddEmployee(Employee employee)
        {
            try
            {
                using(EmployeeDbContext db = new EmployeeDbContext())
                {
                    db.employeeTable.Add(employee);
                    db.SaveChanges();
                    return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
                }
            }
            catch
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            }
        }
    }
}