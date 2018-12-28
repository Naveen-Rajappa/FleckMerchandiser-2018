USE [FleckMerchandiserDb]
GO

/****** Object: Table [dbo].[Users] Script Date: 12/28/2018 3:17:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
	[Description]  NVARCHAR (MAX) NULL,
    [DefaultImageUrl]  NVARCHAR (100) NULL,
    [Name] NVARCHAR (100) NULL,
    [Price]  DECIMAL (10) NOT NULL,
    [Status]  INT NOT NULL,
);


