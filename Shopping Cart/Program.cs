using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Program
    {
        public abstract class Fruit
        {
            public double price { get; set; }

            public Fruit (double price)
            {
                this.price = price;
            }
        }

        public class Orange :Fruit
        {
           public Orange (double price) : base(price)
            {
                this.price = price;
            }
        }

        public class Apple:Fruit
        {
            public Apple(double price) : base(price)
            {
                this.price = price;
            }
        }

        public class ShoppingCart
        {
            public List<Fruit> shoppingcart { get; set; }
            
            public ShoppingCart(List<Fruit> list)
            {
                this.shoppingcart = list;
            }
            public double total()
            {
                double total = 0;
                for(int i=0;i<this.shoppingcart.Count;i++)
                {
                    total = shoppingcart[i].price + total;
                }
                return total;
            }
        }

        static void Main(string[] args)
        { 

            Apple apple = new Apple(0.6);
            Orange orange = new Orange(0.25);
            
            List<Fruit> liste = new List<Fruit>();
            liste.Add(apple);
            liste.Add(orange);
            liste.Add(orange);
            liste.Add(orange);
            ShoppingCart sc = new ShoppingCart(liste);
            Console.WriteLine(sc.total());
            Console.ReadKey();
        }
    }
}
