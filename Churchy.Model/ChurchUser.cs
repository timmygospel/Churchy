﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Churchy.Model
{
    public class ChurchUser
    {
        public int Id { get; set; }
        public int ChurchId { get; set; }
        public Church church { get; set; }
        public User User { get; set; }
    }
}
