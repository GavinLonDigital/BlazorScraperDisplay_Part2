using BlazorScraperDisplay.Models;

namespace BlazorScraperDisplay.Services
{
    public interface IYouTubeService
    {
        Task<List<ProgLanguageGroupedYTChannels>> GetGroupedYouTubeChannels();
    }
}
