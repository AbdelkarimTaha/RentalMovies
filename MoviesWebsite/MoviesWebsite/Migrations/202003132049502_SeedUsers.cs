namespace MoviesWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'330911ef-1abe-4951-bc34-aa360783501b', N'admin@vidly.com', 0, N'AB+Jy3/Trb67CEUpkOrVeZQnnZKqlhd25gqRVheiP06z7WnVvlylAPTtGb0kRc7Z/A==', N'82e64df4-c474-400f-925e-0639aa24e7f3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fee01fc4-0a90-491e-a4c4-089c1a045a8e', N'guest@vidly.com', 0, N'AETlgxNdGC39l1cbaMcmCRHSVjRIuEEcFxnxj9sWeFIQJy0kxWaROWU9VT6fZfRYwA==', N'bbe2ed0c-f3ba-4205-a59a-662d45067f61', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'028a82bf-643a-48d4-b39d-3336ab8e7f21', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'330911ef-1abe-4951-bc34-aa360783501b', N'028a82bf-643a-48d4-b39d-3336ab8e7f21')

");
        }
        
        public override void Down()
        {
        }
    }
}
