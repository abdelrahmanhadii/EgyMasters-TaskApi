using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnteredBy = table.Column<string>(nullable: true),
                    EnteredDate = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDeletedBy = table.Column<string>(nullable: true),
                    IsDeletedDate = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Residence = table.Column<string>(maxLength: 150, nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    SalesMan = table.Column<string>(maxLength: 20, nullable: false),
                    ClientSource = table.Column<string>(maxLength: 20, nullable: true),
                    ClientClassfication = table.Column<string>(maxLength: 20, nullable: true),
                    Telephone1 = table.Column<string>(maxLength: 15, nullable: true),
                    Telephone2 = table.Column<string>(maxLength: 15, nullable: true),
                    Mobile = table.Column<string>(maxLength: 11, nullable: false),
                    Whatsapp = table.Column<string>(maxLength: 11, nullable: true),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EnteredBy = table.Column<string>(nullable: true),
                    EnteredDate = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsDeletedBy = table.Column<string>(nullable: true),
                    IsDeletedDate = table.Column<string>(nullable: true),
                    ClientId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    Label = table.Column<string>(maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Project = table.Column<string>(maxLength: 20, nullable: false),
                    Situation = table.Column<string>(maxLength: 200, nullable: true),
                    Type = table.Column<string>(maxLength: 20, nullable: false),
                    Done = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calls_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calls_ClientId",
                table: "Calls",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calls");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
