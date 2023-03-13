using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University_CRM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collage",
                columns: table => new
                {
                    CollageId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameArabic = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NameEnglish = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DescriptionArabic = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    DescriptionEnglish = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collage", x => x.CollageId);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameArabic = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NameEnglish = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DescriptionArabic = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    DescriptionEnglish = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    CourseCode = table.Column<string>(type: "TEXT", nullable: false),
                    CreditHours = table.Column<int>(type: "INTEGER", nullable: false),
                    HasLap = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "ProgramType",
                columns: table => new
                {
                    ProgramTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameArabic = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NameEnglish = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramType", x => x.ProgramTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameArabic = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NameEnglish = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DescriptionArabic = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    DescriptionEnglish = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    CollageId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Department_Collage_CollageId",
                        column: x => x.CollageId,
                        principalTable: "Collage",
                        principalColumn: "CollageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursePrerequisite",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CoursePrerequisiteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursePrerequisite", x => new { x.CourseId, x.CoursePrerequisiteId });
                    table.ForeignKey(
                        name: "FK_CoursePrerequisite_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursePrerequisite_Course_CoursePrerequisiteId",
                        column: x => x.CoursePrerequisiteId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    ProgramId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameArabic = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    NameEnglish = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DescriptionArabic = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    DescriptionEnglish = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProgramTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.ProgramId);
                    table.ForeignKey(
                        name: "FK_Program_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Program_ProgramType_ProgramTypeId",
                        column: x => x.ProgramTypeId,
                        principalTable: "ProgramType",
                        principalColumn: "ProgramTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgramCourse",
                columns: table => new
                {
                    ProgreamId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false),
                    IsOptional = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramCourse", x => new { x.CourseId, x.ProgreamId });
                    table.ForeignKey(
                        name: "FK_ProgramCourse_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProgramCourse_Program_ProgreamId",
                        column: x => x.ProgreamId,
                        principalTable: "Program",
                        principalColumn: "ProgramId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProgramType",
                columns: new[] { "ProgramTypeId", "NameArabic", "NameEnglish" },
                values: new object[] { 1, "بكالـوريوس", "Bachelor's" });

            migrationBuilder.CreateIndex(
                name: "IX_CoursePrerequisite_CoursePrerequisiteId",
                table: "CoursePrerequisite",
                column: "CoursePrerequisiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_CollageId",
                table: "Department",
                column: "CollageId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_DepartmentId",
                table: "Program",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_ProgramTypeId",
                table: "Program",
                column: "ProgramTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramCourse_ProgreamId",
                table: "ProgramCourse",
                column: "ProgreamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursePrerequisite");

            migrationBuilder.DropTable(
                name: "ProgramCourse");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "ProgramType");

            migrationBuilder.DropTable(
                name: "Collage");
        }
    }
}
