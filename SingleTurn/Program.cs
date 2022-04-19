using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTurn//class should have single object it will not create multiple object in a class. 
{
    //1.class object make as a globle level static object
    //1.object make as a static
    //we only create one object in single turn classes.if we can crete single object of the class is known as sigle turn class.
    // class performance has been increase
    class Customer
    {
 //object decleared as static, i want no one can call outside of class the object then i will make the private constractor inside the class

        static void Main(string[] args)
        {
            Product p2 = Product.GetObjectInstance();
            Product p3 = Product.GetObjectInstance();
            Product p4 = Product.GetObjectInstance();


        }
    }
    public class Product
    {
        static Product p = new Product();//no one can create multiple object
        private Product()
        {
        }
        public static Product GetObjectInstance()
        {
            return p;
        }

    }
}

//Partial is the keyword, Partial classes allows as to spliet our class to multiple class(Main class).
//