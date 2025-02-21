using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_EntityFrameWork.Entities
{
    public class Topic
    {
        public int ID { get; set; }

        [StringLength(10, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
