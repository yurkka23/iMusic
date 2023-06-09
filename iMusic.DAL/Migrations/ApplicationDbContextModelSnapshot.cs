﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iMusic.DAL.DataContext;

#nullable disable

namespace iMusic.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("iMusic.DAL.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlbumImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CountRate")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("SingerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SingerId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1cfba6f6-50fa-4304-9140-4bd86f5a5885"),
                            ConcurrencyStamp = "cc1a7d87-4b95-4ba6-843f-899558e3d4db",
                            Name = "iMusic.admin",
                            NormalizedName = "IMUSIC.ADMIN"
                        },
                        new
                        {
                            Id = new Guid("d013ca6b-ea46-4947-9a7f-a249406ff873"),
                            ConcurrencyStamp = "2f3203ac-cd7d-49f5-bcef-b162d08ae9e1",
                            Name = "iMusic.user",
                            NormalizedName = "IMUSIC.USER"
                        },
                        new
                        {
                            Id = new Guid("70f964d3-7677-4ac5-952b-f4713352ca5e"),
                            ConcurrencyStamp = "084f0c43-74c4-44f1-ace1-a561b81a1c52",
                            Name = "iMusic.singer",
                            NormalizedName = "IMUSIC.SINGER"
                        });
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoriteAlbums", b =>
                {
                    b.Property<Guid>("FavoritelistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("AddedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("FavoritelistId", "AlbumId");

                    b.HasIndex("AlbumId");

                    b.ToTable("FavoriteAlbums");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoriteList", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.ToTable("FavoriteLists");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoritePlaylists", b =>
                {
                    b.Property<Guid>("FavoritelistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaylistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("AddedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("FavoritelistId", "PlaylistId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("FavoritePlaylists");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoriteSongs", b =>
                {
                    b.Property<Guid>("FavoritelistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("AddedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("FavoritelistId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("FavoriteSongs");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Playlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CountRate")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("PlaylistImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Song", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CountRate")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<Guid>("SingerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SongImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SingerId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.SongPlaylist", b =>
                {
                    b.Property<Guid>("SongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaylistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("AddedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("SongId", "PlaylistId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("SongPlaylists");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AboutMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("BannedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<Guid?>("FavoriteListId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBanned")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("RefreshTokenExpires")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("RegisterTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool?>("WantToBeSinger")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3933b6f9-affa-4c92-8691-4a4a1d0e027e",
                            Email = "admin2@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "admin2",
                            IsBanned = false,
                            LastName = "admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN2@GMAIL.COM",
                            NormalizedUserName = "ADMIN2",
                            PasswordHash = "AQAAAAEAACcQAAAAEDbv2gdENQQEj74VQ3pFfKXFJmAUYXlYNRuIcXMz/qFC2aIFabazxJVkWBgHDCuIvQ==",
                            PhoneNumberConfirmed = false,
                            RefreshToken = "",
                            RegisterTime = new DateTimeOffset(new DateTime(2023, 5, 1, 10, 36, 3, 480, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 0, 0, 0, 0)),
                            SecurityStamp = "2FIUSIDWWXNH7N6KXWVZFFGAICGDPTX7",
                            TwoFactorEnabled = false,
                            UserName = "admin2"
                        });
                });

            modelBuilder.Entity("iMusic.DAL.Entities.UserAlbum", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("AddedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("UserId", "AlbumId");

                    b.HasIndex("AlbumId");

                    b.ToTable("UserAlbums");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.UserSong", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SongId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("AddedTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("UserId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("UserSongs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 3000,
                            ClaimType = "name",
                            ClaimValue = "admin2",
                            UserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8")
                        },
                        new
                        {
                            Id = 3001,
                            ClaimType = "id",
                            ClaimValue = "8e445865-a24d-4543-a6c6-9443d048cdb8",
                            UserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8")
                        },
                        new
                        {
                            Id = 3002,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress",
                            ClaimValue = "admin2@gmail.com",
                            UserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8")
                        },
                        new
                        {
                            Id = 3003,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname",
                            ClaimValue = "admin2 admin",
                            UserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8")
                        },
                        new
                        {
                            Id = 3006,
                            ClaimType = "role",
                            ClaimValue = "iMusic.admin",
                            UserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<Guid>");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8"),
                            RoleId = new Guid("1cfba6f6-50fa-4304-9140-4bd86f5a5885")
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("iMusic.DAL.Entities.AppUserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>");

                    b.HasIndex("RoleId");

                    b.HasDiscriminator().HasValue("AppUserRole");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Album", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.Category", "Category")
                        .WithMany("Albums")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("iMusic.DAL.Entities.User", "User")
                        .WithMany("Albums")
                        .HasForeignKey("SingerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoriteAlbums", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.Album", "Album")
                        .WithMany("FavoriteAlbums")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("iMusic.DAL.Entities.FavoriteList", "Favoritelist")
                        .WithMany("Albums")
                        .HasForeignKey("FavoritelistId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Album");

                    b.Navigation("Favoritelist");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoriteList", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.User", "User")
                        .WithOne("FavoriteList")
                        .HasForeignKey("iMusic.DAL.Entities.FavoriteList", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("User");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoritePlaylists", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.FavoriteList", "Favoritelist")
                        .WithMany("Playlists")
                        .HasForeignKey("FavoritelistId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("iMusic.DAL.Entities.Playlist", "Playlist")
                        .WithMany("FavoritePlaylists")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Favoritelist");

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoriteSongs", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.FavoriteList", "Favoritelist")
                        .WithMany("Songs")
                        .HasForeignKey("FavoritelistId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("iMusic.DAL.Entities.Song", "Song")
                        .WithMany("FavoriteSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Favoritelist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Playlist", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.User", "User")
                        .WithMany("Playlists")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("User");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Song", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("iMusic.DAL.Entities.Category", "Category")
                        .WithMany("Songs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("iMusic.DAL.Entities.User", "Singer")
                        .WithMany("Songs")
                        .HasForeignKey("SingerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Album");

                    b.Navigation("Category");

                    b.Navigation("Singer");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.SongPlaylist", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.Playlist", "Playlist")
                        .WithMany("SongPlaylists")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("iMusic.DAL.Entities.Song", "Song")
                        .WithMany("SongPlaylists")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Playlist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.UserAlbum", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.Album", "Album")
                        .WithMany("UserAlbums")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("iMusic.DAL.Entities.User", "User")
                        .WithMany("UserAlbums")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Album");

                    b.Navigation("User");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.UserSong", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.Song", "Song")
                        .WithMany("UserSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("iMusic.DAL.Entities.User", "User")
                        .WithMany("UserSongs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Song");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("iMusic.DAL.Entities.AppUserRole", b =>
                {
                    b.HasOne("iMusic.DAL.Entities.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("iMusic.DAL.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Album", b =>
                {
                    b.Navigation("FavoriteAlbums");

                    b.Navigation("Songs");

                    b.Navigation("UserAlbums");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Category", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.FavoriteList", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Playlists");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Playlist", b =>
                {
                    b.Navigation("FavoritePlaylists");

                    b.Navigation("SongPlaylists");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.Song", b =>
                {
                    b.Navigation("FavoriteSongs");

                    b.Navigation("SongPlaylists");

                    b.Navigation("UserSongs");
                });

            modelBuilder.Entity("iMusic.DAL.Entities.User", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("FavoriteList");

                    b.Navigation("Playlists");

                    b.Navigation("Songs");

                    b.Navigation("UserAlbums");

                    b.Navigation("UserRoles");

                    b.Navigation("UserSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
