using Kreta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Repositories
{
    public class SubjectRepo
    {
        private List<Subject> subject;
        public List<Subject> Subject { get => subject; }

        public SubjectRepo()
        {
            subject = new List<Subject>();
            MakeTestData();
        }

        public void MakeTestData()
        {

            Subject.Add(new Subject(1,"Informatika"));
            Subject.Add(new Subject(2,"Angol"));
            Subject.Add(new Subject(3,"Matematika"));
            Subject.Add(new Subject(4,"Fizika"));
            Subject.Add(new Subject(5,"Testnevelés"));
            Subject.Add(new Subject(6,"Történelem"));
            Subject.Add(new Subject(7,"Magyar nyelv és Irodalom"));
        }
    }
}
