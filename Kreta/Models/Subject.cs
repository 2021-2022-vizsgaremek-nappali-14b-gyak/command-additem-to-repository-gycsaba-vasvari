using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Models
{
    public class Subject
    {

        private int id;
        private string subName;

        public Subject(int id, string subName)
        {
            this.Id = id;
            this.SubName = subName;
        }

        public int Id { get => id; set => id = value; }
        public string SubName { get => subName; set => subName = value; }

        public override string ToString()
        {
            string output = "Tamtárgy adatok" + id + ". " + SubName;
            return output;
        }
    }
}
