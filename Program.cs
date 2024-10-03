using BlazorScraperDisplay.Components;
using BlazorScraperDisplay.Data;
using BlazorScraperDisplay.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var connectionString = builder.Configuration.GetConnectionString("ProgrammingResourcesDBContext");
builder.Services.AddDbContext<ProgrammingResourcesDBContext>(options => options.UseSqlServer(connectionString));

//    builder.Services.AddDbContext<ProgrammingResourcesDBContext>(options => options.UseSqlite(connectionString));

builder.Services.AddScoped<IProgrammingLanguageService, ProgrammingLanguageService>();
builder.Services.AddScoped<IAmazonBooksService, AmazonBooksService>();
builder.Services.AddScoped<IYouTubeService, YouTubeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
