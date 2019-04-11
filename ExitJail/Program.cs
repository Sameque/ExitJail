using System;
using ExitJail.Entities.Jail;
using ExitJail.Controller;

namespace ExitJail
{
    class Program
    {
        static void Main(string[] args)
        {

            Jail jail = new Jail();

            ServiceJail.MountJail(ref jail);
            
            Console.WriteLine(jail);

            //Console.WriteLine(killer.ToString());
        }

    }
}
