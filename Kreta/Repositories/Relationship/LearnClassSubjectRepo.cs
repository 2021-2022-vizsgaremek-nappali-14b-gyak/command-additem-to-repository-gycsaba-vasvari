using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models.Relationship;

namespace Kreta.Repositories.Relationship
{
    class LearnClassSubjectRepo
    {
        private List<LearnClassSubject> learnClassSubject;

        public List<LearnClassSubject> LearnClassSubject { get => learnClassSubject; }

        public LearnClassSubjectRepo()
        {
            learnClassSubject = new List<LearnClassSubject>();
            MakeTestData();
        }

        public void MakeTestData()
        {
            learnClassSubject.Add(new LearnClassSubject(1, 1));
            learnClassSubject.Add(new LearnClassSubject(1, 2));
            learnClassSubject.Add(new LearnClassSubject(3, 1));
            learnClassSubject.Add(new LearnClassSubject(4, 2));
            learnClassSubject.Add(new LearnClassSubject(4, 3));
        }
    }
}
