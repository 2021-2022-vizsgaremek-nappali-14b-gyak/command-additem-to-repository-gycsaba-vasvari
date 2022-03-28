using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Relationship
{
    class LearnClassSubject
    {
        private int classId;
        private int SubjectId;

        public LearnClassSubject(int classId, int subjectId)
        {
            this.classId = classId;
            SubjectId = subjectId;
        }

        public int ClassId { get => classId; set => classId = value; }
        public int SubjectId1 { get => SubjectId; set => SubjectId = value; }
    }
}
