using Kreta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Repositories
{
    public class StudentsRepo
    {
        private List<Student> students;
        public List<Student> Students { get => students; }

        public StudentsRepo()
        {
            students = new List<Student>();
            MakeTestData();
        }  
        public void MakeTestData()
        {
            students.Add(new Student(1,"Imre Zoltán",2));
            students.Add(new Student(2,"Nagy Anna",1));
            students.Add(new Student(3,"Kis Imre",3));
            students.Add(new Student(4, "Péter Zoltán", 4));
            students.Add(new Student(5, "Ávra Virág", 1));
            students.Add(new Student(6, "Zolyom Rebeka", 2));
            students.Add(new Student(7, "Varga Aladár", 3));
            students.Add(new Student(8, "Nyugvó Roland", 1));
            students.Add(new Student(9, "Nyugvó Roland", 1));
            students.Add(new Student(10, "Marakodó Melinda", 2));
            students.Add(new Student(11, "Jobbágy Rita", 4));
            students.Add(new Student(12, "Nagy Virág", 4));
            students.Add(new Student(13, "Tanuló Péter", 0));
            students.Add(new Student(14, "Nagy Lajos", 0));
            students.Add(new Student(15, "Péter László", 0));
        }
    }
}

