using BlazorScraperDisplay.Data;
using BlazorScraperDisplay.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorScraperDisplay.Services
{
    public class ProgrammingLanguageService:IProgrammingLanguageService
    {
        private readonly ProgrammingResourcesDBContext programmingResourcesDBContext;

        public ProgrammingLanguageService(ProgrammingResourcesDBContext programmingResourcesDBContext)
        {
            this.programmingResourcesDBContext = programmingResourcesDBContext;
        }

        public async Task<List<TIOBERankedLanguage>> GetRankedLanguages()
        {
            return await (from lang in this.programmingResourcesDBContext.TIOBERankedLanguages
                          select new TIOBERankedLanguage{
                                Id = lang.Id,
                                RankOrder = lang.RankOrder,
                                LanguageName = lang.LanguageName,
                                ImagePath = lang.ImagePath
                           }).ToListAsync(); 
        }
    }

}