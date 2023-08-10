using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConnectionNPG.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lesson_Id",
                table: "Tasks",
                newName: "LessonId");

            migrationBuilder.RenameColumn(
                name: "Comment_Id",
                table: "Tasks",
                newName: "CommentId");

            migrationBuilder.RenameColumn(
                name: "DescriptionCourse_Id",
                table: "Reviews",
                newName: "DescriptionCourseId");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Results",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "DescriptionCourse_Id",
                table: "Results",
                newName: "DescriptionCourseId");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "Lessons",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Homework",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Task_Id",
                table: "Homework",
                newName: "TaskId");

            migrationBuilder.RenameColumn(
                name: "Course_Id",
                table: "DescriptionCourses",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "DescriptionCourse_Id",
                table: "Courses",
                newName: "DescriptionCourseId");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Comments",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Task_Id",
                table: "Comments",
                newName: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CommentId",
                table: "Tasks",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_LessonId",
                table: "Tasks",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_DescriptionCourseId",
                table: "Reviews",
                column: "DescriptionCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_DescriptionCourseId",
                table: "Results",
                column: "DescriptionCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_UserId",
                table: "Results",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Homework_TaskId",
                table: "Homework",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Homework_UserId",
                table: "Homework",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionCourses_CourseId",
                table: "DescriptionCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DescriptionCourseId",
                table: "Courses",
                column: "DescriptionCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TaskId",
                table: "Comments",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Tasks_TaskId",
                table: "Comments",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_DescriptionCourses_DescriptionCourseId",
                table: "Courses",
                column: "DescriptionCourseId",
                principalTable: "DescriptionCourses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DescriptionCourses_Courses_CourseId",
                table: "DescriptionCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Tasks_TaskId",
                table: "Homework",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Homework_Users_UserId",
                table: "Homework",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_DescriptionCourses_DescriptionCourseId",
                table: "Results",
                column: "DescriptionCourseId",
                principalTable: "DescriptionCourses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_DescriptionCourses_DescriptionCourseId",
                table: "Reviews",
                column: "DescriptionCourseId",
                principalTable: "DescriptionCourses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Comments_CommentId",
                table: "Tasks",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Lessons_LessonId",
                table: "Tasks",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Tasks_TaskId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_DescriptionCourses_DescriptionCourseId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_DescriptionCourses_Courses_CourseId",
                table: "DescriptionCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Tasks_TaskId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_Homework_Users_UserId",
                table: "Homework");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_DescriptionCourses_DescriptionCourseId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_DescriptionCourses_DescriptionCourseId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Comments_CommentId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Lessons_LessonId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CommentId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_LessonId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_DescriptionCourseId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Results_DescriptionCourseId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_UserId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Homework_TaskId",
                table: "Homework");

            migrationBuilder.DropIndex(
                name: "IX_Homework_UserId",
                table: "Homework");

            migrationBuilder.DropIndex(
                name: "IX_DescriptionCourses_CourseId",
                table: "DescriptionCourses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DescriptionCourseId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Comments_TaskId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserId",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "Tasks",
                newName: "Lesson_Id");

            migrationBuilder.RenameColumn(
                name: "CommentId",
                table: "Tasks",
                newName: "Comment_Id");

            migrationBuilder.RenameColumn(
                name: "DescriptionCourseId",
                table: "Reviews",
                newName: "DescriptionCourse_Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Results",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "DescriptionCourseId",
                table: "Results",
                newName: "DescriptionCourse_Id");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Lessons",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Homework",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Homework",
                newName: "Task_Id");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "DescriptionCourses",
                newName: "Course_Id");

            migrationBuilder.RenameColumn(
                name: "DescriptionCourseId",
                table: "Courses",
                newName: "DescriptionCourse_Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Comments",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Comments",
                newName: "Task_Id");
        }
    }
}
