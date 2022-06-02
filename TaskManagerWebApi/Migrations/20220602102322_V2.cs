using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManagerWebApi.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE Procedure [dbo].[Sp_StatusCount]
(
@flag tinyint
)
As
Begin
If(@flag=1)--Pending
select Count(*) AS Count from Tasks
group by StatusId
having StatusId=@flag

If(@flag=2)--Processing
select Count(*) AS Count from Tasks
group by StatusId
having StatusId=@flag

If(@flag=3)--Completed
select Count(*) AS Count from Tasks
group by StatusId
having StatusId=@flag

If(@flag=4)--Done
select Count(*) AS Count from Tasks
group by StatusId
having StatusId=@flag

If(@flag=5)--Rejected
select Count(*) AS Count from Tasks
group by StatusId
having StatusId=@flag
End";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
