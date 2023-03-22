using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class PeopleList
    {
        public static readonly List<People> People = new List<People>
        {
            new People()
            {
                Name = "John",
                Age = 15 
            },
            new People()
            {
                Name = "Joe",
                Age = 24
            },
            new People()
            {
                Name = "Ron",
                Age = 12
            },
            new People()
            {
                Name = "Moona",
                Age = 32
            },
            new People()
            {
                Name = "Poona",
                Age = 12
            },
        };
    }
}
