using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment2_EntityFrameWork.Migrations
{
    public partial class OneToOneDepartmentWithInstructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                unique: true,
                filter: "[Ins_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");
        }
    }
}
