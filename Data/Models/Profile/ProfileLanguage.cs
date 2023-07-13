using bookmy.games.api.Data.Models.Shared;

namespace bookmy.games.api.Data.Models.Profile;

public class ProfileLanguage : EntityBase
{
    public Profile Profile { get; set; } = null!;
    public Language Language { get; set; } = null!;
}
