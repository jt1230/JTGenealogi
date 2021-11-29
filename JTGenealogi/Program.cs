using System;
using System.Collections.Generic;
using System.Linq;
using JTGenealogi.Model;
using JTGenealogi.Database;
using Microsoft.EntityFrameworkCore;

namespace JTGenealogi 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var db = new FamilyContext())
            {
                db.People.Add(new Model.Person
                {
                    FirstName = "Harry",
                    LastName = "Potter",
                });
                db.SaveChanges();

                foreach (var person in db.People)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName}");
                    
                }
            }
            
        }
    }
}