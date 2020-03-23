using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            var totalStudents = Students.Count * 0.20;

            if (totalStudents < 5)
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            if (totalStudents >= 5)
            {
                if (averageGrade <= 0.20)
                    return base.GetLetterGrade('A');
                else if (averageGrade > 0.20 && averageGrade <= 0.40)
                    return base.GetLetterGrade('B');
                else if (averageGrade > 0.40 && averageGrade <= 0.60)
                    return base.GetLetterGrade('C');
                else if (averageGrade > 0.60 && averageGrade <= 0.80)
                    return base.GetLetterGrade('D');
            }
          
               return base.GetLetterGrade('F');
        }
    }
}
