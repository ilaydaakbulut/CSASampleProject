using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ItemModel:IEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
