using iMusic.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iMusic.DAL.DataContext.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasIndex(x => x.Email).IsUnique();

        builder.HasOne(t => t.FavoriteList)
            .WithOne(t => t.User)
            .HasForeignKey<FavoriteList>(t => t.UserId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Playlists)
            .WithOne(x => x.User)
            .HasForeignKey(x => x.AuthorId)
             .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(ur => ur.UserRoles)
            .WithOne(u => u.User)
            .HasForeignKey(ur => ur.UserId)
            .IsRequired(false)
            .IsRequired();

        builder.HasData(
               new User
               {
                   Id = Guid.Parse("8e445865-a24d-4543-a6c6-9443d048cdb8"),
                   Email = "admin2@gmail.com",
                   NormalizedEmail = "admin2@gmail.com".ToUpper(),
                   UserName = "admin2",
                   NormalizedUserName = "admin2".ToUpper(),
                   FirstName = "admin2",
                   LastName = "admin",
                   EmailConfirmed = true,
                   IsBanned = false,
                   UserImgUrl = null,
                   PasswordHash = "AQAAAAEAACcQAAAAEDbv2gdENQQEj74VQ3pFfKXFJmAUYXlYNRuIcXMz/qFC2aIFabazxJVkWBgHDCuIvQ==",//Motlox23
                   SecurityStamp = "2FIUSIDWWXNH7N6KXWVZFFGAICGDPTX7",
                   ConcurrencyStamp = "3933b6f9-affa-4c92-8691-4a4a1d0e027e",
                   RegisterTime = DateTimeOffset.UtcNow
               }
           );
    }
}
