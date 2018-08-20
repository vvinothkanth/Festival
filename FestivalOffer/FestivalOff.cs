using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiscountMethods;

namespace FestivalOffer
{
    public class AadiOffer : IFestivalDiscount
    {
        public void FestivalOffer()
        {
            Console.WriteLine("15% OFF for every bill");
        }
        public void OfferDate()
        {
            Console.WriteLine("July 12 to Aug 12");
        }
        public void GreetingMessage()
        {
            Console.WriteLine("Happy Aadi...!!!");
        }
    }

    public class Diwali : IFestivalDiscount
    {
        public void FestivalOffer()
        {
            Console.WriteLine("10% OFF for every bill");
        }
        public void OfferDate()
        {
            Console.WriteLine("Nov 5 to Nov 9");
        }
        public void GreetingMessage()
        {
            Console.WriteLine("Happy Diwali...!!!");
        }

    }

    public class Pongal : IFestivalDiscount
    {
        public void FestivalOffer()
        {
            Console.WriteLine("14% OFF for every bill");
        }
        public void OfferDate()
        {
            Console.WriteLine("Jan 10 to Jan 18");
        }
        public void GreetingMessage()
        {
            Console.WriteLine("Happy Pongal...!!!");
        }

    }

}
