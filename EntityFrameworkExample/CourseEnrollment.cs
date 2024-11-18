using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{

    public class CourseEnrollment
    {

        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Course course { get; set; }
        public Student student { get; set; }

    }
}
