using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class GradesModel
    {
        // This represents the variables in my model, each with a required range of 0-100 for the user 
        // inputing grades
        [Range(0,100)]
        public int assignments { get; set; }
        [Range(0, 100)]
        public int group { get; set; }
        [Range(0, 100)]
        public int quiz { get; set; }
        [Range(0, 100)]
        public int midterm { get; set; }
        [Range(0, 100)]
        public int final { get; set; }
        [Range(0, 100)]
        public int intex { get; set; }

    }

}
