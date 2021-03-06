﻿using System.Dynamic;
using Library;

namespace PrettyMuch
{
    class Program
    {
        static void Main( string[] args )
        {
            dynamic person = new ExpandoObject();
            person.FirstName = "Terry";
            person.LastName = "Tate";
            person.Occupation = "Office Linebacker";

            IPrettyPrinter pp = new JsonPrettyPrettyPrinter();
            pp.Print(person, "Person");
        }
    }
}
