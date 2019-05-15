using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsfendWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
    }
}