using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shelter
    {
        public List<Dog> dogs = new List<Dog>();

        public void Train(Dog dog)
        {
            dog.IsTrained = true;
            Console.WriteLine($" {dog.Name} is in training \n ");
        }

        public string ProvideDogInfo()
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            foreach (Dog dog in dogs)
            {
                sb.Append($" Name: {dog.Name} , color: {dog.FurColor} ,age: {dog.Age} , dog is trained: {dog.IsTrained} , date of birth: {dog.DateOfBirth} \n");
                count++;
            }
            return sb.ToString() + $"Number of current dogs in shelter: {count} ";
        }

        public void Adoption(int number)
        {              
                dogs.RemoveAt(number); // dodati id psima
            }
        }
    }

