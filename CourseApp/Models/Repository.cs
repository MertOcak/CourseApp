﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<Student> _students = new List<Student>();

        // Repository.Students

        public static List<Student> Students
        {
            get { return _students; }
        }

        // Repository.AddStudent(student);
        public static void AddStudent(Student student)
        {
            _students.Add(student);
        } 
    }
}
