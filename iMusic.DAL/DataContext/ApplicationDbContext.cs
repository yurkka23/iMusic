using IdentityModel;
using iMusic.DAL.Constants;
using iMusic.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Security.Claims;

namespace iMusic.DAL.DataContext;

public class ApplicationDbContext : IdentityDbContext<User, AppRole, Guid>
{
    //public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<FavoriteList> FavoriteLists { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<UserSong> UserSongs { get; set; }
    public DbSet<UserAlbum> UserAlbums { get; set; }
    public DbSet<SongPlaylist> SongPlaylists { get; set; }
    public DbSet<FavoritePlaylists> FavoritePlaylists { get; set; }
    public DbSet<FavoriteAlbums> FavoriteAlbums { get; set; }
    public DbSet<FavoriteSongs> FavoriteSongs { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Entity<IdentityUserRole<Guid>>().HasData(
          new IdentityUserRole<Guid>
          {
              RoleId = Guid.Parse("1CFBA6F6-50FA-4304-9140-4BD86F5A5885"),
              UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb8")
          }
      );

        builder.Entity<IdentityUserClaim<Guid>>().HasData(
               new List<IdentityUserClaim<Guid>>()
               {
                   new IdentityUserClaim<Guid>()
                   {
                       Id = 3000,
                       ClaimType = JwtClaimTypes.Name,
                       ClaimValue = "admin2",
                       UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb8")
                   },
                   new IdentityUserClaim<Guid>()
                   {
                       Id = 3001,
                       ClaimType = JwtClaimTypes.Id,
                       ClaimValue = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                       UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb8")
                   },
                   new IdentityUserClaim<Guid>()
                   {
                       Id = 3002,
                       ClaimType = ClaimTypes.Email,
                       ClaimValue = "admin2@gmail.com",
                       UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb8")
                   },
                   new IdentityUserClaim<Guid>()
                   {

                       Id = 3003,
                       ClaimType = ClaimTypes.GivenName,
                       ClaimValue = "admin2 admin",
                       UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb8")
                   },
                    new IdentityUserClaim<Guid>()
                   {
                       Id = 3006,
                       ClaimType = JwtClaimTypes.Role,
                       ClaimValue = RoleConstants.AdminRole,
                       UserId = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb8")
                   },
               }
               );
    }
}
