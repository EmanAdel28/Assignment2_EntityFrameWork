using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_EntityFrameWork.Entities
{
    public class Student
    {
        public int Id { get; set; }

        [MaxLength(10)]
        [Required]
        public string Fname { get; set; }

        [MaxLength(10)]
        [Required]
        public string Lname { get; set; }

        [StringLength(60, MinimumLength = 10)]
        public string Address { get; set; }

        [Range(18, 27)]
        public int? Age { get; set; }

        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        [InverseProperty("Students")]
        public Department Department { get; set; }




    }
}
