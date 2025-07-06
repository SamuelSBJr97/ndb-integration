using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Crawler.Ndb.Integration.ApiService.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CrawlerNdbIntegrationApiServiceContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CrawlerNdbIntegrationApiServiceContext") ?? throw new InvalidOperationException("Connection string 'CrawlerNdbIntegrationApiServiceContext' not found.")));

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

app.MapDefaultEndpoints();

app.Run();
