using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
namespace Xml_reader
{
    static class Program
    {
        static public List<string> Names = new List<string> { "Владимир", "Артем", "Сергей", "Визель", "Никита", "Саша", "Александра", "Юля" };
        static public List<Prisoner> Prisoners = new List<Prisoner>();
        static public List<Policeman> Policemen = new List<Policeman>();
        static public List<Prisonroom> Prisonrooms = new List<Prisonroom>();
        static public int Id = 0;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
           


            
            string path = Environment.CurrentDirectory.Replace(@"bin\Debug","");
            
            XmlSerializer serialPolice = new XmlSerializer(typeof(List<Policeman>));
            XmlSerializer serialPrisoner = new XmlSerializer(typeof(List<Prisoner>));
            XmlSerializer serialPrisonroom = new XmlSerializer(typeof(List<Prisonroom>));

            if (!File.Exists(path + @"Policemen.xml") || !File.Exists(path + @"Prisoners.xml") || !File.Exists(path + @"Prisonrooms.xml"))
            {
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    Policemen.Add(new Policeman() { Id = ++Id, age = rnd.Next(18, 66), Name = Names[rnd.Next(0, Names.Count())], Salary = rnd.Next(12600, 234999) });
                }

                for (int i = 1; i < 8; i++)
                {
                    Prisonrooms.Add(new Prisonroom() { Id = i - 1, Max_of_residents = rnd.Next(3, 8), Number_of_residents = 0 });

                    while (Prisonrooms.Last().Number_of_residents < Prisonrooms.Last().Max_of_residents - rnd.Next(1, 5))
                    {
                        Prisoners.Add(new Prisoner() { Id = ++Id, age = rnd.Next(16, 88), Name = Names[rnd.Next(0, Names.Count())], Term = rnd.Next(1, 234), Id_of_his_prisonroom = Prisonrooms.Last().Id });
                        Prisonrooms.Last().Number_of_residents++;
                    }

                }


                using (FileStream text = new FileStream(path + @"Policemen.xml", mode: FileMode.Create))
                {
                    serialPolice.Serialize(text, Policemen);
                }
                using (FileStream text = new FileStream(path + @"Prisoners.xml", mode: FileMode.Create))
                {
                    serialPrisoner.Serialize(text, Prisoners);
                }
                using (FileStream text = new FileStream(path + @"Prisonrooms.xml", mode: FileMode.Create))
                {
                    serialPrisonroom.Serialize(text, Prisonrooms);
                }
            }


            using (FileStream text=new FileStream(path + @"Policemen.xml",FileMode.Open, FileAccess.Read))
            {
                Policemen = serialPolice.Deserialize(text) as List<Policeman>;
            }
            using (FileStream text = new FileStream(path + @"Prisoners.xml", FileMode.Open, FileAccess.Read))
            {
                Prisoners = serialPrisoner.Deserialize(text) as List<Prisoner>;
            }
            using (FileStream text = new FileStream(path + @"Prisonrooms.xml", FileMode.Open, FileAccess.Read))
            {
                Prisonrooms = serialPrisonroom.Deserialize(text) as List<Prisonroom>;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new xml_reader());
        }
    }
}
