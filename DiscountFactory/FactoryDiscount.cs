using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DiscountMethods;
using FestivalOffer;

namespace DiscountFactory
{
    public class FactoryDiscount
    {
        Dictionary<string, IFestivalDiscount> discount = new Dictionary<string, IFestivalDiscount>();
        public FactoryDiscount()
        {
          discount["Aadi"] = new AadiOffer();
          discount["Diwali"] = new Diwali();
          discount["Pongal"] = new Pongal();
        }

        public IFestivalDiscount Create(string festEvent)
        {
            return discount[festEvent];
        }
    }
}
