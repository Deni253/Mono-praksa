// See https://aka.ms/new-console-template for more information
using ConsoleApp1;


Dog cupcake = new Bulldog("Cupcake","white",6,false,new DateTime(2018,3,2));
Dog fido = new Bulldog("Fido", "Liver-brown", 3,false, new DateTime(2021, 12, 17));
Dog rex = new GermanSheperd("Rex", "black & brown", 2, false, new DateTime(2020, 2, 15));
Dog gustavo = new Chihuahua("Gustavo", "white", 1, false, new DateTime(2023, 6, 6));

Shelter shelter = new Shelter();

shelter.dogs.Add(cupcake);
shelter.dogs.Add(fido);
shelter.dogs.Add(rex);
shelter.dogs.Add(gustavo);

Console.WriteLine(shelter.ProvideDogInfo());

Console.WriteLine(rex.Bite());

shelter.Train(rex);

Console.WriteLine(rex.Bite());

Console.WriteLine(shelter.ProvideDogInfo());

shelter.Adoption(2);
Console.WriteLine("\n");
Console.WriteLine(shelter.ProvideDogInfo());
