namespace BlazorScraperDisplay.Models
{
    public class ProgLanguagesAndBooks
    {
        public int LanguageId { get; set; }
        public int RankingOrder { get; set; }
        public string? LanguageName { get; set; }   
        public string? ImageURL {get;set;}
        public int BookId { get; set; }
        public string? Reviews { get; set; }
        public string? BookImageURL { get; set; }
        public string? BookTitle {get;set;}
        public string? BookReviewsCount { get; set; }
        
    }
}