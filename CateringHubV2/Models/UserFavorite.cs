//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CateringHubV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserFavorite
    {
        public int UserFavoriteId { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
        public virtual User User { get; set; }
    }
}
