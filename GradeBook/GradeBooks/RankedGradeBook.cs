using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5) throw new InvalidOperationException("Ranked-grading requires a minimum of 5 " +
                "students to work");
            if (averageGrade >= 80) return 'A';
            if (averageGrade >= 60) return 'B';
            if (averageGrade >= 40) return 'C';
            if (averageGrade >= 20) return 'D';
            return 'F';
        }

        public override void CalculateStatistics()
        {
            if (this.Students.Count < 5) Console.WriteLine("Ranked grading requires at least 5 students with grades " +
                "in order to properly calculate a student's overall grade.");
            else
                base.CalculateStatistics();
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (this.Students.Count < 5) Console.WriteLine("Ranked grading requires at least 5 students with grades " +
                 "in order to properly calculate a student's overall grade.");
            else
                base.CalculateStudentStatistics(name);
        }
    }
}
