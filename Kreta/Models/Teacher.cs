using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsgaremek.Models
{
    public enum EmploymentValue { LECTURER, INDENTUREDLABOURER, DONEONCOMMISSION }

    public class Teacher
    {
        private int id;
        private string lastName;
        private string firstName;
        private string password;
        private bool meal;
        private EmploymentValue emploeyment;
        private string emploeymentName;

        public Teacher()
        {
            {
                this.Id = 0;
                this.LastName = string.Empty;
                this.FirstName = string.Empty;
                this.Password = string.Empty;
                this.Meal = false;
                this.Emploeyment = EmploymentValue.DONEONCOMMISSION;
            }
        }
        public Teacher(int id, string lastname, string firstname, string password, bool meal, EmploymentValue emploeyment)
        {
            this.id = id;
            this.lastName = lastname;
            this.FirstName = firstname;
            this.Password = password;
            this.Meal = meal;
            this.Emploeyment = emploeyment;
        }

        public Teacher(Teacher teacher)
        {
            this.id = teacher.id;
            this.lastName = teacher.lastName;
            this.FirstName = teacher.firstName;
            this.Password = teacher.password;
            this.Meal = teacher.meal;
            this.Emploeyment = teacher.emploeyment;
        }

        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Password { get => password; set => password = value; }
        public bool Meal { get => meal; set => meal = value; }
        public EmploymentValue Emploeyment { get => emploeyment; set => emploeyment = value; }
        public string EmploeymentName
        {
            get
            {
                switch (emploeyment)
                {
                    case EmploymentValue.LECTURER:
                        return "óraadó";
                    case EmploymentValue.INDENTUREDLABOURER:
                        return "szerződéses alkalmazott";
                    case EmploymentValue.DONEONCOMMISSION:
                        return "állandó megbízásos rendelkező";
                }
                return string.Empty;
            }

            set
            {
                emploeymentName = value;
                if (emploeymentName == "óraadó")
                    emploeyment = EmploymentValue.LECTURER;
                else if (emploeymentName == "szerződéses alkalmazott")
                    emploeyment = EmploymentValue.INDENTUREDLABOURER;
                else
                    emploeyment = EmploymentValue.DONEONCOMMISSION;
            }
        }
    }
}
