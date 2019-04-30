using System;
using System.Collections.Generic;

namespace CarDealership.Models
{

  public class Car
  {
    private string _MakeModel;
    private int _Price;
    private int _Miles;
    private string _Message;
    private static List<Car> _instances = new List<Car> {};

    public Car(string makeModel, int price, int miles, string message)
    {
      _MakeModel = makeModel;
      _Price = price;
      _Miles = miles;
      _Message = message;
      _instances.Add(this);
    }

    public string GetMakeModel()
    {
      return _MakeModel;
    }

    public void SetMakeModel(string newMakeMdoel)
    {
      _MakeModel = newMakeMdoel;
    }

    public int GetPrice()
    {
      return _Price;
    }

    public void SetPrice(int newPrice)
    {
      _Price = newPrice;
    }

    public int GetMiles()
    {
      return _Miles;
    }

    public void SetMiles(int newMiles)
    {
      _Miles = newMiles;
    }

    public string GetMessage()
    {
      return _Message;
    }

    public void SetMessage(string newMessage)
    {
      _Message = newMessage;
    }

    public bool WorthBuying(int maxPrice, int maxMiles)
    {
      return (_Price < maxPrice && _Miles < maxMiles);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
