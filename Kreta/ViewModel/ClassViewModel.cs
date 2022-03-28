using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models;
using Kreta.Repositories;
using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    public class ClassViewModel
    {
        private SchoolClassesRepo classesRepo;
        private ObservableCollection<SchoolClass> schoolClasses;

        public ClassViewModel()
        {
            classesRepo = new SchoolClassesRepo();
            schoolClasses = new ObservableCollection<SchoolClass>(classesRepo.SchoolClasses);
        }

        public ObservableCollection<SchoolClass> SchoolClasses { get => schoolClasses; set => schoolClasses = value; }
    }
}
