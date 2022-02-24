namespace W08_02_EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_column_hour_table_lecture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lectures", "Hour", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lectures", "Hour");
        }
    }
}
