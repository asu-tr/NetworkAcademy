namespace W08_02_EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rename_lecture_name_lecturename : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lectures", "LectureName", c => c.String(nullable: false, maxLength: 20));
            Sql("update Lectures set LectureName = Name");
            DropColumn("dbo.Lectures", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lectures", "Name", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Lectures", "LectureName");
        }
    }
}
