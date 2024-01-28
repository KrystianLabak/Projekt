using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt;

class DataBaseReader
{
    public List<Pojazd> VehicleDB()
    {
        using (StreamReader bazadanych = new StreamReader("BazaDanych.json"))
        {
            var zawartosc = bazadanych.ReadToEnd();
            var database = JsonConvert.DeserializeObject<DataBase>(zawartosc)!;
            var listaPojazdow = new List<Pojazd>();
            listaPojazdow.AddRange(database.Osobowy);
            listaPojazdow.AddRange(database.Motor);
            return listaPojazdow;
        }
    }
    public void AddVehicle(Pojazd pojazd)
    {
        DataBase database;
        using (StreamReader sr = new StreamReader("BazaDanych.json"))
        {
            var zawartosc = sr.ReadToEnd();
            database = JsonConvert.DeserializeObject<DataBase>(zawartosc)!;
        }
        if (pojazd.GetType() == typeof(Osobowy))
        {
            database.Osobowy.Add(pojazd as Osobowy);
        }
        else if (pojazd.GetType() == typeof (Motor))
        {
            database.Motor.Add(pojazd as Motor);
        }
        var convertstring = JsonConvert.SerializeObject(database, Formatting.Indented);
        using (StreamWriter sw = new StreamWriter("BazaDanych.json"))
        {
            sw.Write(convertstring);
        }

    }
    public void RemoveVehicle(Pojazd pojazd)
    {
        DataBase database;
        using (StreamReader usunpojazd = new StreamReader("BazaDanych.json"))
        {
           var zawartosc = usunpojazd.ReadToEnd();
           database = JsonConvert.DeserializeObject<DataBase>(zawartosc)!;
        }
        if (pojazd.GetType() == typeof(Motor))
        {
            var motor = database.Motor.Find(x => x.DanePojazdu.NumerVin == pojazd.DanePojazdu.NumerVin);
            database.Motor.Remove(motor);
        }
        else if (pojazd.GetType() == typeof(Osobowy))
        {
            var osobowy = database.Osobowy.Find(x => x.DanePojazdu.NumerVin == pojazd.DanePojazdu.NumerVin);
            database.Osobowy.Remove(osobowy);
        }
        var convertstring = JsonConvert.SerializeObject(database, Formatting.Indented);
        using (StreamWriter sw = new StreamWriter("BazaDanych.json"))
        {
            sw.Write(convertstring);
        }
    }
    public void UpdateDataBase(Pojazd pojazdPrzed, Pojazd pojazdPo)
    {
        RemoveVehicle(pojazdPrzed);
        AddVehicle(pojazdPo);
    }
}
class DataBase
{
    public List<Osobowy> Osobowy { get; set; }
    public List<Motor> Motor { get; set; }
}
