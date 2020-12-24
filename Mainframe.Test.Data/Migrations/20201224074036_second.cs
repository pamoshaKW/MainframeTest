using Microsoft.EntityFrameworkCore.Migrations;

namespace Mainframe.Test.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Students_StudentsId",
                table: "StudentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Subjects_SubjectsId",
                table: "StudentSubject");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Subjects",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectsId",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentsId",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Credits",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OfferedSemester",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OfferedYear",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "StudentSubject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "StudentSubject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Students_StudentsId",
                table: "StudentSubject",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Subjects_SubjectsId",
                table: "StudentSubject",
                column: "SubjectsId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Students_StudentsId",
                table: "StudentSubject");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentSubject_Subjects_SubjectsId",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "Credits",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "OfferedSemester",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "OfferedYear",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "StudentSubject");

            migrationBuilder.DropColumn(
                name: "description",
                table: "StudentSubject");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Subjects",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SubjectsId",
                table: "StudentSubject",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "StudentsId",
                table: "StudentSubject",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StudentSubject",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Students_StudentsId",
                table: "StudentSubject",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentSubject_Subjects_SubjectsId",
                table: "StudentSubject",
                column: "SubjectsId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
