
using BlazorScraperDisplay.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorScraperDisplay.Data
{
    public class ProgrammingResourcesDBContext : DbContext
    {
        public ProgrammingResourcesDBContext(DbContextOptions options) : base(options) { }
        public DbSet<TIOBERankedLanguage> TIOBERankedLanguages { get; set; } = null!;
        public DbSet<AmazonBook> AmazonBooks { get; set; } = null!;
        public DbSet<YouTubeChannel> YouTubeChannels { get; set; } = null!;
    }
}