using System.Collections.Generic;
using System;

namespace CarDealership.Models
{
    public class Car
    {
      private string Name;
      private int Mileage;
      private int Price;
      private string Color;
      private static List<Car> _instances = new List<Car> {};

      public Car(string carName, int carMileage, int carPrice, string carColor)
      {
        Name = carName;
        Mileage = carMileage;
        Price = carPrice;
        Color = carColor;
      }

      public void SetName(string newName)
      {
        Name = newName;
      }
      public string GetName()
      {
        return Name;
      }
      public void SetMileage(int newMileage)
      {
        Mileage = newMileage;
      }
      public int GetMileage()
      {
        return Mileage;
      }
      public void SetPrice(int newPrice)
      {
        Price = newPrice;
      }
      public int GetPrice()
      {
        return Price;
      }
      public void SetColor(string newColor)
      {
        Color = newColor;
      }
      public string GetColor()
      {
        return Color;
      }

      // public void SetMileage(int newMileage)
      // {
      //   if (newMileage >= 0){
      //     Mileage = newMileage;
      //   }
      //   else {
      //     Console.WriteLine("The mileage for this car is not valid");
      //   }
      // }
      // public int GetMileage()
      // {
      //   return Mileage;
      // }
      //
      // public void SetPrice(int newPrice)
      // {
      //   if (newPrice >= 0 ) {
      //     Price = newPrice;
      //   }
      //   else {
      //     Console.WriteLine("The price for this car is not valid");
      //   }
      // }
      // public int GetPrice()
      // {
      //   return Price;
      // }
      // public void SetColor(string newColor)
      // {
      //   Color = newColor;
      // }
      // public string GetColor()
      // {
      //   return Color;
      // }

      public static List<Car> GetAll()
      {
          return _instances;
      }
      public void Save()
      {
          _instances.Add(this);
      }
      public static void ClearAll()
      {
        _instances.Clear();
      }
    }
}
    // public class dealership
    // {
    //   public static void Main()
    //   {
    //
    //     Car avalon = new Car("Toyota Avalon",50000,4000);
    //     Car tacoma = new Car("Toyota Tacoma",180000,10000);
    //     Car camry = new Car("Toyota Camry",90000,8000);
    //
    //     List<Car> inTheLot = new List<Car>() { avalon, tacoma, camry };
    //     Console.WriteLine("Enter maximum price: ");
    //     string maxPriceString = Console.ReadLine();
    //     int maxPrice = int.Parse(maxPriceString);
    //
    //     Console.WriteLine("Enter maximum mileage: ");
    //     string maxMileageString = Console.ReadLine();
    //     int maxMileage = int.Parse(maxMileageString);
    //
    //     List<Car> CarsMatchingSearch = new List<Car>();
    //     foreach(Car model in inTheLot)
    //     {
    //       if (model.GetPrice() < maxPrice && model.GetMileage() < maxMileage)
    //       {
    //         CarsMatchingSearch.Add(model);
    //       }
    //     }
    //     foreach(Car model in CarsMatchingSearch)
    //     {
    //       Console.WriteLine(model.GetName());
    //     }
    //   }
    // }
