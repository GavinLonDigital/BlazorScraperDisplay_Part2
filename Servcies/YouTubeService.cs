using BlazorScraperDisplay.Data;
using BlazorScraperDisplay.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorScraperDisplay.Services
{
    public class YouTubeService : IYouTubeService
    {
        private readonly ProgrammingResourcesDBContext programmingResourcesDBContext;

        
        public YouTubeService(ProgrammingResourcesDBContext programmingResourcesDBContext)
        {
            this.programmingResourcesDBContext = programmingResourcesDBContext;
        }
        public async Task<List<ProgLanguageGroupedYTChannels>> GetGroupedYouTubeChannels()
        {
            return await (from t in this.programmingResourcesDBContext.TIOBERankedLanguages
                          join b in this.programmingResourcesDBContext.YouTubeChannels
                          on t.Id equals b.LanguageId into grouping
                          orderby t.RankOrder
                          select new ProgLanguageGroupedYTChannels
                          {
                              Id = t.Id,
                              LanguageName = t.LanguageName,
                              RankOrder = t.RankOrder,
                              ImagePath = t.ImagePath,
                              YouTubeChannels = grouping.ToList()

                          }).ToListAsync();

        }
    }
}
