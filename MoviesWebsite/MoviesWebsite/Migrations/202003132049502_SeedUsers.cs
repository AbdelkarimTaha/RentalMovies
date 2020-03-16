namespace MoviesWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'37edf696-dafa-41ef-a663-b8b8211b018e', N'admin@vidly.com', 0, N'AH2ylOq6bYOGZXvSXsSM7Gmrir6b+RJW5tojhcUc3TgFtX73QwC35JUjaspO8tuqsA==', N'6b16ea0c-3315-47fb-8862-0a7c5ac0587e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'effa4366-e7ff-4317-9509-415257aac255', N'guset@vidly.com', 0, N'ANPmMiSOYNuzX8gpa4m2NyWVTge/bC5kyflW0GMMrE7K7WYKmoAmhmmXv8Pnsr+zFA==', N'ace6d7b7-5b0a-4964-8f3b-c417a6596ea5', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b401d1d8-d5a2-4056-bd45-8de746eb14c0', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'37edf696-dafa-41ef-a663-b8b8211b018e', N'b401d1d8-d5a2-4056-bd45-8de746eb14c0')

");
        }
        
        public override void Down()
        {
        }
    }
}
