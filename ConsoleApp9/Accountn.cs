using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Accountn
    {
        public Accountn()
        {
            Console.WriteLine("Account Constructor");
        }
        public virtual void AccountName()
        {
            Console.WriteLine("LIKITH");
        }
    }
    class Customer : Accountn
    {
        public override void AccountName()
        {
            Console.WriteLine("LUCIFER");
        }
    }
}

