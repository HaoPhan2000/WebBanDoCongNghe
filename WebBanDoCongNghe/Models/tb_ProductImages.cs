//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanDoCongNghe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_ProductImages
    {
        public int MaImages { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public Nullable<int> MaSanPham { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual tb_Product tb_Product { get; set; }
    }
}