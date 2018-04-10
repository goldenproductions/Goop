using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis


/*First name (exactly one name)
 Last name (exactly one name)
 Date-of-birth, e.g., 1985-12-25
 Gender, i.e., male or female
 Date when referee license acquired
 Date when license most recently renewed.
 */

{
    class Referee
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public DateTime LicenseAcquired { get; set; }
        public DateTime LicenseRenewed { get; set; }

        public Referee(string firstname, string middlename, string lastname, string dateofbirth, Gender gender, string licenseacuired, string licenserenewed)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = DateTime.ParseExact(dateofbirth, "dd-MM-yyyy", null);
            Gender = gender;
            LicenseAcquired = DateTime.ParseExact(licenseacuired, "dd-MM-yyyy", null);
            LicenseRenewed = DateTime.ParseExact(licenserenewed, "dd-MM-yyyy", null);

        }

        public override string ToString()
        {
            string age = Convert.ToString(Age(this.DateOfBirth));
            string Fullname = String.Format(" First name: {0}\n Middle name: {1}\n Last name: {2}", FirstName, MiddleName, LastName);
            return String.Format("{0}\n Date of Birth: {1}\n Age: {2}\n Gender: {3}\n License Acquired: {4}\n License Renewed: {5}\n", Fullname, DateOfBirth.ToShortDateString(), age, Gender, LicenseAcquired.ToShortDateString(), LicenseRenewed.ToShortDateString());

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
