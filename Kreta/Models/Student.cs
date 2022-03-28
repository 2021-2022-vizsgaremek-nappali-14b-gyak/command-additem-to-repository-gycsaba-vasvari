using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models
{
    public class Student
    {
        private int id;
        private string fullname;
        private int osztalyId;

        public Student(int id, string fullname, int osztalyId)
        {
            this.Id = id;
            this.Fullname = fullname;
            this.SchoolClassId = osztalyId;
        }

        public int Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public int SchoolClassId { get => osztalyId; set => osztalyId = value; }

        public string IdFullname
        {
            get
            {
                return id + "   " + fullname;
            }
        }

        public override string ToString()
        {
            string output = id+". "+ fullname;
            return output;
        }
    }
}
