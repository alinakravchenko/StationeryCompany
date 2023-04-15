using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryCompany2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Домашняя работа Фирма Канцтоваров";
            ConsoleMenu menu = new ConsoleMenu("Главное меню");

            menu.AddMenu("Инфомация о типах канцтоваров", DataBaseInfo.InfoTypeProduct);
            menu.AddMenu("Вставка новых типов канцтоваров", DataBaseInfo.InsertTypeProduct);
            menu.AddMenu("Обновление информации о существующих типах канцтоваров", DataBaseInfo.UpdateTypeProduct);
            menu.AddMenu("Удаление типов канцтоваров", DataBaseInfo.DeleteTypeProduct);

            menu.AddMenu("Информация о поставщиках", DataBaseInfo.InfoSupplier);
            menu.AddMenu("Вставка новых поставщиков", DataBaseInfo.InsertSupplier);
            menu.AddMenu("Обновление информации о существующих поставщиках", DataBaseInfo.UpdateSupplier);
            menu.AddMenu("Удаление поставщиков", DataBaseInfo.DeleteSupplier);

            menu.AddMenu("Информация о канцтоварах", DataBaseInfo.InfoProducts);
            menu.AddMenu("Вставка новых канцтоваров", DataBaseInfo.InsertProduct);
            menu.AddMenu("Обновление информации о существующих канцтоварах", DataBaseInfo.UpdateProduct);
            menu.AddMenu("Удаление канцтоваров", DataBaseInfo.DeleteProduct);

            menu.AddMenu("Показать информацию о поставщике с наибольшим количеством канцтоваров на складе", DataBaseInfo.InfoSupplierBigCountProduct);
            menu.AddMenu("Показать информацию о поставщике с наименьшим количеством канцтоваров на складе", DataBaseInfo.InfoSupplierLittleCountProduct);
            menu.AddMenu("Показать информацию о типе товаров с наибольшим количеством канцтоваров на складе", DataBaseInfo.InfoTypeProductrBigCountProduct);
            menu.AddMenu("Показать информацию о типе товаров с наименьшим количеством канцтоваров на складе", DataBaseInfo.InfoTypeProductrLittleCountProduct);
            menu.AddMenu("Показать канцтовары с поставки, которых прошло заданное количество дней", DataBaseInfo.InfoProductDeliveryPassedNumberDays);

            menu.ShowMenu();

        }
    }
}
