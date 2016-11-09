using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagementSystem.Security
{
    public class CRole:IRole<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}