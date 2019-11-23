using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Entities.Base.Interfaces
{
    interface IOrderedEntity
    {
        int Order { get; set; }
    }
}
