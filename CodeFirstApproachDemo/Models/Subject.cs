using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstApproachDemo.Models
{
    class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }

        public List<Batch> Batches { get; set; }
    }
}
