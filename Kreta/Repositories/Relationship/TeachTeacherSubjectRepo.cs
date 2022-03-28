using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models.Relationship;

namespace Kreta.Repositories.Relationship
{
    class TeachTeacherSubjectRepo
    {
        private List<TeachTeacherSubject> teachTeacherSubject;

        public List<TeachTeacherSubject> TeachTeacherSubject { get => teachTeacherSubject; }

        public TeachTeacherSubjectRepo()
        {
            teachTeacherSubject = new List<TeachTeacherSubject>();
            MakeTestData();
        }

        public void MakeTestData()
        {
            teachTeacherSubject.Add(new TeachTeacherSubject(1, 1));
            teachTeacherSubject.Add(new TeachTeacherSubject(1, 2));
            teachTeacherSubject.Add(new TeachTeacherSubject(2, 1));
            teachTeacherSubject.Add(new TeachTeacherSubject(2, 2));
            teachTeacherSubject.Add(new TeachTeacherSubject(2, 3));
        }
    }
}
