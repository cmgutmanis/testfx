﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TestFx
{
    public static class EnhancedRandom
    {
        public static Random rnd = new Random();

        public static bool RandomBool()
        {
            return rnd.Next(0, 2) == 1;            
        }

        public static string RandomWords(int count)
        {
            var sb = new StringBuilder();
            for (var i = 0; i <= count; i++)
            {
                sb.Append(Words[rnd.Next(0, Words.Length)] + " ");
            }
            return sb.ToString();
        }

        public static string RandomFullName()
        {
            var name = FirstNames[rnd.Next(0, FirstNames.Length)] + " " + LastNames[rnd.Next(0, LastNames.Length)];
            return name;
        }

        public static string RandomFirstName()
        {
            return FirstNames[rnd.Next(0, FirstNames.Length)];
        }

        public static string RandomLastName()
        {
            return LastNames[rnd.Next(0, LastNames.Length)];
        }

        public static string RandomPhoneNumber()
        {
            return string.Format("({0}) {1}-{2}{3}{4}{5}", rnd.Next(201, 1000), rnd.Next(200, 1000), rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));            
        }

        public static DateTime RandomDate()
        {
            var date = new DateTime();
            date = date.AddYears(rnd.Next(1900, DateTime.Today.Year));
            date = date.AddMonths(rnd.Next(0, 12));

            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    date = date.AddDays(rnd.Next(0, 31));
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    date = date.AddDays(rnd.Next(0, 30));
                    break;
                case 2:
                    date = date.AddDays(rnd.Next(0, 28)); // I don't care enough to do leap years.
                    break;
                default:
                    throw new Exception();
                    break;
            }

            return date;
        }

        #region static constants



        private static string[] Words =
        {
            "abacus", "beach", "corpulent", "dromedary", "eclipse", "flames", "giraffe", "hat", "ink", "jumping",
            "kitsch", "lampshade", "monument", "ne'er-do-well", "octopus", "pineapple",
            "quorum", "resurrection", "satisfied", "turbulence", "unify", "viable", "walk", "x-ray", "yams", "zydeco",
            "attenuation", "biscuits", "crochet", "deleterious", "euphonium", "fragile", "gubernatorial", "hijack",
            "importance", "judicious", "kibbutz", "languish", "monotone", "nope", "orienteering", "quail", "risotto",
            "squeegee", "trampoline", "utilitarianism", "visceral", "wallbanger", "xenophobia", "yolo", "zoroastrianism"
        };

        private static string[] FirstNames =
        {
            "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas",
            "Christopher", "Daniel", "Matthew", "Donald", "Anthony", "Paul", "Mark", "George", "Steven", "Kenneth",
            "Andrew", "Edward", "Joshua", "Brian", "Kevin", "Ronald", "Timothy", "Jason", "Jeffrey", "Gary",
            "Ryan", "Nicholas", "Eric", "Jacob", "Stephen", "Jonathan", "Larry", "Frank", "Scott", "Justin",
            "Brandon", "Raymond", "Gregory", "Samuel", "Benjamin", "Patrick", "Jack", "Dennis", "Jerry", "Alexander",

            "Mary", "Patricia", "Jennifer", "Elizabeth", "Linda", "Barbara", "Susan", "Margaret", "Jessica", "Dorothy",
            "Sarah", "Karen", "Nancy", "Betty", "Lisa", "Sandra", "Helen", "Ashley", "Donna", "Kimberly",
            "Carol", "Michelle", "Emily", "Amanda", "Melissa", "Deborah", "Laura", "Stephanie", "Rebecca", "Sharon",
            "Cynthia", "Kathleen", "Ruth", "Anna", "Shirley", "Amy", "Angela", "Virginia", "Brenda", "Pamela",
            "Catherine", "Katherine", "Nicole", "Christine", "Janet", "Debra", "Samantha", "Carolyn", "Rachel",
            "Heather"
        };

        private static string[] LastNames =
        {
            "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Rodriguez", "Wilson",
            "Martinez", "Anderson", "Taylor", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "White", 
            "Lopez", "Lee", "Gonzalez", "Harris", "Clark", "Lewis", "Robinson", "Walker", "Perez", "Hall",
            "Young", "Allen", "Sanchez", "Wright", "King", "Scott", "Green", "Baker", "Adams", "Nelson",
            "Hill", "Ramirez", "Campbell", "Mitchell", "Roberts", "Carter", "Phillips", "Evans", "Turner", "Torres"                                                                   
        };

        #endregion

    }

}





