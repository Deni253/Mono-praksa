using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GermanSheperd:Dog,IDog
    {
        public GermanSheperd(string name, string furColor, int age, bool isTrained, DateTime dateOfBirth) : base(name, furColor, age, isTrained, dateOfBirth)
        {

           
        }
        public string Bark()
        {
            return "Barks!";
        }

        public string Sit()
        {
            return "Sits!";
        }
        public string ExtendPaw()
        {
            return "ExtendsPaw";
        }
        public string Jump()
        {
            return "Jumps!";
        }
        public override string Bite()
        {
            return IsTrained ? $"{Name} Won't bite. " : $"{Name} Bites! \n";
        }
    }
}
