using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApproachDemo.Models
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Batch { get; set; }
        public int Marks { get; set; }
        public string Course { get; set; }
        
        // Child class
        public Batch Batch { get; set; }

    }
}
