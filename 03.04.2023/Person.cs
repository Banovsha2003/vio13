using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace _03._04._2023
{
    class Person
    {       public string name;
            public int age;
            public string location;


            public override string ToString()
        {
            return $"Person Name: {name}\n" +
                $"Age: {age}\n" +
                $"Location: {location} ";

        }
    }
}
