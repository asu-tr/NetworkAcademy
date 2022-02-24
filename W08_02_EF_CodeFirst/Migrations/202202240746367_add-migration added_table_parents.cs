namespace W08_02_EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationadded_table_parents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parents",
                c => new
                    {
                        ParentID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Address = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.ParentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Parents");
        }
    }
}
