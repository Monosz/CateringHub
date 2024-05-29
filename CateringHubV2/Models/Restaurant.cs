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
    
    public partial class Restaurant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Restaurant()
        {
            this.RestaurantMenus = new HashSet<RestaurantMenu>();
            this.UserFavorites = new HashSet<UserFavorite>();
        }
    
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantImage { get; set; }
        public double RestaurantRating { get; set; }
        public int RestaurantLocationId { get; set; }
    
        public virtual Location Location { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RestaurantMenu> RestaurantMenus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserFavorite> UserFavorites { get; set; }
    }
}