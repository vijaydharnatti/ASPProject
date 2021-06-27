using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POC1Application.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int EmployeeDetailsID { get; set; }        
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
    }
}
