using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models.Relationship;

namespace Kreta.Repositories.Relationship
{
    class TeachTeacherClassRepo
    {
        private List<TeachTeacherClass> teachTeacherClass;

        public List<TeachTeacherClass> TeachTeacherClass { get => teachTeacherClass; }

        public TeachTeacherClassRepo()
        {
            teachTeacherClass = new List<TeachTeacherClass>();
            MakeTestData();
        }

        public void MakeTestData()
        {
            teachTeacherClass.Add(new TeachTeacherClass(1, 1, 2));
        }
    }
}
