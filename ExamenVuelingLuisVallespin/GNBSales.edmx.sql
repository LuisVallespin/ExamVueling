
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/27/2020 13:15:53
-- Generated from EDMX file: C:\Users\lvall\source\repos\ExamenVuelingLuisVallespin\ExamenVuelingLuisVallespin\GNBSales.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GNBSales];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[RateSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RateSet];
GO
IF OBJECT_ID(N'[dbo].[TransactionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransactionSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'RateSet'
CREATE TABLE [dbo].[RateSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [From] nvarchar(max)  NOT NULL,
    [To] nvarchar(max)  NOT NULL,
    [RateValue] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'TransactionSet'
CREATE TABLE [dbo].[TransactionSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Sku] nvarchar(max)  NOT NULL,
    [Amount] decimal(18,0)  NOT NULL,
    [Currency] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'RateSet'
ALTER TABLE [dbo].[RateSet]
ADD CONSTRAINT [PK_RateSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TransactionSet'
ALTER TABLE [dbo].[TransactionSet]
ADD CONSTRAINT [PK_TransactionSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------