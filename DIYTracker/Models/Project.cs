﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIYTracker.Models
{
    public class Project
    {
        public string Id { get; set; }

        public User User { get; set; }
    }
}