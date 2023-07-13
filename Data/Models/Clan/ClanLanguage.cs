using bookmy.games.api.Data.Models.Shared;

namespace bookmy.games.api.Data.Models.Clan;

public class ClanLanguage
{
    public Clan Clan { get; set; } = null!;
    public Language Language { get; set; } = null!;
}
