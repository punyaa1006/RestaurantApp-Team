using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/2");
        }
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public Restaurant(int id, string name, string type, double rate)
        {
            Id = id;
            Name = name;
            Type = type;
            Rate = rate;
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<Restaurant> restaurants = new List<Restaurant>
                {
                    new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                    new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                    new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
                };

                Console.WriteLine("ปุณยาพร เพ็ชรลา");
                Console.WriteLine("ปิยะวัฒน์ โกสุม");
                Console.WriteLine("กุลธารินท์ คงเรือง");

                Console.WriteLine("LUNAR");

                Console.WriteLine("โอเปิ้ล");
                Console.WriteLine("แฮปปี้");
                Console.WriteLine("บอส");
            }
        }

        // เมธอดแสดงรายชื่อร้านอาหาร
        static void ShowRestaurantList()
        {
            List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
        };

            Console.WriteLine("=== รายชื่อร้านอาหาร ===");

            foreach (Restaurant r in restaurants)
            {
                Console.WriteLine(r.Id + ". " + r.Name);
            }
        }

        // เมธอด A
        static void FeatureA()
        {
        }
        // เมธอด B
        static void FeatureB()
        {
        }
        // เมธอด C
        static void FeatureC()
        {
        }
        // Main
        static void Main(string[] args)
        {
            ShowRestaurantList();
            FeatureA();
            FeatureB();
            FeatureC();
        }
    }
}
สวัสดี