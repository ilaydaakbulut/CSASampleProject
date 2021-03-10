using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryItemModelDal : IItemModelDal<ItemModel>
    {
        List<ItemModel> _itemModels;
        public InMemoryItemModelDal()
        {
            _itemModels = new List<ItemModel> {
                new ItemModel{Code="1",Description="first code"},
                new ItemModel{Code="2",Description="second code"},
                new ItemModel{Code="3",Description="third code"},
                new ItemModel{Code="4",Description="fourth code"},
                new ItemModel{Code="5",Description="fifth code"},
            };
        }
        public List<ItemModel> GetList()
        {
            return _itemModels;
        }
        public void InsertRecord(ItemModel model)
        {
            var itemModelToAdd = _itemModels.Find(i => i.Code == model.Code);
            if (itemModelToAdd!=null)
            {
                throw new ArgumentException("this code already exists");
            }
            _itemModels.Add(model);
        }
        public void UpdateRecord(ItemModel model)
        {
            var itemModelToUpdate = _itemModels.Find(i => i.Code == model.Code);
            if (itemModelToUpdate == null)
            {
                throw new ArgumentNullException("no code to update");
            }
            itemModelToUpdate.Description = model.Description;
        }
        public void DeleteRecord(string code)
        {
            var itemModelToDelete = _itemModels.Find(i => i.Code == code);
            if (itemModelToDelete == null)
            {
                throw new ArgumentNullException("no code to delete");
            }
            _itemModels.Remove(itemModelToDelete);

        }
    }
}
