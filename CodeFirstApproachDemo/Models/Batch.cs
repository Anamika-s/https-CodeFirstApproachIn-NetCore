using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstApproachDemo.Models
{
    class Batch
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public int Strength { get; set; }

        public DateTime StartDAte { get; set; }
        public List<Student> Students { get; set; }
        [ForeignKey("Subject")]
        public int SubjectRefId { get; set; }
        public Subject Subject { get; set; }

    }
}
