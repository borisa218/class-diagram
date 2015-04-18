using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstDataBase
{
    class Coupon
    {
        string name;
        Category couponCategory;
        int originalPrice;
        int discountPrice;
        string description;
        int couponCode;
        List<Costumer> buyingCostumers;
        Buisness buisness;
    }
}
