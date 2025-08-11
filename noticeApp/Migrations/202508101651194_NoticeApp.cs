namespace noticeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoticeApp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NoticeTables", "PublicationDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.NoticeTables", "DisplayStartData", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.NoticeTables", "DisplayEndData", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NoticeTables", "DisplayEndData", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NoticeTables", "DisplayStartData", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NoticeTables", "PublicationDate", c => c.DateTime(nullable: false));
        }
    }
}
