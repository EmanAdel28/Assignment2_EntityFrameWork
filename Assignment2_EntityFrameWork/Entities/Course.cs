using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_EntityFrameWork.Entities
{
    public class Course
    {

        public int ID { get; set; }

        [MaxLength(10)]
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        [Range(20, 40)]
        public int Duration { get; set; }
        // One To Many => Topic
        [ForeignKey("Topic")]
        public int? Top_ID { get; set; }

        [InverseProperty("Course")]
        public Topic Topic { get; set; }

        
    }
}
