using System;

namespace PaternsHomework
{
    /*Создать базовый класс Автомобиль
    Создать потомки классы: автобус, грузовик, трактор
    реализовать методы (ехать, ломаться)
    свойства (вес, грузоподъемность)
    наследование провести через abstract class и через интерфейс
    привести пример переопределния любого метода*/
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();
            bus.Go();
            bus.Break();

            Tractor tractor = new Tractor();
            tractor.Break();
            tractor.Go();
        }
    }
}
