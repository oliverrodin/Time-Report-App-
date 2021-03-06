USE [master]
GO
/****** Object:  Database [TimeReport]    Script Date: 12/20/2021 12:04:01 AM ******/
CREATE DATABASE [TimeReport]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TimeReport', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TimeReport.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TimeReport_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TimeReport_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TimeReport] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TimeReport].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TimeReport] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TimeReport] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TimeReport] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TimeReport] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TimeReport] SET ARITHABORT OFF 
GO
ALTER DATABASE [TimeReport] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TimeReport] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TimeReport] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TimeReport] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TimeReport] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TimeReport] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TimeReport] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TimeReport] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TimeReport] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TimeReport] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TimeReport] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TimeReport] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TimeReport] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TimeReport] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TimeReport] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TimeReport] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TimeReport] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TimeReport] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TimeReport] SET  MULTI_USER 
GO
ALTER DATABASE [TimeReport] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TimeReport] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TimeReport] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TimeReport] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TimeReport] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TimeReport] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TimeReport] SET QUERY_STORE = OFF
GO
USE [TimeReport]
GO
/****** Object:  User [Oliver]    Script Date: 12/20/2021 12:04:02 AM ******/
CREATE USER [Oliver] FOR LOGIN [Oliver] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[OnlyFirstNameAndLastname]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[OnlyFirstNameAndLastname] AS
SELECT FirstName, LastName
FROM dbo.Employees
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectID] [int] IDENTITY(10001,1) NOT NULL,
	[ProjectName] [nvarchar](500) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeReports]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeReports](
	[ReportID] [int] IDENTITY(1,1) NOT NULL,
	[Week] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ProjectID] [int] NOT NULL,
	[Hours] [int] NOT NULL,
 CONSTRAINT [PK_TimeReports] PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TimeReports]  WITH CHECK ADD  CONSTRAINT [FK_TimeReports_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TimeReports] CHECK CONSTRAINT [FK_TimeReports_Employees]
GO
ALTER TABLE [dbo].[TimeReports]  WITH CHECK ADD  CONSTRAINT [FK_TimeReports_Projects] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Projects] ([ProjectID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TimeReports] CHECK CONSTRAINT [FK_TimeReports_Projects]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeID]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEmployeeID]
@Employee nvarchar(255)
AS

SELECT EmployeeId
FROM dbo.Employees
WHERE FirstName + ' ' + LastName = @Employee
GO
/****** Object:  StoredProcedure [dbo].[GetEmployees]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetEmployees]
AS

SELECT *
FROM dbo.Employees
GO
/****** Object:  StoredProcedure [dbo].[GetProjectId]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[GetProjectId]
@ProjectName nvarchar(255)

as

Select ProjectID
From dbo.Projects
Where ProjectName = @ProjectName
GO
/****** Object:  StoredProcedure [dbo].[GetProjects]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetProjects]
AS

SELECT *
FROM dbo.Projects
GO
/****** Object:  StoredProcedure [dbo].[SaveReport]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SaveReport]
@Week int,
@EmployeeID int,
@ProjectID int,
@Hours int

AS

INSERT INTO dbo.TimeReports VALUES
(@Week, @EmployeeID, @ProjectID, @Hours)
GO
/****** Object:  StoredProcedure [dbo].[ShowSpecificEmployeeReports]    Script Date: 12/20/2021 12:04:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ShowSpecificEmployeeReports]
@EmployeeID int

AS

SELECT [Week], [Hours], ProjectName
FROM dbo.TimeReports
FULL OUTER JOIN dbo.Projects
	ON TimeReports.ProjectID = Projects.ProjectID
WHERE EmployeeID = @EmployeeID
GO
USE [master]
GO
ALTER DATABASE [TimeReport] SET  READ_WRITE 
GO
