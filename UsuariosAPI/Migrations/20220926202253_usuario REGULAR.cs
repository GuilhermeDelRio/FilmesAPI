using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class usuarioREGULAR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "64ec94bc-f8c7-47ab-bb34-d0f53069a1d2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "cfea0325-c9b4-4c67-9964-2ccacaa79eb5", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b08107e-0616-495b-8b53-16cd062c06a5", "AQAAAAEAACcQAAAAEJMq1iIro1jTU75EWpBrv1L6JMqtywEPW4ELUQJSMVqb7artLDERuGDYAzEVhhFgeQ==", "0bc63a8c-25b7-4fb9-8b86-69309c461960" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "57e9a698-1f8e-4541-81e4-05a5b2ad2b45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ec32968-d9cc-4d9e-b831-611fa9ece70a", "AQAAAAEAACcQAAAAEKZd7JDdgfbazUpU6AKICPHRWcLFQZ3/KTrDV5iZhkSvGtx5dRRzFFVjDUXaK2GquQ==", "81648bf9-bd00-4f7a-8475-e6339572796b" });
        }
    }
}
