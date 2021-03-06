/*
USE [master]
GO

/****** Object:  Database [Widget]    Script Date: 05/12/2020 09:30:08 ******/
DROP DATABASE [Widget]
GO

/****** Object:  Database [Widget]    Script Date: 05/12/2020 09:30:08 ******/
CREATE DATABASE [Widget]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Widget', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Widget.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Widget_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Widget.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Widget].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Widget] SET ANSI_NULL_DEFAULT ON 
GO

ALTER DATABASE [Widget] SET ANSI_NULLS ON 
GO

ALTER DATABASE [Widget] SET ANSI_PADDING ON 
GO

ALTER DATABASE [Widget] SET ANSI_WARNINGS ON 
GO

ALTER DATABASE [Widget] SET ARITHABORT ON 
GO

ALTER DATABASE [Widget] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Widget] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Widget] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Widget] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Widget] SET CURSOR_DEFAULT  LOCAL 
GO

ALTER DATABASE [Widget] SET CONCAT_NULL_YIELDS_NULL ON 
GO

ALTER DATABASE [Widget] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Widget] SET QUOTED_IDENTIFIER ON 
GO

ALTER DATABASE [Widget] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Widget] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Widget] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Widget] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Widget] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Widget] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Widget] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Widget] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Widget] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Widget] SET RECOVERY FULL 
GO

ALTER DATABASE [Widget] SET  MULTI_USER 
GO

ALTER DATABASE [Widget] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Widget] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Widget] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Widget] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Widget] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Widget] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Widget] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Widget] SET  READ_WRITE 
GO
*/

