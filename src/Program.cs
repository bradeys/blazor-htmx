using BlazorHtmx.Components;
using BlazorHtmx.Features.Search;
using static BlazorHtmx.Features.Counter.Counter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddSingleton<HtmxCounterState>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<Routes>().AddInteractiveServerRenderMode();

app.MapGamesEndpoints();

app.Run();