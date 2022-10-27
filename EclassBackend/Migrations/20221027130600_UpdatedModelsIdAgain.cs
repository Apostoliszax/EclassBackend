using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EclassBackend.Migrations
{
    public partial class UpdatedModelsIdAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessors_Courses_CoursesId",
                table: "CourseProfessors");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Labs_LabId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudents_Courses_CoursesId",
                table: "CourseStudents");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Labs",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseStudents",
                newName: "CoursesID");

            migrationBuilder.RenameColumn(
                name: "LabId",
                table: "Courses",
                newName: "LabID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_LabId",
                table: "Courses",
                newName: "IX_Courses_LabID");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseProfessors",
                newName: "CoursesID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessors_Courses_CoursesID",
                table: "CourseProfessors",
                column: "CoursesID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Labs_LabID",
                table: "Courses",
                column: "LabID",
                principalTable: "Labs",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudents_Courses_CoursesID",
                table: "CourseStudents",
                column: "CoursesID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessors_Courses_CoursesID",
                table: "CourseProfessors");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Labs_LabID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudents_Courses_CoursesID",
                table: "CourseStudents");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Labs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CoursesID",
                table: "CourseStudents",
                newName: "CoursesId");

            migrationBuilder.RenameColumn(
                name: "LabID",
                table: "Courses",
                newName: "LabId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Courses",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_LabID",
                table: "Courses",
                newName: "IX_Courses_LabId");

            migrationBuilder.RenameColumn(
                name: "CoursesID",
                table: "CourseProfessors",
                newName: "CoursesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessors_Courses_CoursesId",
                table: "CourseProfessors",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Labs_LabId",
                table: "Courses",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudents_Courses_CoursesId",
                table: "CourseStudents",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
