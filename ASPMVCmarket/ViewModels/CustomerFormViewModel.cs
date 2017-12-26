using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPMVCmarket.Models;

namespace ASPMVCmarket.ViewModels
{
    public class CustomerFormViewModel
    {
        public List<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}