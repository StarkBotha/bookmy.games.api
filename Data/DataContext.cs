using bookmy.games.api.Data.Models.Auth;
using bookmy.games.api.Data.Models.Clan;
using bookmy.games.api.Data.Models.Event;
using bookmy.games.api.Data.Models.Profile;
using bookmy.games.api.Data.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bookmy.games.api.Data;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    //Auth
    public DbSet<AuthClaim> AuthClaims { get; set; }
    public DbSet<AuthRole> AuthRoles { get; set; }
    public DbSet<RoleClaim> RoleClaims { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    //Clan
    public DbSet<Clan> Clans { get; set; }
    public DbSet<ClanImage> ClanImages { get; set; }
    public DbSet<ClanLanguage> ClanLanguages { get; set; }
    public DbSet<ClanMember> ClanMembers { get; set; }
    public DbSet<ClanRole> ClanRoles { get; set; }

    //Event
    public DbSet<Event> Events { get; set; }
    public DbSet<EventImage> EventImages { get; set; }
    public DbSet<EventMessage> EventMessages { get; set; }
    public DbSet<Invitation> Invitations { get; set; }
    public DbSet<InvitationStatus> InvitationStatuses { get; set; }

    //Profile
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<ProfileImage> ProfileImages { get; set; }
    public DbSet<ProfileLanguage> ProfileLanguages { get; set; }

    //Shared
    public DbSet<Language> Languages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Auth
        modelBuilder.Entity<AuthClaim>(AuthClaimConfig.Configure);
        modelBuilder.Entity<AuthRole>(AuthRoleConfig.Configure);
        modelBuilder.Entity<RoleClaim>(RoleClaimConfig.Configure);

        var administratorEmailAddress = _configuration["Administrator:EmailAddress"];
        var administratorPassword = _configuration["Administrator:Password"];
        modelBuilder.Entity<User>(entity => UserConfig.Configure(entity, administratorEmailAddress!, administratorPassword!));
        modelBuilder.Entity<UserRole>(UserRoleConfig.Configure);

        //Clan
        modelBuilder.Entity<Clan>(ClanConfig.Configure);
        modelBuilder.Entity<ClanImage>(ClanImageConfig.Configure);
        modelBuilder.Entity<ClanLanguage>(ClanLanguageConfig.Configure);
        modelBuilder.Entity<ClanMember>(ClanMemberConfig.Configure);
        modelBuilder.Entity<ClanRole>(ClanRoleConfig.Configure);

        //Event
        modelBuilder.Entity<Event>(EventConfig.Configure);
        modelBuilder.Entity<EventImage>(EventImageConfig.Configure);
        modelBuilder.Entity<EventMessage>(EventMessageConfig.Configure);
        modelBuilder.Entity<Invitation>(InvitationConfig.Configure);
        modelBuilder.Entity<InvitationStatus>(InvitationStatusConfig.Configure);

        //Profile
        modelBuilder.Entity<Profile>(ProfileConfig.Configure);
        modelBuilder.Entity<ProfileImage>(ProfileImageConfig.Configure);
        modelBuilder.Entity<ProfileLanguage>(ProfileLanguageConfig.Configure);
    }
}
