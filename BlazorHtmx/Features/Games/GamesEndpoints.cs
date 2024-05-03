using BlazorHtmx.Databases;
using BlazorHtmx.Features.Games;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BlazorHtmx.Features.Search;

public static class GamesEndpoints
{
    public static WebApplication MapGamesEndpoints(this WebApplication app)
    {
        app.MapGet("/games/search", (string search) =>
        {
            Thread.Sleep(500);

            var games = Database.Games.Where(g =>
                g.Year.ToString().Contains(search, StringComparison.OrdinalIgnoreCase) ||
                g.Publisher.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                g.Console.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                g.Name.Contains(search, StringComparison.OrdinalIgnoreCase));

            return new RazorComponentResult<GameRows>(new { Games = games });
        });

        return app;
    }
}