CREATE DATABASE TEST

CREATE TABLE [dbo].[Staff] (
    [IdStaff]       NVARCHAR (50)  NOT NULL,
    [Name]          NVARCHAR (100) NOT NULL,
    [DateOfBirth]   DATE           NOT NULL,
    [Sex]           NVARCHAR (50)  NOT NULL,
    [StaffType]     NVARCHAR (50)  NOT NULL,
    [IDCard]        NVARCHAR (100) NOT NULL,
    [Address]       NVARCHAR (300) NOT NULL,
    [Phone]         NVARCHAR (50)  NOT NULL,
    [Email]         NVARCHAR (50)  NOT NULL,
    [DateStartWork] DATE           NOT NULL,
    CONSTRAINT [PK_Staff] PRIMARY KEY ([IdStaff] ASC),
);

CREATE TABLE [dbo].[Account] (
    [Id] INT NOT NULL IDENTITY(1,1),
    [UserName] NVARCHAR (300) NOT NULL,
    [PassWord] NVARCHAR (300) NOT NULL,
    [IdStaff]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY ([Id])
);

CREATE TABLE [dbo].[Room] (
    [RoomName]   NVARCHAR (50) NOT NULL,
    [Type]       NVARCHAR (50) NOT NULL,
    [StatusRoom] NVARCHAR (50) NOT NULL,
    [Price]      INT           NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY ([RoomName]),
    CONSTRAINT [FK_Room_RoomType] FOREIGN KEY ([Type]) REFERENCES RoomType([Type])
);

CREATE TABLE [dbo].[RoomType] (
    [Type]        NVARCHAR (50)	 NOT NULL,
    [Price]       INT            NOT NULL,
    [LimitPeople] INT            NOT NULL,
    CONSTRAINT [PK_RoomType] PRIMARY KEY ([Type])
);

CREATE TABLE [dbo].[Service] (
    [ServiceName] NVARCHAR (100) NOT NULL,
    [ServiceType] NVARCHAR (100) NOT NULL,
    [Price]       INT            NOT NULL,
    CONSTRAINT [PK_Service] PRIMARY KEY ([ServiceName]),
);

CREATE TABLE [dbo].[ServiceType] (
    [Id] INT NOT NULL IDENTITY(1,1),
    [ServiceType] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_ServiceType] PRIMARY KEY CLUSTERED ([Id] ASC),
);

CREATE TABLE [dbo].[Regulations] (
    [Id]			INT NOT NULL IDENTITY(1,1),
    [RegulationsName] NVARCHAR (200) NOT NULL, 
    [Coefficient]	FLOAT,
    [Description]   NVARCHAR (1000) NOT NULL, 
    CONSTRAINT [PK_Regulations] PRIMARY KEY ([Id] ASC),
);

CREATE TABLE [dbo].[Customer] (
    [IdCustomer]  NVARCHAR (50)  NOT NULL,
    [Name]        NVARCHAR (300) NOT NULL,
    [DateOfBirth] DATE           NOT NULL,
    [Sex]         NVARCHAR (50)  NOT NULL,
    [IdCard]      INT            NOT NULL,
    [Phone]       NVARCHAR (50)  NOT NULL,
    [Nationality] NVARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([IdCustomer] ASC)
);

CREATE TABLE [dbo].[BookRoom] (
    [IdBook]       NVARCHAR (50) NOT NULL,
    [IdCustomer]   NVARCHAR (50) NOT NULL, 
    [RoomName]     NVARCHAR(50) NOT NULL,
    [DateCheckIn]  DATE NOT NULL, 
    [DateCheckOut] DATE NOT NULL, 
    CONSTRAINT [PK_BookRoom] PRIMARY KEY CLUSTERED ([IdBook] ASC),
    CONSTRAINT [FK_BookRoom_Customer] FOREIGN KEY ([IdCustomer]) REFERENCES [dbo].[Customer] ([IdCustomer]),
    CONSTRAINT [FK_BookRoom_Room] FOREIGN KEY ([RoomName]) REFERENCES [dbo].[Room] ([RoomName])
);

CREATE TABLE [dbo].[Bill](
	[Id] INT NOT NULL IDENTITY(1,1),
	[IdBook] NVARCHAR (50) NOT NULL,
	[RoomPrice] INT NOT NULL,
	[ServicePrice] INT NOT NULL,
	[Surcharge] FLOAT NOT NULL,
	[Discount] INT NOT NULL,
	[TotalPrice] INT NOT NULL,
	[DateCreated] DATE NOT NULL,
	[CreateBy] NVARCHAR (50) NOT NULL,
	CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED ([Id] ASC),
);

CREATE TABLE [dbo].[BillDetails](
	[Id] INT NOT NULL IDENTITY(1,1),
	[IdBook] NVARCHAR (50) NOT NULL,
	[ServiceName] NVARCHAR (100) NOT NULL,
	[Count] INT NOT NULL,
	[Price] INT NOT NULL,
	[TotalPrice] INT NOT NULL,
);

/*Test*/
DROP TABLE Bill
SELECT * FROM BookRoom
SELECT * FROM Bill
Delete FROM Bill WHere IdBook = 'WQGF0VAFF9ZM'
SELECT Count FROM BillDetails WHERE ServiceName = N'Sấy khô'
DELETE FROM BillDetails WHERE IdBook = ''
SELECT ID, SUM([RoomPrice]) AS SumPriceRevenue, SUM([ServicePrice]) AS SumServiceRevenue FROM Bill GROUP BY ID
SELECT SUM([TotalPrice]) AS Sum FROM Bill WHERE MONTH(DateCreated) = 6 AND YEAR(DateCreated) = 2023
UPDATE [BillDetails] SET  [TotalPrice] = [Price]*[Count] WHERE [IdBook] = 'WQGF0VAFF9ZM' AND [ServiceName] = N'Giặt kèm sấy khô'