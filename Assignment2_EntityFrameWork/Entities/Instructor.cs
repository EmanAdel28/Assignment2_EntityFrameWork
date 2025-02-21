using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_EntityFrameWork.Entities
{
    public class Instructor
    {
        public int ID { get; set; }

        [MaxLength(10)]
        [Required]
        public string Name { get; set; }
        public decimal Bouns { get; set; }

        [Range(2000, 10000)]
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public int? Dept_ID { get; set; }
    }
}
