using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    
    public class EmployeeController : ApiController
    {
        private static List<Employee> data = new List<Employee>();
        // GET api/values
        public IEnumerable<Employee> Get()
        {
            //return new string[] { "value1", "value2" };            
            data.Add(new Employee(){ BirthDate = DateTime.MinValue, DepartmentId =1, FirstName = "Raghu", LastName = "toranalu", Id = 1 });
            data.Add(new Employee() { BirthDate = DateTime.MinValue, DepartmentId = 1, FirstName = "Reo", LastName = "Bernal", Id = 2 });
            data.Add(new Employee() { BirthDate = DateTime.MinValue, DepartmentId = 1, FirstName = "Siva", LastName = "Kumar", Id = 3 });
            data.Add(new Employee() { BirthDate = DateTime.MinValue, DepartmentId = 1, FirstName = "Siva", LastName = "Kumar", Id = 4 });
            return data;
        }

        // GET api/values/5
        public Employee Get(int id)
        {
            if (data != null)
            {
                return data.FirstOrDefault(s => s.Id == id );
            }
            else
            {
                return null;
            }
        }

        // POST api/values
        public void Post([FromBody]Employee employee)
        {
            try
            {
                var _employee = new Employee()
                {
                    Id = 1,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    BirthDate = employee.BirthDate,
                    DepartmentId = employee.DepartmentId
                };

                if (_employee == null)
                {
                    throw new ArgumentNullException();
                }

                data.Add(_employee);                
            }
            catch (Exception ex)
            {
                
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
