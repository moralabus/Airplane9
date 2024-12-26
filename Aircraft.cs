using System;
using System.Collections.Generic;
using System.IO;

public abstract class Aircraft1
{
    public string Name { get; set; }
    public string Model { get; set; }
    public int Range { get; set; }
    public decimal FuelConsumption { get; set; }
    public DateTime ManufactureDate { get; set; }
    public string Foto { get; set; }

    // Абстрактные методы
    public abstract string GetInfo();
    public abstract void WriteToFile(List<Aircraft1> aircrafts, string filePath);
}
