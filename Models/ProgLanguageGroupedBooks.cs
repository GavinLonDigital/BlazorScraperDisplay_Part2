namespace BlazorScraperDisplay.Models
{
    public class ProgLanguagesGroupedBooks
    {
        public int Id { get; set; }
        public int RankOrder { get; set; }
        public string? LanguageName { get; set; }
        public string? ImagePath { get; set; }

        public List<AmazonBook>? AmazonBooks { get; set; }

        
    }
}