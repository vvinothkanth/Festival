using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiscountFactory;
using DiscountMethods;
using FestivalOffer;
namespace SuperSaravanaStore
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IFestivalDiscount i = null;
            FactoryDiscount f = new FactoryDiscount();
            i = f.Create("Pongal");
            i.GreetingMessage();
            i.FestivalOffer();
            i.OfferDate();
            Console.ReadKey();

        }
    }
}
