using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using POC1Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POC1Application.Controllers
{
    
    [ApiController]
    public class EmployeeDetailController : ControllerBase
    {
        private readonly EmployeeDetailContext context;
        public EmployeeDetailController(EmployeeDetailContext _context)
        {
            context = _context;

        }

        // POST api/<EmployeeDetailController>
        //RouteAttribute(["api/EmployeeDetail/AddEmployee"])
        [Authorize]
        [HttpPost]
        [Route("EmployeeDetail/AddEmployee")]

        public void AddEmployee(EmployeeDetails ObjEmployeeDetails)
        {
            try {
                //EmployeeDetails ObjEmployeeDetails = new EmployeeDetails();
                //ObjEmployeeDetails.EmployeeName = "first";
                //ObjEmployeeDetails.Salary = 1000;
                if (ObjEmployeeDetails != null)
                {
                    context.Add(ObjEmployeeDetails);
                    context.SaveChanges();
                }
            }
            catch {
                throw;
            }        
          
        }

        // GET: api/<EmployeeDetailController>
        [HttpGet]
        [Route("EmployeeDetail/Get")]

        public List<EmployeeDetails> Get()
        {
           // List<EmployeeDetails> objEmployeeDetails = new List<EmployeeDetails>();
            try
            {
                var data = context.EmployeeDetails.ToList();
               
                return data;
            }
            catch {
                throw;
            }
        }

        // GET api/<EmployeeDetailController>/5
        //[HttpGet("{id}")]
        //[Route("EmployeeDetail/Add")]

        //public string Get(int id)
        //{
        //    return "value";
        //}

       

        //// PUT api/<EmployeeDetailController>/5
        //[HttpPut("{id}")]
        //[Route("EmployeeDetail/AddEmploy")]

        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<EmployeeDetailController>/5
        //[HttpDelete("{id}")]
        //[Route("EmployeeDetail/Delete")]

        //public void Delete(int id)
        //{
        //}
    }
}
