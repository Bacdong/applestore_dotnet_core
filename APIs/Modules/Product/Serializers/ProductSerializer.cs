using System;

namespace applestore.APIs.Modules.Product.Serializers {
    public class ProductSerializer {
        public int id {get; set;}
        public string name {get; set;}
        public string brief {get; set;}
        public string title {get; set;}
        public decimal price {get; set;}
        public decimal originalPrice {get; set;}
        public int inventory {get; set;}
        public int viewCount {get; set;}
        public DateTime created {get; set;}
        public string slug {get; set;}
        public int languageId {get; set;}
    }
}