
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/01/2015 02:30:27
-- Generated from EDMX file: E:\Code Vault\Github\Simorgh\Simorgh\Simorgh\Models\Simorgh.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [aspnet-Simorgh-20150101022723];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetRoles_Role_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_Role_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserClaims] DROP CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserLogins] DROP CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetUsers_ApplicationUser_Id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_ApplicationUser_Id];
GO
IF OBJECT_ID(N'[dbo].[FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AspNetUserRoles] DROP CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_ImageFileHotel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageFiles] DROP CONSTRAINT [FK_ImageFileHotel];
GO
IF OBJECT_ID(N'[dbo].[FK_RoomTypeHotel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RoomTypes] DROP CONSTRAINT [FK_RoomTypeHotel];
GO
IF OBJECT_ID(N'[dbo].[FK_RoomTypeImageFile]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImageFiles] DROP CONSTRAINT [FK_RoomTypeImageFile];
GO
IF OBJECT_ID(N'[dbo].[FK_HOTEL_PK_CITY]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Hotels] DROP CONSTRAINT [FK_HOTEL_PK_CITY];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserReservation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservations] DROP CONSTRAINT [FK_AspNetUserReservation];
GO
IF OBJECT_ID(N'[dbo].[FK_ToUserID_PK_UserId]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Messages] DROP CONSTRAINT [FK_ToUserID_PK_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_FromUserID_PK_UserID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Messages] DROP CONSTRAINT [FK_FromUserID_PK_UserID];
GO
IF OBJECT_ID(N'[dbo].[FK_PK_RoomType_FK_Reservation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservations] DROP CONSTRAINT [FK_PK_RoomType_FK_Reservation];
GO
IF OBJECT_ID(N'[dbo].[FK_Rating_PK_Hotel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ratings] DROP CONSTRAINT [FK_Rating_PK_Hotel];
GO
IF OBJECT_ID(N'[dbo].[FK_Rating_PK_AspNetUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ratings] DROP CONSTRAINT [FK_Rating_PK_AspNetUser];
GO
IF OBJECT_ID(N'[dbo].[FK_AspNetUserRoomReview]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RoomReviews] DROP CONSTRAINT [FK_AspNetUserRoomReview];
GO
IF OBJECT_ID(N'[dbo].[FK_RoomTypeRoomReview]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RoomReviews] DROP CONSTRAINT [FK_RoomTypeRoomReview];
GO
IF OBJECT_ID(N'[dbo].[FK_MessageMessage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Messages] DROP CONSTRAINT [FK_MessageMessage];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AspNetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserClaims]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserClaims];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserLogins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserLogins];
GO
IF OBJECT_ID(N'[dbo].[AspNetUserRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUserRoles];
GO
IF OBJECT_ID(N'[dbo].[AspNetUsers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[Hotels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hotels];
GO
IF OBJECT_ID(N'[dbo].[ImageFiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImageFiles];
GO
IF OBJECT_ID(N'[dbo].[RoomTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoomTypes];
GO
IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Messages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Messages];
GO
IF OBJECT_ID(N'[dbo].[Reservations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservations];
GO
IF OBJECT_ID(N'[dbo].[Ratings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ratings];
GO
IF OBJECT_ID(N'[dbo].[RoomReviews]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RoomReviews];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AspNetRoles'
CREATE TABLE [dbo].[AspNetRoles] (
    [Id] nvarchar(128)  NOT NULL,
    [Name] nvarchar(256)  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Discriminator] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUserClaims'
CREATE TABLE [dbo].[AspNetUserClaims] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserId] nvarchar(128)  NOT NULL,
    [ClaimType] nvarchar(max)  NULL,
    [ClaimValue] nvarchar(max)  NULL
);
GO

-- Creating table 'AspNetUserLogins'
CREATE TABLE [dbo].[AspNetUserLogins] (
    [LoginProvider] nvarchar(128)  NOT NULL,
    [ProviderKey] nvarchar(128)  NOT NULL,
    [UserId] nvarchar(128)  NOT NULL
);
GO

-- Creating table 'AspNetUserRoles'
CREATE TABLE [dbo].[AspNetUserRoles] (
    [UserId] nvarchar(128)  NOT NULL,
    [RoleId] nvarchar(128)  NOT NULL,
    [Discriminator] nvarchar(128)  NOT NULL,
    [Role_Id] nvarchar(128)  NULL,
    [ApplicationUser_Id] nvarchar(128)  NULL
);
GO

-- Creating table 'AspNetUsers'
CREATE TABLE [dbo].[AspNetUsers] (
    [Id] nvarchar(128)  NOT NULL,
    [CreditValue] int  NOT NULL,
    [MobileNumber] nvarchar(max)  NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [LockoutEndDateUtc] datetime  NULL,
    [LockoutEnabled] bit  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [UserName] nvarchar(256)  NOT NULL,
    [BirthDate] datetime  NOT NULL
);
GO

-- Creating table 'Hotels'
CREATE TABLE [dbo].[Hotels] (
    [HotelId] int IDENTITY(1,1) NOT NULL,
    [HotelName] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Longtitude] bigint  NOT NULL,
    [Latitude] bigint  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Star] tinyint  NOT NULL,
    [CityId] int  NOT NULL,
    [ServerURL] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ImageFiles'
CREATE TABLE [dbo].[ImageFiles] (
    [ImageFileId] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [RoomTypeId] int  NOT NULL,
    [HotelId] int  NOT NULL
);
GO

-- Creating table 'RoomTypes'
CREATE TABLE [dbo].[RoomTypes] (
    [RoomTypeId] int IDENTITY(1,1) NOT NULL,
    [RoomTypeName] nvarchar(max)  NOT NULL,
    [RoomTypeDescription] nvarchar(max)  NOT NULL,
    [RoomCapacity] int  NOT NULL,
    [Price] bigint  NOT NULL,
    [HotelId] int  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [CityId] int IDENTITY(1,1) NOT NULL,
    [CityName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Messages'
CREATE TABLE [dbo].[Messages] (
    [MessageId] nvarchar(128)  NOT NULL,
    [FromUserId] nvarchar(128)  NOT NULL,
    [ToUserId] nvarchar(128)  NOT NULL,
    [MessageText] nvarchar(max)  NOT NULL,
    [MessageTime] datetime  NOT NULL,
    [IsRead] bit  NOT NULL,
    [ReplyToMessageId] nvarchar(128)  NULL
);
GO

-- Creating table 'Reservations'
CREATE TABLE [dbo].[Reservations] (
    [UserId] nvarchar(128)  NOT NULL,
    [RoomTypeId] int  NOT NULL,
    [ReservationTime] datetime  NOT NULL,
    [CheckInTime] datetime  NOT NULL,
    [CheckOutTime] datetime  NOT NULL,
    [AdultsCount] tinyint  NOT NULL,
    [InfantsCount] tinyint  NOT NULL
);
GO

-- Creating table 'Ratings'
CREATE TABLE [dbo].[Ratings] (
    [UserId] nvarchar(128)  NOT NULL,
    [HotelId] int  NOT NULL,
    [StaffBavior] tinyint  NOT NULL,
    [RoomCleanliness] tinyint  NOT NULL,
    [OutdoorCleanliness] tinyint  NOT NULL,
    [Prestige] tinyint  NOT NULL,
    [FoodQuality] tinyint  NOT NULL,
    [EnvironmentQuality] tinyint  NOT NULL,
    [PriceQualityRatio] tinyint  NOT NULL,
    [Overal] tinyint  NOT NULL
);
GO

-- Creating table 'RoomReviews'
CREATE TABLE [dbo].[RoomReviews] (
    [UserId] nvarchar(128)  NOT NULL,
    [RoomTypeId] int  NOT NULL,
    [ReviewTimestap] datetime  NOT NULL,
    [Review] nvarchar(max)  NOT NULL,
    [UpVotes] int  NOT NULL,
    [DownVotes] int  NOT NULL,
    [IsConfirmed] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AspNetRoles'
ALTER TABLE [dbo].[AspNetRoles]
ADD CONSTRAINT [PK_AspNetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [PK_AspNetUserClaims]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [LoginProvider], [ProviderKey], [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [PK_AspNetUserLogins]
    PRIMARY KEY CLUSTERED ([LoginProvider], [ProviderKey], [UserId] ASC);
GO

-- Creating primary key on [UserId], [RoleId] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [PK_AspNetUserRoles]
    PRIMARY KEY CLUSTERED ([UserId], [RoleId] ASC);
GO

-- Creating primary key on [Id] in table 'AspNetUsers'
ALTER TABLE [dbo].[AspNetUsers]
ADD CONSTRAINT [PK_AspNetUsers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [HotelId] in table 'Hotels'
ALTER TABLE [dbo].[Hotels]
ADD CONSTRAINT [PK_Hotels]
    PRIMARY KEY CLUSTERED ([HotelId] ASC);
GO

-- Creating primary key on [ImageFileId] in table 'ImageFiles'
ALTER TABLE [dbo].[ImageFiles]
ADD CONSTRAINT [PK_ImageFiles]
    PRIMARY KEY CLUSTERED ([ImageFileId] ASC);
GO

-- Creating primary key on [RoomTypeId] in table 'RoomTypes'
ALTER TABLE [dbo].[RoomTypes]
ADD CONSTRAINT [PK_RoomTypes]
    PRIMARY KEY CLUSTERED ([RoomTypeId] ASC);
GO

-- Creating primary key on [CityId] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([CityId] ASC);
GO

-- Creating primary key on [MessageId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [PK_Messages]
    PRIMARY KEY CLUSTERED ([MessageId] ASC);
GO

-- Creating primary key on [ReservationTime], [UserId], [RoomTypeId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [PK_Reservations]
    PRIMARY KEY CLUSTERED ([ReservationTime], [UserId], [RoomTypeId] ASC);
GO

-- Creating primary key on [UserId], [HotelId] in table 'Ratings'
ALTER TABLE [dbo].[Ratings]
ADD CONSTRAINT [PK_Ratings]
    PRIMARY KEY CLUSTERED ([UserId], [HotelId] ASC);
GO

-- Creating primary key on [UserId], [RoomTypeId], [ReviewTimestap] in table 'RoomReviews'
ALTER TABLE [dbo].[RoomReviews]
ADD CONSTRAINT [PK_RoomReviews]
    PRIMARY KEY CLUSTERED ([UserId], [RoomTypeId], [ReviewTimestap] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Role_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_Role_Id]
    FOREIGN KEY ([Role_Id])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserRoles_dbo_AspNetRoles_Role_Id'
CREATE INDEX [IX_FK_dbo_AspNetUserRoles_dbo_AspNetRoles_Role_Id]
ON [dbo].[AspNetUserRoles]
    ([Role_Id]);
GO

-- Creating foreign key on [RoleId] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]
    FOREIGN KEY ([RoleId])
    REFERENCES [dbo].[AspNetRoles]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId'
CREATE INDEX [IX_FK_dbo_AspNetUserRoles_dbo_AspNetRoles_RoleId]
ON [dbo].[AspNetUserRoles]
    ([RoleId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserClaims'
ALTER TABLE [dbo].[AspNetUserClaims]
ADD CONSTRAINT [FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserClaims_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserClaims]
    ([UserId]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserLogins'
ALTER TABLE [dbo].[AspNetUserLogins]
ADD CONSTRAINT [FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId'
CREATE INDEX [IX_FK_dbo_AspNetUserLogins_dbo_AspNetUsers_UserId]
ON [dbo].[AspNetUserLogins]
    ([UserId]);
GO

-- Creating foreign key on [ApplicationUser_Id] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_ApplicationUser_Id]
    FOREIGN KEY ([ApplicationUser_Id])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_dbo_AspNetUserRoles_dbo_AspNetUsers_ApplicationUser_Id'
CREATE INDEX [IX_FK_dbo_AspNetUserRoles_dbo_AspNetUsers_ApplicationUser_Id]
ON [dbo].[AspNetUserRoles]
    ([ApplicationUser_Id]);
GO

-- Creating foreign key on [UserId] in table 'AspNetUserRoles'
ALTER TABLE [dbo].[AspNetUserRoles]
ADD CONSTRAINT [FK_dbo_AspNetUserRoles_dbo_AspNetUsers_UserId]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [HotelId] in table 'ImageFiles'
ALTER TABLE [dbo].[ImageFiles]
ADD CONSTRAINT [FK_ImageFileHotel]
    FOREIGN KEY ([HotelId])
    REFERENCES [dbo].[Hotels]
        ([HotelId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ImageFileHotel'
CREATE INDEX [IX_FK_ImageFileHotel]
ON [dbo].[ImageFiles]
    ([HotelId]);
GO

-- Creating foreign key on [HotelId] in table 'RoomTypes'
ALTER TABLE [dbo].[RoomTypes]
ADD CONSTRAINT [FK_RoomTypeHotel]
    FOREIGN KEY ([HotelId])
    REFERENCES [dbo].[Hotels]
        ([HotelId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoomTypeHotel'
CREATE INDEX [IX_FK_RoomTypeHotel]
ON [dbo].[RoomTypes]
    ([HotelId]);
GO

-- Creating foreign key on [RoomTypeId] in table 'ImageFiles'
ALTER TABLE [dbo].[ImageFiles]
ADD CONSTRAINT [FK_RoomTypeImageFile]
    FOREIGN KEY ([RoomTypeId])
    REFERENCES [dbo].[RoomTypes]
        ([RoomTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoomTypeImageFile'
CREATE INDEX [IX_FK_RoomTypeImageFile]
ON [dbo].[ImageFiles]
    ([RoomTypeId]);
GO

-- Creating foreign key on [CityId] in table 'Hotels'
ALTER TABLE [dbo].[Hotels]
ADD CONSTRAINT [FK_HOTEL_PK_CITY]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([CityId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HOTEL_PK_CITY'
CREATE INDEX [IX_FK_HOTEL_PK_CITY]
ON [dbo].[Hotels]
    ([CityId]);
GO

-- Creating foreign key on [UserId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_AspNetUserReservation]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AspNetUserReservation'
CREATE INDEX [IX_FK_AspNetUserReservation]
ON [dbo].[Reservations]
    ([UserId]);
GO

-- Creating foreign key on [ToUserId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_ToUserID_PK_UserId]
    FOREIGN KEY ([ToUserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ToUserID_PK_UserId'
CREATE INDEX [IX_FK_ToUserID_PK_UserId]
ON [dbo].[Messages]
    ([ToUserId]);
GO

-- Creating foreign key on [FromUserId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_FromUserID_PK_UserID]
    FOREIGN KEY ([FromUserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FromUserID_PK_UserID'
CREATE INDEX [IX_FK_FromUserID_PK_UserID]
ON [dbo].[Messages]
    ([FromUserId]);
GO

-- Creating foreign key on [RoomTypeId] in table 'Reservations'
ALTER TABLE [dbo].[Reservations]
ADD CONSTRAINT [FK_PK_RoomType_FK_Reservation]
    FOREIGN KEY ([RoomTypeId])
    REFERENCES [dbo].[RoomTypes]
        ([RoomTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PK_RoomType_FK_Reservation'
CREATE INDEX [IX_FK_PK_RoomType_FK_Reservation]
ON [dbo].[Reservations]
    ([RoomTypeId]);
GO

-- Creating foreign key on [HotelId] in table 'Ratings'
ALTER TABLE [dbo].[Ratings]
ADD CONSTRAINT [FK_Rating_PK_Hotel]
    FOREIGN KEY ([HotelId])
    REFERENCES [dbo].[Hotels]
        ([HotelId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Rating_PK_Hotel'
CREATE INDEX [IX_FK_Rating_PK_Hotel]
ON [dbo].[Ratings]
    ([HotelId]);
GO

-- Creating foreign key on [UserId] in table 'Ratings'
ALTER TABLE [dbo].[Ratings]
ADD CONSTRAINT [FK_Rating_PK_AspNetUser]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UserId] in table 'RoomReviews'
ALTER TABLE [dbo].[RoomReviews]
ADD CONSTRAINT [FK_AspNetUserRoomReview]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[AspNetUsers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RoomTypeId] in table 'RoomReviews'
ALTER TABLE [dbo].[RoomReviews]
ADD CONSTRAINT [FK_RoomTypeRoomReview]
    FOREIGN KEY ([RoomTypeId])
    REFERENCES [dbo].[RoomTypes]
        ([RoomTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoomTypeRoomReview'
CREATE INDEX [IX_FK_RoomTypeRoomReview]
ON [dbo].[RoomReviews]
    ([RoomTypeId]);
GO

-- Creating foreign key on [ReplyToMessageId] in table 'Messages'
ALTER TABLE [dbo].[Messages]
ADD CONSTRAINT [FK_MessageMessage]
    FOREIGN KEY ([ReplyToMessageId])
    REFERENCES [dbo].[Messages]
        ([MessageId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MessageMessage'
CREATE INDEX [IX_FK_MessageMessage]
ON [dbo].[Messages]
    ([ReplyToMessageId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------