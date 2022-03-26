using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace Json_reader
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
            string path = Environment.CurrentDirectory.Replace(@"bin\Debug", "");

            if (!File.Exists(path + @"Policemen.txt") || !File.Exists(path + @"Prisoners.txt") || !File.Exists(path + @"Prisonrooms.txt"))
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
                File.WriteAllText(path + @"Policemen.txt", JsonConvert.SerializeObject(Policemen));
                File.WriteAllText(path + @"Prisoners.txt", JsonConvert.SerializeObject(Prisoners));
                File.WriteAllText(path + @"Prisonrooms.txt", JsonConvert.SerializeObject(Prisonrooms));


            }
            Policemen = JsonConvert.DeserializeObject<List<Policeman>>(File.ReadAllText(path + @"Policemen.txt"));
            Prisoners= JsonConvert.DeserializeObject<List<Prisoner>>(File.ReadAllText(path + @"Prisoners.txt"));
            Prisonrooms = JsonConvert.DeserializeObject<List<Prisonroom>>(File.ReadAllText(path + @"Prisonrooms.txt"));














            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new JsonPoliceStation());
        }
    }
}
