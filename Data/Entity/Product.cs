using System;
using System.Collections.Generic;

namespace applestore.Data.Entity {
    public class Product {
        public int id {get; set;}
        public decimal price {get; set;}
        public decimal originalPrice {get; set;}
        public int inventory {get; set;}
        public int viewCount {get; set;}
        public DateTime created {get; set;}
        public DateTime updated {get; set;}

        public List<ProductInCategory> productInCategories {get; set;}

        public List<OrderLine> orderLines {get; set;}

        public List <Cart> carts {get; set;}

        public List<ProductTranslation> productTranslations {get; set;}

        public List<ProductImage> productImages {get; set;}
    }
}