using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 20;
           double result= GetSquare(i);
            Console.WriteLine(result);
            Console.ReadLine();

        }

private static double GetSquare(double aValue)
{
    
 	return aValue*aValue;
}
    }
  
}
