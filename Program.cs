using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_2015_ExperIT_LandCost
{
    class Program
    {
        static void Main(string[] args)
        {

            int width;
            int length;
            int area;
            double subTotal;
            double grandTotal;

            Console.WriteLine("Enter the Width of your PARCEL in Yards");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Lenth of your PARCEL in Yards");
            length = int.Parse(Console.ReadLine());
            
            area = width*length;


            Console.WriteLine("The total square yards "+area);

            subTotal = ((width * 2 + length * 2) * 3) * .75;


            Console.WriteLine("The total parameter in feet "+(width * 2 + length * 2) * 3);

            Console.WriteLine("The parameter tax is " + subTotal.ToString("C2"));


            grandTotal = area * 5.0 + subTotal;

           

          

            Console.WriteLine("The Total Cost  of the land equals " + grandTotal.ToString("C2"));


            Console.ReadLine();

        }
    }
}
