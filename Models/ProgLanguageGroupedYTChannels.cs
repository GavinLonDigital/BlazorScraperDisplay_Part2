namespace BlazorScraperDisplay.Models
{
    public class ProgLanguageGroupedYTChannels
    {
        public int Id { get; set; }
        public int RankOrder { get; set; }
        public string? LanguageName { get; set; }
        public string? ImagePath { get; set; }

        public bool Collapse { get; set; } = false;

        public List<YouTubeChannel>? YouTubeChannels { get; set; }
    
    }
}
