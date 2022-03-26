using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json_reader
{
    public class Person
    {
        public string Name { get; set; }

        public int age { get; set; }
    }
    public class Policeman : Person
    {
        public int Id { get; set; }
        public int Salary { get; set; }
    }
    public class Prisoner : Person
    {
        public int Id { get; set; }
        public int Term { get; set; }
        public int Id_of_his_prisonroom { get; set; }
    }
    public class Prisonroom
    {
        public int Id { get; set; }
        public int Number_of_residents { get; set; }
        public int Max_of_residents { get; set; }


    }

}
