using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models;

namespace Kreta.Repositories
{
    public class SchoolClassesRepo
    {
        private List<SchoolClass> classes;

        public List<SchoolClass> SchoolClasses { get => classes; }

        public SchoolClassesRepo()
        {
            classes = new List<SchoolClass>();
            MakeTestData();
        }

        public void MakeTestData()
        {
            classes.Add(new SchoolClass(1, 9, 'a', 4));
            classes.Add(new SchoolClass(2, 9, 'b', 1));
            classes.Add(new SchoolClass(3, 10, 'a', 6));
            classes.Add(new SchoolClass(4, 10, 'b', 3));
            classes.Add(new SchoolClass(5, 10, 'c', 0));
        }
    }
}
