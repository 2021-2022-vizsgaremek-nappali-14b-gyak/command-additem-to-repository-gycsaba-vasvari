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
    public class SubjectViewModel
    {
        private SubjectRepo subjectRepo;
        private ObservableCollection<Subject> subject;

        public SubjectViewModel()
        {
            subjectRepo = new SubjectRepo();
            subject = new ObservableCollection<Subject>(subjectRepo.Subject);
        }

        public ObservableCollection<Subject> Subject { get => subject; set => subject = value; }
    }
}
