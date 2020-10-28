using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomieApi.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Course = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: false),
                    RoomCapacity = table.Column<string>(nullable: false),
                    IsConfirmed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hostels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostelName = table.Column<string>(maxLength: 32, nullable: false),
                    IsRoomAvailable = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    Region = table.Column<string>(nullable: false),
                    RoomCapacity = table.Column<string>(nullable: false),
                    HostelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hostels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ProfilePic = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HostelProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Images = table.Column<string>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    HostelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostelProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostelProfile_Hostels_HostelId",
                        column: x => x.HostelId,
                        principalTable: "Hostels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentProfile",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    IndexNumber = table.Column<string>(maxLength: 10, nullable: false),
                    Course = table.Column<string>(nullable: false),
                    School = table.Column<string>(nullable: false),
                    Level = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentProfile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentProfile_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Course", "Image", "IsConfirmed", "Level", "Phone", "RoomCapacity", "StudentName" },
                values: new object[] { 1, "Computer Science", null, true, "200", "0549234591", "2 in a room", "Derrick Yeboah" });

            migrationBuilder.InsertData(
                table: "Hostels",
                columns: new[] { "Id", "Description", "HostelId", "HostelName", "IsRoomAvailable", "Location", "Region", "RoomCapacity" },
                values: new object[] { 1, "Lucrative rooms with space", 0, "Harvard Green Hostel", true, "Sunyani", "Bono Region", "1" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "Phone", "ProfilePic", "StudentId" },
                values: new object[] { 1, "Derrick", "Yeboah", "24533", "0549234567", null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_HostelProfile_HostelId",
                table: "HostelProfile",
                column: "HostelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_StudentId",
                table: "StudentProfile",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "HostelProfile");

            migrationBuilder.DropTable(
                name: "StudentProfile");

            migrationBuilder.DropTable(
                name: "Hostels");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
