using System.Runtime.CompilerServices;
using BlazorScraperDisplay.Data;
using BlazorScraperDisplay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlazorScraperDisplay.Services
{
    public class AmazonBooksService:IAmazonBooksService
    {
        private readonly ProgrammingResourcesDBContext programmingResourcesDBContext;

        public AmazonBooksService(ProgrammingResourcesDBContext programmingResourcesDBContext)
        {
            this.programmingResourcesDBContext = programmingResourcesDBContext;

        }

        public async Task<List<ProgLanguagesGroupedBooks>> GetGroupedAmazonBooks()
        {


            return await (from t in this.programmingResourcesDBContext.TIOBERankedLanguages
                          join b in this.programmingResourcesDBContext.AmazonBooks
                          on t.Id equals b.LanguageId into grouping
                          orderby t.RankOrder
                          select new ProgLanguagesGroupedBooks
                          {
                                Id = t.Id,
                                LanguageName = t.LanguageName,
                                RankOrder = t.RankOrder,
                                ImagePath = t.ImagePath,
                                AmazonBooks = grouping.ToList()

                          }).ToListAsync();

        }
    }
}
