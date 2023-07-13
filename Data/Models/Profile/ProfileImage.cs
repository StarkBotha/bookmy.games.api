using bookmy.games.api.Data.Models.Shared;

namespace bookmy.games.api.Data.Models.Profile;

public class ProfileImage : EntityBase
{
    public Profile Profile { get; set; } = null!;
    public byte[] ImageData { get; set; } = null!;
}
