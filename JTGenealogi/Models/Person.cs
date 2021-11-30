using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace JTGenealogi.Models
{
    public class Person
    {
        [Key]        
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string BirthDate { get; set; } Bara för VG
        //public string DeathDate { get; set; } Bara för VG
        public int Mor { get; set; }
        public int Far { get; set; }
        
    }
}
