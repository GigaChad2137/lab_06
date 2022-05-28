using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_06
{
    class Program
    {
        static void Main(string[] args)
        {
         

            List<User> users = new List<User>
            {
            // Tablica 20 użytkowników
            new User { Name = "Antoni", Role = "STUDENT", Age = 20, Marks = new int[] { 3, 3, 4, 5, 3 }, CreatedAt = new DateTime(2021, 10, 1), RemovedAt = null },
            new User { Name = "Jan", Role = "STUDENT", Age = 20, Marks = new int[] { 5, 3,4 }, CreatedAt = new DateTime(2020, 10, 1), RemovedAt = null },
            new User { Name = "Aleksander", Role = "MODERATOR", Age = 19, Marks = null, CreatedAt = new DateTime(2015, 9, 26), RemovedAt = null },
            new User { Name = "Franciszek", Role = "MODERATOR", Age = 22, Marks = null, CreatedAt = new DateTime(2015, 9, 26), RemovedAt = null },
            new User { Name = "Jakub", Role = "TEACHER", Age = 58, Marks = null, CreatedAt = new DateTime(1997, 10, 1), RemovedAt = null },
            new User { Name = "Szymon", Role = "STUDENT", Age = 20, Marks = new int[] {2,2,2,2,2 }, CreatedAt = new DateTime(2021, 10, 1), RemovedAt = null },
            new User { Name = "Mikołaj", Role = "TEACHER", Age = 44, Marks = null, CreatedAt = new DateTime(1995, 10, 1), RemovedAt = null },
            new User { Name = "Leon", Role = "STUDENT", Age = 20, Marks = new int[] {5,5,4,3,4,6,4,3}, CreatedAt = new DateTime(2017, 10, 1), RemovedAt = new DateTime(2022, 01, 13) },
            new User { Name = "Filip", Role = "STUDENT", Age = 22, Marks = new int[] { 3,1,3,2,5 }, CreatedAt = new DateTime(2017, 10, 1), RemovedAt = new DateTime(2022, 01, 13) },
            new User { Name = "Stanisław", Role = "STUDENT", Age = 24, Marks = new int[] {3,3,3,3,3,4 }, CreatedAt = new DateTime(2020, 10, 1), RemovedAt =new DateTime(2021, 10, 1) },
            new User { Name = "Zuzanna", Role = "TEACHER", Age = 37, Marks = null, CreatedAt = new DateTime(2007, 5, 27), RemovedAt = null },
            new User { Name = "Zofia", Role = "ADMIN", Age = 43, Marks = null, CreatedAt = new DateTime(2011, 5, 18), RemovedAt =  new DateTime(2018, 8, 23)},
            new User { Name = "Hanna", Role = "STUDENT", Age = 21, Marks = new int[] {3,2,5,3 }, CreatedAt = new DateTime(2021, 10, 1), RemovedAt = null },

            new User { Name = "Julia", Role = "STUDENT", Age = 29, Marks = new int[] { 4,1,3 }, CreatedAt = new DateTime(2021, 10, 1), RemovedAt = null },
            new User { Name = "Maja", Role = "STUDENT", Age = 20, Marks = new int[] { 3,2,5,4,3 }, CreatedAt = new DateTime(2021, 10, 24), RemovedAt = null },
            new User { Name = "Laura", Role = "STUDENT", Age = 19, Marks = new int[] { 2,3,3,3,3,3 }, CreatedAt = new DateTime(2021, 10, 1), RemovedAt = null },
           
            new User { Name = "Oliwia", Role = "ADMIN", Age = 32, Marks = null, CreatedAt = new DateTime(2011, 9, 25), RemovedAt = null },
           
            new User { Name = "Alicja", Role = "STUDENT", Age = 19, Marks = new int[] { 2,2,2,2,2 }, CreatedAt = new DateTime(2020, 10, 1), RemovedAt = null },
            new User { Name = "Lena", Role = "STUDENT", Age = 22, Marks = new int[] { 3,5,4,3 }, CreatedAt = new DateTime(2019, 10, 1), RemovedAt = null },
          
            new User { Name = "Pola", Role = "STUDENT", Age = 24, Marks = new int[] {5,3,2,3,3 }, CreatedAt = new DateTime(2018, 10, 1), RemovedAt = null },
   

            };
            //zad1
            Console.WriteLine("zad1");
            Console.WriteLine(users.Count());

            //Listę nazw użytkowników
            Console.WriteLine("zad2");
            List<string> imona = users.Select(user => user.Name).ToList();
            foreach(var name in imona)
            {
                Console.Write(name+" ");
            }
            Console.WriteLine();
            Console.WriteLine("zad3");
            //Posortowanych użytkowników po nazwach
            List<User> imona_posortowane = users.OrderBy(user => user.Name).ToList();
            foreach (User user in imona_posortowane)
            {
                Console.Write(user.Name + " ");
            }
            Console.WriteLine();
            //Listę dostępnych ról użytkowników
            Console.WriteLine("zad4");
            var lista_rol = users.GroupBy(user => user.Role).Select(role => role.First()).ToList();
            foreach (User rola in lista_rol)
            {
                Console.Write(rola.Role + " ");
            }
            //Listy pogrupowanych użytkowników po rolach
            Console.WriteLine("");
            Console.WriteLine("zad5");
            var imiony_by_roles = (from user in users group user by user.Role).ToList();
            foreach (var rola in imiony_by_roles)
            {
                foreach (var lista_uzytkownikow in rola)
                {
                    Console.Write(lista_uzytkownikow.Name + " ");
                }
            }
            //Ilość rekordów, dla których podano oceny (nie null i więcej niż 0)
            var records_marks_not_null = (from user in users where user.Marks != null && user.Marks.Length > 0 select user).Count();
            Console.WriteLine("");
            Console.WriteLine("zad6");
            Console.WriteLine(records_marks_not_null);
            //Sumę, ilość i średnią wszystkich ocen studentów
            Console.WriteLine("");
            Console.WriteLine("zad7");
            var sum_ocen = (from user in users where user.Marks != null && user.Marks.Length > 0 select user.Marks.Sum()).Sum();
            var średnią_cen = (from user in users where user.Marks != null && user.Marks.Length > 0 select user.Marks.Average()).Average();
            var ilość = (from user in users where user.Marks != null && user.Marks.Length > 0 select user.Marks.Count()).Sum();
            Console.WriteLine($"Suma {sum_ocen}  Srednia: {Math.Round(średnią_cen,2)} ilosc: {ilość}");
            //Najlepszą ocenę
            Console.WriteLine("");
            Console.WriteLine("zad8");
            var najlepsza_ocena = (from user in users where user.Marks != null && user.Marks.Length > 0 select user.Marks.Max()).Max();
            Console.WriteLine($"Najlepsza ocena {najlepsza_ocena}");
            Console.WriteLine("");
            Console.WriteLine("zad9");
            var min_ocena = (from user in users where user.Marks != null && user.Marks.Length > 0 select user.Marks.Min()).Min();
            Console.WriteLine($"Najgorsza ocena {min_ocena}");

            //Najlepszego studenta
            Console.WriteLine("");
            Console.WriteLine("zad10");
            var najlepszy_student = (from user in users where user.Marks != null && user.Marks.Length > 0 orderby user.Marks.Average() descending select user.Name + " "+user.Marks.Average()).First();
            Console.WriteLine($"Najlepszy student  {najlepszy_student}");
            //Listę studentów, którzy posiadają najmniej ocen
            Console.WriteLine("");
            Console.WriteLine("zad11");
            var najmniej_ocen = (from user in users  where user.Marks != null  orderby user.Marks.Length ascending select user);
            int najmniejsza = int.MaxValue;
            foreach (var user in najmniej_ocen)
            {
                if (user.Marks.Length <= najmniejsza)
                {
                    Console.Write(user.Name + " " + user.Marks.Length);
                    najmniejsza = user.Marks.Length;
                    Console.WriteLine();
                }
                else { break; }
            }
            //Listę studentów, którzy posiadają najwięcej ocen
            Console.WriteLine("");
            Console.WriteLine("zad12");
            int najwieksza = int.MinValue;
            var najwiecej_ocen = (from user in users where user.Marks != null orderby user.Marks.Length descending select user);
                foreach (var user in najwiecej_ocen)
                {
                    if (user.Marks.Length >= najwieksza)
                    {
                        Console.WriteLine(user.Name + " " + user.Marks.Length);
                        najwieksza = user.Marks.Length;
                    }
                    else break;

                }
            //Listę obiektów zawierających tylko nazwę i średnią ocenę (mapowanie na inny obiekt)
            Console.WriteLine("");
            Console.WriteLine("zad13");
            var zad_13 = from user in users where user.Marks != null select user.Name + " " + Math.Round(user.Marks.Average(), 2);
            foreach (var uczen in zad_13)
            {
                Console.WriteLine(uczen);
            }
            //Studentów posortowanych od najlepszego
            Console.WriteLine("");
            Console.WriteLine("zad14");
            var zad_14 = from user in users where user.Marks != null orderby user.Marks.Average() descending select user.Name + " " + Math.Round(user.Marks.Average(),2);
            foreach (var uczen in zad_14)
            {
                Console.WriteLine(uczen);
            }
            //Średnią ocenę wszystkich studentów
            Console.WriteLine("");
            Console.WriteLine("zad15");
            var zad_15 = (from user in users where user.Marks != null  select user.Marks.Average()).Average();

            Console.WriteLine("Średnia ocena wszystkich studentów: " + Math.Round(zad_15, 2));

            //Listę użytkowników pogrupowanych po miesiącach daty utworzenia (np. 2022-02, 2022-03, 2022-04, itp.)
            Console.WriteLine("");
            Console.WriteLine("zad16");

            var zad_16 = (from user in users orderby user.CreatedAt descending group user by user.CreatedAt ).ToList();

            foreach (var user in zad_16)
            {
                foreach (var student in user)
                {
                    Console.WriteLine($"{student.Name} {student.CreatedAt}");
                }
            }

                //Listę użytkowników, którzy nie zostali usunięci (data usunięcia nie została ustawiona)
                Console.WriteLine("");
                Console.WriteLine("zad17");

                var zad_17 = (from user in users where user.RemovedAt == null select user).ToList();
            foreach (var user in zad_17)
            {
               
                    Console.WriteLine($"{user.Name} {user.RemovedAt}");
                
            }
            //Najnowszego studenta (najnowsza data utworzenia)
            Console.WriteLine("");
            Console.WriteLine("zad18");

            var zad_18 = (from user in users orderby user.CreatedAt descending select user.Name + " " + user.CreatedAt);
          
            Console.WriteLine($"{zad_18.First()}");

            
        }













    }



        public class User
        {
            public string Name { get; set; }
            public string Role { get; set; } // ADMIN, MODERATOR, TEACHER, STUDENT
            public int Age { get; set; }
            public int[] Marks { get; set; } // zawsze null gdy ADMIN, MODERATOR lub TEACHER
            public DateTime? CreatedAt { get; set; }
            public DateTime? RemovedAt { get; set; }
        }

 
 }
    
