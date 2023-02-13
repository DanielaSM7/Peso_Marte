using System;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Enums;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.Console;

public static class Program{
    public static void Main(string [] args){
        
        float Weight = 0;
        System.Console.WriteLine("--------------------Calculadora de peso en Marte--------------------");
        System.Console.WriteLine("Ingresa tu peso en Kg");
        Single.TryParse(System.Console.ReadLine(), out Weight);

        var person = new Person {Weight = Weight};
        var service = new GravityService();
        var manager = new GravityManagers(service);

        Gravity gravity = manager.getGravity(person);

        System.Console.WriteLine($"Tu masa es de: {gravity.Index} Kg en {gravity.GravityType} ");

   }
    }
