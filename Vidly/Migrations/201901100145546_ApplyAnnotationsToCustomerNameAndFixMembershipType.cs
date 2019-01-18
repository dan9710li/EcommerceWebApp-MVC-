namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToCustomerNameAndFixMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.MembershipTypes", "SignUpFree");
        }
  
public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "SignUpFree", c => c.Short(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "SignUpFee");
        }
    }
}
