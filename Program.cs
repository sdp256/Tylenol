using System;

namespace Tylenol
{
    class Program
    {
        static void Main(string[] args)
        {
            string tylenol = "Tylenol Bottle";
            Console.WriteLine($"On my desk there is a {tylenol}");

            int caplets = 24;
            int miligrams = 500;

            Console.WriteLine($"The bottle contains {caplets} pills. Each pill is {miligrams}mg.");

            Console.WriteLine($"How many pills have you taken from the {tylenol}?");
            int pillNumber = int.Parse(Console.ReadLine());
            int dose = pillNumber * miligrams;

            Console.WriteLine($"You have taken {dose}mg of tylenol.");

            if (dose >= 5000)
            {
                Console.WriteLine("That's too much tylenol bro");
            }
            else
            {
                Console.WriteLine("I hope you are feeling better.");
            }
           
        }
    }
}
