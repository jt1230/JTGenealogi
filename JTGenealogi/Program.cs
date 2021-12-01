using System;
using System.Collections.Generic;
using System.Linq;
using JTGenealogi.Models;
using JTGenealogi.Database;
using Microsoft.EntityFrameworkCore;
using JTGenealogi.Utils;

namespace JTGenealogi 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var db = new FamilyContext())
            {
                //Lägg till person
                //db.People.Add(new Models.Person
                //{
                //    FirstName = "Harry",
                //    LastName = "Potter",
                //});
                //db.SaveChanges();

                //foreach (var person in db.People)
                //{
                //    Console.WriteLine($"{person.FirstName} {person.LastName}");

                //}

                //Skapa en person
                Console.WriteLine("Enter a first name of a person: ");
                var firstName = Console.ReadLine();
                Console.WriteLine("Enter a last name of a person: ");
                var lastName = Console.ReadLine();
                var newPerson = PersonHelper.FindOrCreatePerson(firstName, lastName);

            }
            
        }
    }
}