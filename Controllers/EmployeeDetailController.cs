using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using POC1Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace POC1Application.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeDetailController : ControllerBase
    {
        private readonly EmployeeDetailContext context;
        public EmployeeDetailController(EmployeeDetailContext _context)
        {
            context = _context;

        }


        /// <summary>
        /// AddEmployee
        /// </summary>
        /// <param name="ObjEmployeeDetails"></param>
        [HttpPost]
        public void AddEmployee(EmployeeDetails ObjEmployeeDetails)
        {
            try {
              
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


        /// <summary>
        /// Get
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<EmployeeDetails> Get()
        {
            try
            {
                var data = context.EmployeeDetails.ToList();
               
                return data;
            }
            catch {
                throw;
            }
        }

       
    }
}
