using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbacbf5d-85ce-4a3b-ab11-2732825b1ac5", "AQAAAAEAACcQAAAAEEevzM1wKNzdiisZPVWPqjZnyt1YOYvJMMge4s6nOh5lLslBwuibDM6Dbzb6d4tTEA==", "ded44bca-1474-487a-a97e-9099b5bd64ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73c90be7-0c37-4699-8ac5-37bd08bcaf94", "AQAAAAEAACcQAAAAEBQia+iuS2QURV3Zcnp3FgYdKxCotinnHpdvwVdMI/FyXJm+1FpDM7qgieR86KAoug==", "ead65aa6-0cee-483c-bf67-12ff40aa24b8" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02d602b9-1b13-4ff8-91fc-7e2e564635ff", "AQAAAAEAACcQAAAAEDHjPgNlwSe8rY/d4O3JtxhUUng0rmeJ8yyj+Z06ntaauUAKbsWxN8U0ItN/H2Ok+A==", "8ee3e105-4dcc-456d-a114-029b6c0835ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4608ddb8-16ed-494d-989b-d88c99aae95a", "AQAAAAEAACcQAAAAEAG2mRcJUFl5YUm5NN/ex0l4lqD4fayi97Ri9tGKKvrq5V3flm/rGcIvHnxHnJuHMA==", "ca9009d3-c586-40f0-932b-cc8051f395be" });
        }
    }
}
