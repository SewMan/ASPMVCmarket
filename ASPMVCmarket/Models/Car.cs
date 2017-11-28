using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCmarket.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseData { get; set; }
        public int AmountInStock { get; set; }
        public string Description { get; set; }
    }
}