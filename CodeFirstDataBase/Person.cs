using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDataBase
{

    abstract class Person
    {
        string name;
        string email;
        string phoneNum;
        string password;
        int age;
        Sex sex;
    }

    public class BuisnessOwner : Person
    {
        List<Buisness> buisnessList;
    }

    public class Costumer : Person
    {
        List<Category> prefrences;
        List<Coupon> costumerCoupons;
    }


    public class Admin : Person
    {
        public bool addBuisness(Buisness b)
        {
            throw new NotImplementedException();
        }

        public bool removeBuisness(Buisness b)
        {
            throw new NotImplementedException();
        }

        public bool addCoupon(Coupon c)
        {
            throw new NotImplementedException();
        }

        public bool removeCoupon(Coupon c)
        {
            throw new NotImplementedException();
        }
        
    }


    public enum Sex
    {
        Female,
        Male
    }

    public enum Category
    {
        Sports,
        Food,
        Shoping,
        HelpAndBeauty
    }

}



