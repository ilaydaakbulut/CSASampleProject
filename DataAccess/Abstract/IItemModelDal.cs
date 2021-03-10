using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{

    public interface IItemModelDal<T> where T:class, IEntity,new()
    {
        List<T> GetList();
        void InsertRecord(T model);
        void UpdateRecord(T model);
        void DeleteRecord(string code);
    }
}
