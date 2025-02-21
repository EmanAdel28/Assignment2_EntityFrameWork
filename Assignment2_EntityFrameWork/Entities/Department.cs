using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


        [Required]
        public DateTime HiringDate { get; set; }

        [ForeignKey("Instructor")]
        public int? Ins_ID { get; set; }
        // One TO Many => Student
        [InverseProperty("Department")]
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();

        // One TO Many => Instructor
        [InverseProperty("DeptInstructor")]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        // ONE TO ONE Instructors
        [InverseProperty("InstructorManager")]
        public Instructor Instructor { get; set; }



    }
}
