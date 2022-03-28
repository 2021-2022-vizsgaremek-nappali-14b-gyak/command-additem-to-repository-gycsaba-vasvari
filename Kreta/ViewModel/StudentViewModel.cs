using Kreta.Models;
using Kreta.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.ViewModel
{
    public class StudentViewModel
    {
        private StudentsRepo studentsRepo;
        private ObservableCollection<Student> students;

        public StudentViewModel()
        {
            studentsRepo = new StudentsRepo();
            students = new ObservableCollection<Student>(studentsRepo.Students);
        }
        public ObservableCollection<Student> Students { get => students; set => students = value; }
    }
}
