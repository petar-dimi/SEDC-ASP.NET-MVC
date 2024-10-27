﻿using System.Diagnostics;

namespace Academy_management_app.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
