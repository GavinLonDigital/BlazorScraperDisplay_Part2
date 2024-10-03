using BlazorScraperDisplay.Data;
using BlazorScraperDisplay.Models;

namespace BlazorScraperDisplay.Services
{
    public interface IProgrammingLanguageService
    {   
        Task<List<TIOBERankedLanguage>> GetRankedLanguages();
    
    }

}