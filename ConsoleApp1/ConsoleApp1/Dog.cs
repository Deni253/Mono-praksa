using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Dog
    {
        string? name;
        string? furColor;
        int age;
        bool isTrained;
        DateTime dateOfBirth;

        public string? Name { get; private set; }
        public string? FurColor { get; private set; }
        public int Age { get; private set; }
        public bool IsTrained { get; set; }
        public DateTime DateOfBirth { get; private set; }


        
        public Dog(string name,string furColor,int age,bool isTrained,DateTime dateOfBirth) 
        {
            this.Name = name;
            this.FurColor = furColor;
            this.Age = age;
            this.IsTrained = isTrained;
            this.DateOfBirth = dateOfBirth;
        }


        public abstract string Bite();

    }
}
