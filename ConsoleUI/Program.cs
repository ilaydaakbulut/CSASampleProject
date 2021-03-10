using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //dependency injection
            var serviceProvider = new ServiceCollection().AddScoped<IItemModelService<ItemModel>,ItemModelManager>().AddScoped<IItemModelDal<ItemModel>, InMemoryItemModelDal>().BuildServiceProvider();
            IItemModelService<ItemModel> _itemModelService = serviceProvider.GetService<IItemModelService<ItemModel>>();
            Console.WriteLine("Insert Record");
            var newItemToInsert = new ItemModel{ Code="6",Description= "seventh code" };
            _itemModelService.InsertRecord(newItemToInsert);
            var list = _itemModelService.GetList();
            foreach (var item in list)
            {
                Console.WriteLine(item.Code + "  " + item.Description);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Delete Record");
            _itemModelService.DeleteRecord("4");
            foreach (var item in list)
            {
                Console.WriteLine(item.Code + "  " + item.Description);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Update Record");
            var newItemToUpdate = new ItemModel { Code = "6", Description = "sixth code" };
            _itemModelService.UpdateRecord(newItemToUpdate);
            foreach (var item in list)
            {
                Console.WriteLine(item.Code + "  " + item.Description);
            }
            Console.ReadKey();
        }
    }
}
