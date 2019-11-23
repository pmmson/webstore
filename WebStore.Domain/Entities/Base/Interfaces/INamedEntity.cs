using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Entities.Base.Interfaces
{
    interface INamedEntity : IBaseEntity
    {
        string Name { get; set; }
    }
}
