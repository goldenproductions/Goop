using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Properties, de typer data der 'beskriver' klassen. F.eks, alder, køn, osv.
// Metode, Foretager forandringer, gør noget med inputs. Kan enten være forudbestemte eller laves selv.
// Constructors, 



namespace Tennis
{
    public enum Gender { Male, Female } //Enum betyder at vi bestemmer på forhånd hvilke 'enumerators' man kan udfylde. AF ukendte årsager skal den stå udenfor klassen.

    class Player
    {
        public string FirstName { get; set; } // Dette er properties. Get, set betyder at man både kan 'hente' properties fra f.eks databasen, og udskrive dem
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public Gender Gender { get; set; }



        public Player(string firstname, string lastname, string dateofbirth, string nationality, Gender gender) //Dette er en constructor. Efterfulgt at parameters.
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = DateTime.ParseExact(dateofbirth, "dd-MM-yyyy", null);
            Nationality = nationality;
            Gender = gender;
        }

        public override string ToString()
        {
            string age = Convert.ToString(Age(this.DateOfBirth));
            string Fullname = String.Format(" First Name: {0}\n Last Name: {1}\n", FirstName, LastName);
            return String.Format("{0}\n Date of Birth: {1}\n Age: {2}\n Natinonality: {3}\n Gender: {4}\n", Fullname, DateOfBirth.ToShortDateString(), age, Nationality, Gender);

        }

        public int Age(DateTime DateOfBirth)
        {
            //Hent nuværende Dato
            DateTime now = DateTime.Today;

            //Hent År fra nuværende dato
            int CurrentYear = DateTime.Parse(Convert.ToString(now)).Year;

            //Hent År fra fødsels dato
            int birthYear = DateTime.Parse(Convert.ToString(DateOfBirth)).Year;

            //Udregn år (mangler at tage højde for dato)
            int age = CurrentYear - birthYear;

            //Medregn Dato
            if (now < DateOfBirth.AddYears(age)) age--;

            return age;
        }

    }

}
