namespace bookmy.games.api.Data.Models.Clan;

public class Clan : External
{
    public string Name { get; set; } = null!;
    public string DiscordUrl { get; set; } = null!;
    public List<ClanLanguage> Languages { get; set; } = null!;
    public List<ClanMember> Members { get; set; } = null!;
}
