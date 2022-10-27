using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EclassBackend.Migrations
{
    public partial class UpdatedModelsId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessors_Courses_CoursesCourseId",
                table: "CourseProfessors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessors_Professors_ProfessorsProfessorID",
                table: "CourseProfessors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudents_Courses_CoursesCourseId",
                table: "CourseStudents");

            migrationBuilder.RenameColumn(
                name: "ProfessorID",
                table: "Professors",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "LabId",
                table: "Labs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CoursesCourseId",
                table: "CourseStudents",
                newName: "CoursesId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Courses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProfessorsProfessorID",
                table: "CourseProfessors",
                newName: "ProfessorsID");

            migrationBuilder.RenameColumn(
                name: "CoursesCourseId",
                table: "CourseProfessors",
                newName: "CoursesId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseProfessors_ProfessorsProfessorID",
                table: "CourseProfessors",
                newName: "IX_CourseProfessors_ProfessorsID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessors_Courses_CoursesId",
                table: "CourseProfessors",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessors_Professors_ProfessorsID",
                table: "CourseProfessors",
                column: "ProfessorsID",
                principalTable: "Professors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudents_Courses_CoursesId",
                table: "CourseStudents",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessors_Courses_CoursesId",
                table: "CourseProfessors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseProfessors_Professors_ProfessorsID",
                table: "CourseProfessors");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudents_Courses_CoursesId",
                table: "CourseStudents");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Professors",
                newName: "ProfessorID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Labs",
                newName: "LabId");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseStudents",
                newName: "CoursesCourseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Courses",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "ProfessorsID",
                table: "CourseProfessors",
                newName: "ProfessorsProfessorID");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseProfessors",
                newName: "CoursesCourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseProfessors_ProfessorsID",
                table: "CourseProfessors",
                newName: "IX_CourseProfessors_ProfessorsProfessorID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessors_Courses_CoursesCourseId",
                table: "CourseProfessors",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseProfessors_Professors_ProfessorsProfessorID",
                table: "CourseProfessors",
                column: "ProfessorsProfessorID",
                principalTable: "Professors",
                principalColumn: "ProfessorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudents_Courses_CoursesCourseId",
                table: "CourseStudents",
                column: "CoursesCourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
