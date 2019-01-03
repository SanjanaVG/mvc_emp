using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Emp_Mvc.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Required")]
        public string EmpId { get; set; }

        [Required(ErrorMessage = "Required")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }

        public string LoginMessage { get; set; }

        //public int RoleId { get; set; }
    }
}