USE [FleckMerchandiserDb]
GO

/****** Object: Table [dbo].[Users] Script Date: 12/28/2018 3:16:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [UserId]    INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (100) NULL,
    [LastName]  NVARCHAR (100) NULL
);


