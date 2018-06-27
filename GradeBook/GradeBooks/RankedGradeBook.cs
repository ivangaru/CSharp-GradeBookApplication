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
            if (this.Students.Count < 5) throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            if (averageGrade >= 80) return 'A';
            if (averageGrade >= 60) return 'B';
            if (averageGrade >= 40) return 'C';
            if (averageGrade >= 20) return 'D';
            return 'F';
        }
    }
}
