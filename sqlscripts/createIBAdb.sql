USE [master]
GO

/****** Object:  Database [IBA]    Script Date: 18/09/2021 2:44:55 am ******/
CREATE DATABASE [IBA] ON  PRIMARY 
( NAME = N'IBA', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\IBA.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IBA_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\IBA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IBA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [IBA] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [IBA] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [IBA] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [IBA] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [IBA] SET ARITHABORT OFF 
GO

ALTER DATABASE [IBA] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [IBA] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [IBA] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [IBA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [IBA] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [IBA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [IBA] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [IBA] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [IBA] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [IBA] SET  DISABLE_BROKER 
GO

ALTER DATABASE [IBA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [IBA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [IBA] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [IBA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [IBA] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [IBA] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [IBA] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [IBA] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [IBA] SET  MULTI_USER 
GO

ALTER DATABASE [IBA] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [IBA] SET DB_CHAINING OFF 
GO

ALTER DATABASE [IBA] SET  READ_WRITE 
GO


