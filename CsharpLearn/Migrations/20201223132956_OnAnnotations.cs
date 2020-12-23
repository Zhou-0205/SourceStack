using Microsoft.EntityFrameworkCore.Migrations;

namespace CsharpLearn.Migrations
{
    public partial class OnAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropColumn(
                name: "FailedTry",
                table: "students");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Register");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Register",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Register",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Register",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Register",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Register",
                table: "Register",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Register_Createtime",
                table: "Register",
                column: "Createtime",
                unique: true);

            migrationBuilder.AddCheckConstraint(
                name: "CK_Createtime",
                table: "Register",
                sql: "Createtime >= '2000/1/1'");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Register",
                table: "Register");

            migrationBuilder.DropIndex(
                name: "IX_Register_Createtime",
                table: "Register");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Createtime",
                table: "Register");

            migrationBuilder.RenameTable(
                name: "Register",
                newName: "students");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "students",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<int>(
                name: "FailedTry",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");
        }
    }
}
