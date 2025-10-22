using Microsoft.EntityFrameworkCore;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}

    public DbSet<User> Users => Set<User>();
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<FriendRequest> FriendRequests => Set<FriendRequest>();
    public DbSet<FriendRecommendation> FriendRecommendations => Set<FriendRecommendation>();
    public DbSet<Group> Groups => Set<Group>();
    public DbSet<GroupInvitation> GroupInvitations => Set<GroupInvitation>();
    public DbSet<GroupRecommendation> GroupRecommendations => Set<GroupRecommendation>();
    public DbSet<UserGroup> UserGroups => Set<UserGroup>();
    public DbSet<Chat> Chats => Set<Chat>();
    public DbSet<UserChat> UserChats => Set<UserChat>();
    public DbSet<Entry> Entries => Set<Entry>();
    public DbSet<EntryReaction> EntryReactions => Set<EntryReaction>();
    public DbSet<ReadBy> ReadBys => Set<ReadBy>();
    public DbSet<SharedFile> SharedFiles => Set<SharedFile>();
    public DbSet<Emote> Emotes => Set<Emote>();
    

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql(Environment.GetEnvironmentVariable("POSTGRES_CONN_STRING")?? throw new InvalidOperationException("JWT_SECRET not found in environment variables."));
}
