using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_EntityFrameWork.Entities
{
    public class Department
    {

        public int ID { get; set; }

        [MaxLength(15)]
        [Required]
        public string Name { get; set; }
        public int? Ins_ID { get; set; }

        [Required]
        public DateTime HiringDate { get; set; }
    }
}
