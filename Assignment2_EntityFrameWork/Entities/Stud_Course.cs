using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_EntityFrameWork.Entities
{
    public class Stud_Course
    {

        public int stud_ID { get; set; }

        public int Course_ID { get; set; }

        [Range(0, 4)]
        public decimal Grade { get; set; }
    }
}
