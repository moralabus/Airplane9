using Airplane9;
using System;

public class PassengerAirplane : Airplane
{
    public int PassengerCapacity { get; set; }
    public bool HasBusinessClass { get; set; }

    // Конструктор для инициализации
    public PassengerAirplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto, int passengerCapacity, bool hasBusinessClass)
        : base(name, model, range, fuelConsumption, manufactureDate, foto)
    {
        PassengerCapacity = passengerCapacity;
        HasBusinessClass = hasBusinessClass;
    }

    // Переопределение метода GetInfo для пассажирского самолета
    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Вместимость: {PassengerCapacity} пассажиров, Наличие бизнес-класса: {HasBusinessClass}";
    }
}
