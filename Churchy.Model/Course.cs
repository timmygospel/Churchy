﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churchy.Model
{
    public class Course
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseCapacity { get; set; }
        public int ChurchId { get; set; }

    }
}
