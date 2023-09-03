using Microsoft.AspNetCore.Identity;

namespace EcommereceWeb.Domain.Entity
{
    public class User:IdentityUser
    {

        public virtual ICollection<AddProductToFavorite> AddProductToFavorites { get; set; }
        public virtual ICollection<ProductEvaluaton> ProductEvaluaton { get; set; }
    }
}
