using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iMusic.DAL.Migrations
{
    public partial class addseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AboutMe", "AccessFailedCount", "BannedTime", "ConcurrencyStamp", "Email", "EmailConfirmed", "FavoriteListId", "FirstName", "IsBanned", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpires", "RegisterTime", "SecurityStamp", "TwoFactorEnabled", "UserImgUrl", "UserName", "WantToBeSinger" },
                values: new object[] { new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8"), null, 0, null, "3933b6f9-affa-4c92-8691-4a4a1d0e027e", "admin2@gmail.com", true, null, "admin2", false, "admin", false, null, "ADMIN2@GMAIL.COM", "ADMIN2", "AQAAAAEAACcQAAAAEDbv2gdENQQEj74VQ3pFfKXFJmAUYXlYNRuIcXMz/qFC2aIFabazxJVkWBgHDCuIvQ==", null, false, "", null, new DateTimeOffset(new DateTime(2023, 5, 1, 10, 36, 3, 480, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 0, 0, 0, 0)), "2FIUSIDWWXNH7N6KXWVZFFGAICGDPTX7", false, null, "admin2", null });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 3000, "name", "admin2", new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8") },
                    { 3001, "id", "8e445865-a24d-4543-a6c6-9443d048cdb8", new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8") },
                    { 3002, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress", "admin2@gmail.com", new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8") },
                    { 3003, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname", "admin2 admin", new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8") },
                    { 3006, "role", "iMusic.admin", new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8") }
                });

            migrationBuilder.InsertData(
              table: "AspNetUserRoles",
              columns: new[] { "RoleId", "UserId", "Discriminator" },
              values: new object[] { new Guid("1cfba6f6-50fa-4304-9140-4bd86f5a5885"), new Guid("8e445865-a24d-4543-a6c6-9443d048cdb8"), "IdentityUserRole<Guid>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
