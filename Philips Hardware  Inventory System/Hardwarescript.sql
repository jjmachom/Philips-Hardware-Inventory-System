USE [master]
GO
/****** Object:  Database [Hardware]    Script Date: 4/25/2020 9:59:24 AM ******/
CREATE DATABASE [Hardware]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hardware', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Hardware.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hardware_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Hardware_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Hardware] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hardware].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hardware] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hardware] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hardware] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hardware] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hardware] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hardware] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hardware] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hardware] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hardware] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hardware] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hardware] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hardware] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hardware] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hardware] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hardware] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hardware] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hardware] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hardware] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hardware] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hardware] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hardware] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hardware] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hardware] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hardware] SET  MULTI_USER 
GO
ALTER DATABASE [Hardware] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hardware] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hardware] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hardware] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hardware] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hardware] SET QUERY_STORE = OFF
GO
USE [Hardware]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 4/25/2020 9:59:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[cusId] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[Telephone] [varchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[cusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/25/2020 9:59:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[empid] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](50) NULL,
	[Last_Name] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [nchar](10) NULL,
	[level] [nchar](10) NULL,
	[Active] [nchar](10) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventories]    Script Date: 4/25/2020 9:59:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventories](
	[invenid] [int] IDENTITY(1,1) NOT NULL,
	[item] [varchar](50) NULL,
	[Quality] [int] NOT NULL,
	[supplierid] [int] NULL,
	[cost] [decimal](19, 4) NULL,
	[price] [decimal](19, 4) NULL,
 CONSTRAINT [PK_Inventories] PRIMARY KEY CLUSTERED 
(
	[invenid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 4/25/2020 9:59:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Supplier_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inventories]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Supplier] FOREIGN KEY([invenid])
REFERENCES [dbo].[Suppliers] ([id])
GO
ALTER TABLE [dbo].[Inventories] CHECK CONSTRAINT [FK_Inventory_Supplier]
GO
USE [master]
GO
ALTER DATABASE [Hardware] SET  READ_WRITE 
GO
