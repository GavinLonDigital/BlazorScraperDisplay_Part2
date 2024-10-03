using BlazorScraperDisplay.Data;
using BlazorScraperDisplay.Models;

namespace BlazorScraperDisplay.Services
{
    public interface IAmazonBooksService
    {   

        Task<List<ProgLanguagesGroupedBooks>> GetGroupedAmazonBooks();
    }

}