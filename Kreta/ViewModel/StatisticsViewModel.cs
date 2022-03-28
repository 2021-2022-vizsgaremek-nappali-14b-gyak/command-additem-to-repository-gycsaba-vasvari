using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Services;
using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    public class StatisticsViewModel
    {
        private Statistics statistics;

        public StatisticsViewModel()
        {
            this.statistics = new Statistics();            
        }
        public string NumberOfStudent
        {
            get
            {
                string result = statistics.GetNumberOfStudents() + " fő.";
                return result;
            }
        }
        public ObservableCollection<string> NumberOfStudentPerClass
        {
            get
            {
                ObservableCollection<string>  numberOfStudentPerClass 
                    = new ObservableCollection<string>(DictionaryToList());
                return numberOfStudentPerClass;
            }
        }

        private List<string> DictionaryToList()
        {
            Dictionary<string, int> dictionary = statistics.GetStudentPerClasses();
            List<string> numberOfStudentPerClass = new List<string>();
            foreach(KeyValuePair<string,int> item in dictionary )
            {
                string result = item.Key + " osztály létszáma: " + item.Value + " fő.";
                numberOfStudentPerClass.Add(result);
            }
            return numberOfStudentPerClass;
        }
            


    }
}
