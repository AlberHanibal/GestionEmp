USE [master]
GO

/****** Object:  Database [LIBRERIA]    Script Date: 17/11/2023 12:18:46 ******/
CREATE DATABASE [LIBRERIA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LIBRERIA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\LIBRERIA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LIBRERIA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\LIBRERIA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LIBRERIA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [LIBRERIA] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [LIBRERIA] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [LIBRERIA] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [LIBRERIA] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [LIBRERIA] SET ARITHABORT OFF 
GO

ALTER DATABASE [LIBRERIA] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [LIBRERIA] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [LIBRERIA] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [LIBRERIA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [LIBRERIA] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [LIBRERIA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [LIBRERIA] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [LIBRERIA] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [LIBRERIA] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [LIBRERIA] SET  DISABLE_BROKER 
GO

ALTER DATABASE [LIBRERIA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [LIBRERIA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [LIBRERIA] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [LIBRERIA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [LIBRERIA] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [LIBRERIA] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [LIBRERIA] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [LIBRERIA] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [LIBRERIA] SET  MULTI_USER 
GO

ALTER DATABASE [LIBRERIA] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [LIBRERIA] SET DB_CHAINING OFF 
GO

ALTER DATABASE [LIBRERIA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [LIBRERIA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [LIBRERIA] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [LIBRERIA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [LIBRERIA] SET QUERY_STORE = ON
GO

ALTER DATABASE [LIBRERIA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [LIBRERIA] SET  READ_WRITE 
GO

