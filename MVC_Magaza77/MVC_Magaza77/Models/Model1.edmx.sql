
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/02/2023 15:13:06
-- Generated from EDMX file: C:\Users\ASUS\Desktop\MVC\MVC_Magaza77\MVC_Magaza77\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MVC_Magaza77];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'YetkililerSet'
CREATE TABLE [dbo].[YetkililerSet] (
    [YetkiliID] int IDENTITY(1,1) NOT NULL,
    [YetkiliAdi] nvarchar(max)  NOT NULL,
    [Sifre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UrunlerSet'
CREATE TABLE [dbo].[UrunlerSet] (
    [UrunID] int IDENTITY(1,1) NOT NULL,
    [UrunAdi] nvarchar(max)  NOT NULL,
    [Kategori] nvarchar(max)  NOT NULL,
    [Fiyati] int  NOT NULL,
    [Adet] int  NOT NULL,
    [Aciklama] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [YetkiliID] in table 'YetkililerSet'
ALTER TABLE [dbo].[YetkililerSet]
ADD CONSTRAINT [PK_YetkililerSet]
    PRIMARY KEY CLUSTERED ([YetkiliID] ASC);
GO

-- Creating primary key on [UrunID] in table 'UrunlerSet'
ALTER TABLE [dbo].[UrunlerSet]
ADD CONSTRAINT [PK_UrunlerSet]
    PRIMARY KEY CLUSTERED ([UrunID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------