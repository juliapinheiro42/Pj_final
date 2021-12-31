using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please, enter  first name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please, enter  last name")]
        public string LastName { get; set; }
        [MaxLength(5)]
        public string EmpCode { get; set; }
        public int Position { get; set; }

    }
}
