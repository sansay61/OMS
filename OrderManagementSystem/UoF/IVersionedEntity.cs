using OrderManagementSystem.Areas.OMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem.UoF
{
    public interface IVersionedEntity : IBaseEntity
    {
        Users User { get; set; }
        int Version { get; set; }
        short? Iscurrent { get; set; }
        DateTime Chtimestamp { get; set; }
        decimal? Inid { get; set; }

    }
}