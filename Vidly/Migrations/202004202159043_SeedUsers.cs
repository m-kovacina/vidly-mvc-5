namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a4dc5c22-25fd-4a82-8b41-222176fbfc77', N'guest@vidly.com', 0, N'ADVXqFF8eMNoXf+JaqORX9T92/VrwVLbn2yf4ZST0oAYH/L4j3Ju147zxkiCwr/Whw==', N'b248ae27-d05f-4b52-8998-bfd8c29f1f42', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'af6ad0ae-017b-4048-a6f7-063025333aab', N'admin@vidly.com', 0, N'APKSgp1eai662nTeP64Yx1FmBCJsn/0Oz3o6o9UI+U4oOrgXkF/5fm/6s8f9dPXX0g==', N'fe523254-d2b1-4f89-98eb-8b4f03e3e9f3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b4674ebe-da58-47bd-b7b3-457d6a2023e2', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'af6ad0ae-017b-4048-a6f7-063025333aab', N'b4674ebe-da58-47bd-b7b3-457d6a2023e2')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
