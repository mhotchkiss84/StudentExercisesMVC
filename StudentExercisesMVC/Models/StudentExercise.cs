using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercisesMVC.Models
{
    class StudentExercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public List<Student> assignedStudnets { get; set; } = new List<Student>();
    }
}
