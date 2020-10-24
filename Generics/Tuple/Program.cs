using System;
using System.Collections.Generic;

namespace Tuple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var personInfo = Console.ReadLine().Split();
            var fullName = personInfo[0] + " " + personInfo[1];
            var adress = personInfo[2];
            var town = ReturnTownName(personInfo);
            var personTuple = new MyTupple<string, string, string>(fullName, adress, town);
            Console.WriteLine(personTuple.ToString());

            var drunkPerson = Console.ReadLine().Split();
            var name = drunkPerson[0];
            var litresOfBeer = int.Parse(drunkPerson[1]);
            bool isHeDrunk = isDrunk(drunkPerson[2]);
            var drunkTuple = new MyTupple<string, int, bool>(name, litresOfBeer, isHeDrunk);
            Console.WriteLine(drunkTuple.ToString());

            var bankInfo = Console.ReadLine().Split();
            var nameOfPerson = bankInfo[0];
            var balance = double.Parse(bankInfo[1]);
            var bankName = bankInfo[2];
            var bankTuple = new MyTupple<string, double, string>(nameOfPerson, balance, bankName);
            Console.WriteLine(bankTuple.ToString());

        }
        static bool isDrunk(string drunkOrNot)
        {
            if (drunkOrNot == "drunk")
            {
                return true;
            }
            return false;
        }
        static string ReturnTownName(string[]personInfo)
        {
            if (personInfo.Length > 4)
            {
                return personInfo[3] + " " + personInfo[4];
            }
            return personInfo[3];
        }
    }
}
