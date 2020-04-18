/*
Grading ID: W9957
Program#: 4
Due Date: 4/24/2018 11:59.00
Course Section: 199-01

Description:
A program that utilizes classes and methods to validate package information and then presents it. This runs Program.cs.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    class Package_File
    {
        static void Main(string[] args)
        {
            //the hard coded packages we are submitting
            GroundPackage myPackage1 = new GroundPackage(10000, 20000, 10, 10, 10, 10);
            GroundPackage myPackage2 = new GroundPackage(78534, 95001, 25, 25, 2, 80.5);
            GroundPackage myPackage3 = new GroundPackage(21947, 30255, 2, 2, 2, 200);
            GroundPackage myPackage4 = new GroundPackage(11928, 80050, 125, 35, 20, 56);
            GroundPackage myPackage5 = new GroundPackage(75923, 40602, 56.35, 35.56, 5.48, 122.25);

            //a new array of packages so they can be used in the foreach loop below
            GroundPackage[] myPackages = new GroundPackage[5];
            myPackages[0] = myPackage1;
            myPackages[1] = myPackage2;
            myPackages[2] = myPackage3;
            myPackages[3] = myPackage4;
            myPackages[4] = myPackage5;

            //changed data
            DisplayPackages(myPackages);
            Console.WriteLine("Changed Data\n");
            myPackage1.OriginZip = 78912;
            myPackage2.DestinationZip = 11082;
            myPackage3.Width = 30;
            myPackage4.Length = 20;
            myPackage5.Height = 3.5;
            DisplayPackages(myPackages);

            int i = 1;
            while(i < 10)
            {
                i++;
            }

            do
            {
                i++;
            } while (i < 10);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        }

    //a method to house the loop to print each package out
    //pre-consdition: requires all _destinationZip,_length,_width,_height,_weight
    //post-condition: submits a string thats a list of the pre-condition
    public static void DisplayPackages(GroundPackage[] myPackages) 
        {
            foreach (GroundPackage GroundPackage in myPackages)
            {
                Console.WriteLine("Package Information \n");
                Console.WriteLine(GroundPackage);//list details
                Console.WriteLine($"--------------------Total Cost: {GroundPackage.CalcCost():C2}\n");
            }
        }
    }
}
