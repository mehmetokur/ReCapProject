USE [RentACar]
GO

/****** Object: Table [dbo].[Customers] Script Date: 11.02.2021 21:09:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers] (
    [Id]      INT          NOT NULL,
	[UserId]      INT          NOT NULL,
    [CompanyName] VARCHAR (50) NOT NULL
);


