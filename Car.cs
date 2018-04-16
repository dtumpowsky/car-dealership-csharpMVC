using System;
using System.Collections.Generic;

class Car
{
  private string MakeModel;
  private int Price;
  private int Miles;
  private string Description;

  public void SetMakeModel(string newMakeModel)
  {
    MakeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return MakeModel;
  }

  public void SetPrice(int newPrice)
  {
    Price = newPrice;
  }
  public int GetPrice()
  {
    return Price;
  }

  public void SetMiles(int newMiles)
  {
    Miles = newMiles;
  }
  public int GetMiles()
  {
    return Miles;
  }

  public void SetDescription(string newDescription)
  {
    Description = newDescription;
  }
  public string GetDescription()
  {
    return Description;
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetMakeModel("2014 Porsche 911");
    porsche.SetPrice(114991);
    porsche.SetMiles(7864);
    porsche.SetDescription("It is very cool car!");

    Car ford = new Car();
    ford.SetMakeModel("2011 Ford F450");
    ford.SetPrice(55995);
    ford.SetMiles(14241);
    ford.SetDescription("It is old car!");

    Car lexus = new Car();
    lexus.SetMakeModel("2013 Lexus RX 350");
    lexus.SetPrice(44700);
    lexus.SetMiles(20000);
    lexus.SetDescription("It is nice car!");

    Car mercedes = new Car();
    mercedes.SetMakeModel("Mercedes Benz CLS550");
    mercedes.SetPrice(39900);
    mercedes.SetMiles(37979);
    mercedes.SetDescription("It is German car!");

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
    foreach(Car automobile in Cars)
    {
      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetDescription());
      Console.WriteLine(automobile.GetMiles());
    }

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>();

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    if (CarsMatchingSearch.Count == 0)
    {
      Console.WriteLine("There are no cars cheaper than that.");
    }


    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }

    Console.WriteLine("Enter maximum mileage");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearchForMiles = new List<Car>();

    foreach(Car vehicle in Cars)
    {
      if (vehicle.GetMiles() <= maxMiles)
      {
        CarsMatchingSearchForMiles.Add(vehicle);
      }
    }
    foreach(Car vehicle in CarsMatchingSearchForMiles)
    {
      Console.WriteLine(vehicle.GetMakeModel());
    }



  }
}
