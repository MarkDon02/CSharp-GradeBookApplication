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
            if (Students.Count < 5)                
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
           
            if (averageGrade <= 0.20)
                return GetLetterGrade('A');
            if (averageGrade > 0.20 && averageGrade <= 0.40)
                return GetLetterGrade('B');
            if (averageGrade > 0.40 && averageGrade <= 0.60)
                return GetLetterGrade('C');
            if (averageGrade > 0.60 && averageGrade <= 0.80)
                return GetLetterGrade('D');
            else
                return GetLetterGrade('F');
            
            
        }
    }
}
