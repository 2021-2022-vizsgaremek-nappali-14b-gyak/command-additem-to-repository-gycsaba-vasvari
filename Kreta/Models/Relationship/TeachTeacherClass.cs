using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models.Relationship
{
    class TeachTeacherClass
    {
        private int teacherId;
        private int classId;
        private int numberOfTeachingHours;

        public TeachTeacherClass(int teacherId, int classId, int numberOfTeachingHours)
        {
            this.teacherId = teacherId;
            this.classId = classId;
            this.numberOfTeachingHours = numberOfTeachingHours;
        }

        public int TeacherId { get => teacherId; set => teacherId = value; }
        public int ClassId { get => classId; set => classId = value; }
        public int NumberOfTeachingHours { get => numberOfTeachingHours; set => numberOfTeachingHours = value; }
    }
}
