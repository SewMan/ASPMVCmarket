using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCmarket.Dtos
{
    public class MembershipTypeDto
    {
        public byte Id { get; set; }
        public string MembershipTypeName { get; set; }
        public byte DiscountRate { get; set; }
    }
}