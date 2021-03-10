using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ItemModelManager : IItemModelService<ItemModel>
    {
        private readonly IItemModelDal<ItemModel> _itemModelDal;
        public ItemModelManager(IItemModelDal<ItemModel> itemModelDal)
        {
            _itemModelDal = itemModelDal;
        }
        public void DeleteRecord(string code)
        {
            _itemModelDal.DeleteRecord(code);
        }
        public List<ItemModel> GetList()
        {
            return _itemModelDal.GetList();
        }
        public void InsertRecord(ItemModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException("no code to add");
            }
            _itemModelDal.InsertRecord(model);
        }
        public void UpdateRecord(ItemModel model)
        {
            _itemModelDal.UpdateRecord(model);
        }
    }
}
