namespace applestore.Data.Entity {
    public class ProductTranslation {
        public int id {get; set;}
        public int productId {get; set;}
        public string name {get; set;}
        public string brief {get; set;}
        public string title {get; set;}
        public int languageId {get; set;}
        public string slug {get; set;}

        public Product product {get; set;}

        public Language language {get; set;}
    }
}