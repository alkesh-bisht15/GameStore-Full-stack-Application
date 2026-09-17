using GameStore.Api.Data;
using GameStore.Api.Dtos;
using GameStore.Api.Entities;
using GameStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.EndPoints;

public static class GameEndPoints
{
    const string GetGameEndPointName = "GetGame";

    private static readonly List<GameSummaryDto> games = [
        new (
            1,
            "Street Fighter 2",
            "Fighting",
            19.99M,
            new DateOnly(1992, 08, 22)
        ),
        new (
            2,
            "Fifa 26",
            "Sports",
            79.99M,
            new DateOnly(2025, 06, 16)
        ),
        new (
            3,
            "Final Fantasy 8",
            "Roleplaying",
            49.99M,
            new DateOnly(2013, 11, 18)
        )
    ];

    public static RouteGroupBuilder MapGamesEndPoints(this WebApplication app)
    {
        var group = app.MapGroup("games")
                       .WithParameterValidation();

        // GET /games
        group.MapGet("/", async (GameStoreContext dbContext) => 
              await dbContext.Games
                       .Include(game => game.Genre)
                       .Select(game => game.ToGameSummaryDto())
                       .AsNoTracking()
                       .ToListAsync());

        //GET /games/1
        group.MapGet("/{id}", async (int id, GameStoreContext DbContext) =>
        {
            Game? game = await DbContext.Games.FindAsync(id);

            return game is null ? 
                Results.NotFound() : 
                Results.Ok(game.ToGameDetailsDto());
        })
        .WithName(GetGameEndPointName);

        group.MapPost("/", async (CreateGameDto newGame, GameStoreContext dbContext) =>
        {
            Game game = newGame.ToEntity();

            dbContext.Games.Add(game);
            await dbContext.SaveChangesAsync();

            
            return Results.CreatedAtRoute(
                           GetGameEndPointName,
                           new { id = game.Id }, 
                           game.ToGameDetailsDto());
        });

        //PUT /games
        group.MapPut("/{id}", async (int id, UpdateGameDto updatedGame, GameStoreContext dbContext) =>
        {
            var existingGame = await dbContext.Games.FindAsync(id);

            if (existingGame is null)
            {
                return Results.NotFound();
            }

            dbContext.Entry(existingGame)
                     .CurrentValues
                     .SetValues(updatedGame.ToEntity(id));
            
            await dbContext.SaveChangesAsync();

            return Results.NoContent();
        });

        //DELETE /games/1

        group.MapDelete("/{id}", async (int id, GameStoreContext dbContext) =>
        {
            await dbContext.Games
                     .Where(game => game.Id == id)
                     .ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }

}