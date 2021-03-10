using Business.Concrete;
using Entities.Concrete;
using System;
using Xunit;

namespace TestConsole
{
    public class TestApp
    {
        private readonly ItemModelManager _itemModelManager;
        public TestApp()
        {

        }

        [Fact]
        public void Test1()
        {
            InsertRecordTest()
            {
                var insertResult = ItemModelManager.Insert(new ItemModel { .... });
                //check insertresult....  insert update iþlemlerinde Result tipinde bir 
                //model kullanabilir ve içerisinde Success (boolean) veya Message gibi deðiþkenleri döndürebilirsiniz.
            }

        }
    }
}
