using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CodeProjectMVCDemoLab1.Validations;

namespace CodeProjectMVCDemoLab1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId{ get; set; }
        //[Required(ErrorMessage ="FirstName is Required")]
        [FirstNameValidation]
        public string FirstName { get; set; }
        [StringLength(5,ErrorMessage ="Last Name should not be more than 5 characters")]
        public string LastName { get; set; }
        [Required(ErrorMessage ="Salary accepts only Numbers")]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }
    }
}