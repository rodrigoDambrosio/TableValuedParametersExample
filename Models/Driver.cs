using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableValuedParametersExample.Model
{
    public class Driver
    {
        public Driver(string firstName, string lastName, int number, string photoPath, int wins)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            PhotoPath = photoPath;
            Wins = wins;
        }

        public Driver(int id, string firstName, string lastName, int number, string photoPath, int wins)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Number = number;
            PhotoPath = photoPath;
            Wins = wins;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public string PhotoPath { get; set; }
        public int Wins { get; set; }
    }
}
