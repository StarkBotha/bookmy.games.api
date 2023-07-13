namespace bookmy.games.api.Data.Models.Clan;

public class ClanImage : EntityBase
{
    public Clan Clan { get; set; } = null!;
    public byte[] ImageData { get; set; } = null!;
}
