using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vizsgaremek.Models;

namespace Vizsgaremek.Repositories
{
    public partial class Teachers
    {
        private List<Teacher> teachers;

        public List<Teacher> AllTeachers
        {
            get
            {
                return teachers;
            }
        }

        public Teachers()
        {
            teachers = new List<Teacher>();
            MakeTestData();
        }

        public void MakeTestData()
        {
            teachers.Add(new Teacher(1, "Számoló", "Szonja", "123456", true, EmploymentValue.LECTURER));
            teachers.Add(new Teacher(2, "Buktató", "Béla", "123456", false, EmploymentValue.INDENTUREDLABOURER));
            teachers.Add(new Teacher(3, "Aritmetika", "Antal", "123456", false, EmploymentValue.DONEONCOMMISSION));
            teachers.Add(new Teacher(4, "Arany", "András", "123456", false, EmploymentValue.DONEONCOMMISSION));
            teachers.Add(new Teacher(5, "Sportoló", "Jenő", "123456", false, EmploymentValue.DONEONCOMMISSION));
            teachers.Add(new Teacher(6, "Visszanéző", "Viola", "123456", false, EmploymentValue.DONEONCOMMISSION));
        }
    }
}
