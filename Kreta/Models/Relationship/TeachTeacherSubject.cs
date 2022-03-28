using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Relationship
{
    class TeachTeacherSubject
    {
        private int teacherID;
        private int subjectID;

        public TeachTeacherSubject(int teacherID, int subjectID)
        {
            this.teacherID = teacherID;
            this.subjectID = subjectID;
        }

        public int TeacherID { get => teacherID; set => teacherID = value; }
        public int SubjectID { get => subjectID; set => subjectID = value; }
    }
}
