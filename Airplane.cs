using System;
using System.Collections.Generic;
using System.IO;

public abstract class Aircraft
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Range { get; set; }
    public decimal FuelConsumption { get; set; }
    public DateTime ManufactureDate { get; set; }
    public string Foto { get; set; }

    // Абстрактные методы
    public abstract string GetInfo();
    public abstract void WriteToFile(List<Aircraft> aircrafts, string filePath);
}

public class Airplane : Aircraft
{
    // Статическое событие
    public static event EventHandler AirplaneAdded;

    public Airplane(string name, string model, int range, decimal fuelConsumption, DateTime manufactureDate, string foto)
    {
        Name = name;
        Model = model;
        Range = range;
        FuelConsumption = fuelConsumption;
        ManufactureDate = manufactureDate;
        Foto = foto;
    }

    public override string GetInfo()
    {
        return $"{Name}, {Model}, {Range} км, {FuelConsumption} л/100 км, Дата производства: {ManufactureDate.ToShortDateString()}";
    }

    // Исправленная версия метода WriteToFile
    public override void WriteToFile(List<Aircraft> aircrafts, string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var aircraft in aircrafts)
            {
                var airplane = aircraft as Airplane;
                if (airplane != null)
                {
                    writer.WriteLine($"{airplane.Name},{airplane.Model},{airplane.Range},{airplane.FuelConsumption},{airplane.ManufactureDate},{airplane.Foto}");
                }
            }
        }
    }

    public static List<Airplane> ReadFromFile(string filePath)
    {
        var airplanes = new List<Airplane>();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');

                if (parts.Length == 6)
                {
                    string name = parts[0];
                    string model = parts[1];
                    int range = int.Parse(parts[2]);
                    decimal fuelConsumption = decimal.Parse(parts[3]);
                    DateTime manufactureDate = DateTime.Parse(parts[4]);
                    string foto = parts[5];

                    Airplane airplane = new Airplane(name, model, range, fuelConsumption, manufactureDate, foto);
                    airplanes.Add(airplane);

                    // Генерация события
                    AirplaneAdded?.Invoke(airplane, EventArgs.Empty);
                }
            }
        }
        return airplanes;
    }
}

