using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JTGenealogi.Database;
using JTGenealogi.Models;

namespace JTGenealogi.Utils
{
    public class PersonHelper
    {
        public static Person FindOrCreatePerson(string fname, string lname)
        {
            using (var db = new FamilyContext()) // Metoden kmr att söka efter personens för- eller
                                                 // efternamn, personen skapas om den inte finns
            {
                var person = db.People.
                            FirstOrDefault(
                                h => h.FirstName == fname && // Sök på namnet
                                h.LastName == lname 
                                );
                if (person == null) // om personen inte finns, skapa den
                {
                    person = new Person { FirstName = fname, LastName = lname };
                    db.People.Add(person);
                    db.SaveChanges(); // objektet uppdateras med ID efter save
                }
                return person;
            }
        }
    }
}
