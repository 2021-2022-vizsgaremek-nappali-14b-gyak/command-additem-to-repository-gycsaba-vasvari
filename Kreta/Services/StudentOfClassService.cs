using Kreta.Models;
using Kreta.Repositories;
using System.Collections.Generic;

namespace Kreta.Services
{
    class StudentOfClassService
    {
        SchoolClassesRepo schoolClassesRepo
            ;
        StudentsRepo studentsRepo;

        public StudentOfClassService()
        {
            schoolClassesRepo = new SchoolClassesRepo();
            studentsRepo = new StudentsRepo();
        }

        public List<SchoolClass> Classes
        {
            get 
            {
                return schoolClassesRepo.SchoolClasses;
            }
        }

        public List<Student> GetStudentOfClass(int classId)
        {
            return studentsRepo.Students.FindAll(student => student.SchoolClassId == classId);
        }

        public List<Student> GetStudentNoClass()
        {
            return studentsRepo.Students.FindAll(student => student.SchoolClassId == 0);
        }
    }
}
