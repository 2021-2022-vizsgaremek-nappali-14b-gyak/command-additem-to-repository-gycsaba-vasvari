using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models
{
    public class SchoolClass
    {
        private int id;
        private int grade;
        private char gradeType;
        private int teacherId;

        public SchoolClass(int id, int grade, char gradeType, int teacherId)
        {
            this.id = id;
            this.grade = grade;
            this.gradeType = gradeType;
            this.teacherId = teacherId;
        }

        public int Id { get => id; set => id = value; }
        public int Grade { get => grade; set => grade = value; }
        public char GradeType { get => gradeType; set => gradeType = value; }
        public int TeacherId { get => teacherId; set => teacherId = value; }
        public string GradeGradeType
        {
            get
            {
                string result = grade + ". " + gradeType;
                return result;
            }
        }

        public override string ToString()
        {
            string output = "Osztály adatok:" + id + ". " + grade + "." + gradeType + "->" + teacherId;
            return output;
        }
    }
}
