using BlazorHtmx.Features.Games;

namespace BlazorHtmx.Databases;

public static class Database
{
    public static List<Game> Games = new()
    {
        new (1972, "Pong", "Atari", "Atari"),
        new (1978, "Space Invaders", "Taito", "Arcade"),
        new (1986, "Outrun", "Sega", "Arcade"),
        new (1992, "Sonic The Hedgehog 2", "Sega", "Mega Drive"),
        new (1992, "Street Fighter II Turbo", "Capcom", "Arcade"),
        new (1992, "Streets Of Rage 2", "Sega", "Mega Drive"),
        new (1992, "The Legend of Zelda: A Link To The Past", "Nintendo", "SNES"),
        new (1993, "Super Mario Bros. 3", "Nintendo", "NES"),
        new (1994, "Super Metroid", "Nintendo", "SNES"),
        new (1995, "Chrono Trigger", "Squaresoft", "SNES"),
        new (1996, "Resident Evil", "Capcom", "Playstation"),
    };
}
