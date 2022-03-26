using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml_reader
{
    public class Prisoner:Person
    {
        public int Id { get; set; }
        public int Term { get; set; }
        public int Id_of_his_prisonroom { get; set; }
    }
}
