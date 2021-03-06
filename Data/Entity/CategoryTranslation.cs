namespace applestore.Data.Entity {
    public class CategoryTranslation {
        public int id {get; set;}
        public int categoryId {get; set;}
        public string name {get; set;}
        public string brief {get; set;}
        public string title {get; set;}
        public int languageId {get; set;}
        public string slug {get; set;}

        public Category category {get; set;}

        public Language language {get; set;}
    }
}