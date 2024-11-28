using System;
using MuromskyInspectorLib;

class Program
{
    static void Main()
    {
        FunctionInsp insp = new FunctionInsp(); //вызов класса

        Console.WriteLine("Главный инспектор: " + insp.GetInspector()); //тест метода GetInspector
        Console.WriteLine("Название автоинспекции: " + insp.GetCarInspection()); //тест метода GetCarInspection
        Console.WriteLine("Главный инспектор: " + insp.SetInspector("Иванов И.И.")); //тест метода SetInspector
        Console.WriteLine("Главный инспектор: " + insp.GetInspector()); 
        string generatedNumber = insp.GenerateNumber("A", 1234, "75"); //тест метода GenerateNumber
        Console.WriteLine("Сгенерированный госномер: " + generatedNumber);
        Console.WriteLine("Список сотрудников:"); 

        foreach (var worker in insp.GetWorker()) //тест метода GetWorker
        {
            Console.WriteLine(worker); //вывод списка
        }

        insp.AddWorker("Новиков Н.Н."); //тест метода AddWorker
        Console.WriteLine("Список сотрудников после добавления 'Новиков Н.Н.':");
        foreach (var worker in insp.GetWorker())
        {
            Console.WriteLine(worker); //вывод нового списка
        }
    }
}