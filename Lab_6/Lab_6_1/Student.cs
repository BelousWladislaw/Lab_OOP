using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Student : Human
    {
        private int mathScore;
        private int physScore;
        private int hystScore;

        public Student(int setMath, int setPhys, int setHyust)
        {
            mathScore = setMath;
            physScore = setPhys;
            hystScore = setHyust;
        }

        public float averageScore()
        {
            return (mathScore + physScore + hystScore) / 3;
        }

        public override int Info()
        {
            if (mathScore > physScore && mathScore > hystScore)
                return mathScore;
            else if (physScore > hystScore)
                return physScore;
            else
                return hystScore;
        }
    }
}
