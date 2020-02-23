﻿using System;
using System.Collections.Generic;
using System.Text;

namespace University.DAL.Model
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public virtual Course Course { get; set; }
    }
}
