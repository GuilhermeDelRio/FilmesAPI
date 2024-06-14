using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosAPI.Migrations
{
    public partial class adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "77aaa1cc-948c-4ce1-a262-b77b29308f5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "d1a27258-ad58-473c-9995-14f311a78813");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c219e17-0255-4c27-9c23-4ff51bb54b6e", "AQAAAAEAACcQAAAAELNfricunJUvBOfR2/PKYeiHl4qXCMFZUY564ZDYt8iIu6ElpzzKnpVZB2jNZfeOWQ==", "64b1e5de-3fad-441f-b5d9-6eb460b296f0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "cfea0325-c9b4-4c67-9964-2ccacaa79eb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "64ec94bc-f8c7-47ab-bb34-d0f53069a1d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b08107e-0616-495b-8b53-16cd062c06a5", "AQAAAAEAACcQAAAAEJMq1iIro1jTU75EWpBrv1L6JMqtywEPW4ELUQJSMVqb7artLDERuGDYAzEVhhFgeQ==", "0bc63a8c-25b7-4fb9-8b86-69309c461960" });
        }
    }
}
