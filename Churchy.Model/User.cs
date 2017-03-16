﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churchy.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public int ChurchId { get; set; }
        public Course Course { get; set; }


    }
}
