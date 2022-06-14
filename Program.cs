using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[]
          {
                new Human(22,"Naila","Bunyatova"),
                new Human(24,"Pervin","Adnali"),
                new Human(21,"Kamala","Camalova"),
                new Human(23,"Nargiz","Amirova"),
          };

            string search;
            do
            {
                Console.WriteLine("Axtaris deyerini daxil edin:");
                search = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(search));


            search = search.ToLower();

            foreach (var item in humans)
            {
                if (item.FullName.ToLower().Contains(search))
                    Console.WriteLine($"{item.Name} {item.Surname} - {item.Age}");
            }


            Console.WriteLine("mehsulun sayini daxil edin:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

           
          
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}. Mehsulun adini daxil edin:");
                string NameStr = Console.ReadLine();
               

                Console.WriteLine($"{i + 1}. Mehsulun qiymetini daxil edin:");
                string PriceStr = Console.ReadLine();

               
              
            }
  

            
           


           



        }
    }
}
