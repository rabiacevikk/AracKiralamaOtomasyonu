USE [master]
GO
/****** Object:  Database [Arac_Kiralama]    Script Date: 25.02.2021 14:37:45 ******/
CREATE DATABASE [Arac_Kiralama]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Arac_Kiralama', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Arac_Kiralama.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Arac_Kiralama_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Arac_Kiralama_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Arac_Kiralama] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Arac_Kiralama].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Arac_Kiralama] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET ARITHABORT OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Arac_Kiralama] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Arac_Kiralama] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Arac_Kiralama] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Arac_Kiralama] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET RECOVERY FULL 
GO
ALTER DATABASE [Arac_Kiralama] SET  MULTI_USER 
GO
ALTER DATABASE [Arac_Kiralama] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Arac_Kiralama] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Arac_Kiralama] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Arac_Kiralama] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Arac_Kiralama] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Arac_Kiralama] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Arac_Kiralama', N'ON'
GO
ALTER DATABASE [Arac_Kiralama] SET QUERY_STORE = OFF
GO
USE [Arac_Kiralama]
GO
/****** Object:  Table [dbo].[arac]    Script Date: 25.02.2021 14:37:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[arac](
	[plaka] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[seri] [nvarchar](50) NOT NULL,
	[yil] [nvarchar](50) NOT NULL,
	[renk] [nvarchar](50) NOT NULL,
	[km] [nvarchar](50) NOT NULL,
	[yakit] [nvarchar](50) NOT NULL,
	[kiraucreti] [int] NOT NULL,
	[tarih] [nvarchar](50) NOT NULL,
	[durumu] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[musteri]    Script Date: 25.02.2021 14:37:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[musteri](
	[tc] [nvarchar](50) NOT NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[telefon] [nvarchar](50) NOT NULL,
	[adres] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[satis]    Script Date: 25.02.2021 14:37:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[satis](
	[tc] [nvarchar](50) NULL,
	[adsoyad] [nvarchar](50) NOT NULL,
	[plaka] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[seri] [nvarchar](50) NOT NULL,
	[yil] [nvarchar](50) NOT NULL,
	[renk] [nvarchar](50) NOT NULL,
	[gun] [int] NOT NULL,
	[fiyat] [int] NOT NULL,
	[tutar] [int] NOT NULL,
	[tarih1] [nvarchar](50) NOT NULL,
	[tarih2] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sozlesme]    Script Date: 25.02.2021 14:37:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sozlesme](
	[tc] [nvarchar](50) NULL,
	[adsoyad] [nvarchar](50) NULL,
	[telefon] [nvarchar](50) NULL,
	[ehliyetno] [nvarchar](50) NULL,
	[e_tarih] [nvarchar](50) NOT NULL,
	[e_yer] [nvarchar](50) NOT NULL,
	[plaka] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[seri] [nvarchar](50) NOT NULL,
	[yil] [nvarchar](50) NOT NULL,
	[renk] [nvarchar](50) NOT NULL,
	[kirasekli] [nvarchar](50) NOT NULL,
	[kiraucreti] [int] NOT NULL,
	[gun] [int] NOT NULL,
	[tutar] [int] NOT NULL,
	[ctarih] [nvarchar](50) NOT NULL,
	[dtarih] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[arac] ([plaka], [marka], [seri], [yil], [renk], [km], [yakit], [kiraucreti], [tarih], [durumu]) VALUES (N'34R500', N'Renault', N'Clio', N'2017', N'Turuncu', N'Turuncu', N'Dizel', 110, N'23.02.2021 19:33:48', N'BOŞ')
INSERT [dbo].[arac] ([plaka], [marka], [seri], [yil], [renk], [km], [yakit], [kiraucreti], [tarih], [durumu]) VALUES (N'38K600', N'Fiat', N'Linea', N'2016', N'Siyah', N'Siyah', N'Benzin', 115, N'23.02.2021 19:33:35', N'DOLU')
INSERT [dbo].[arac] ([plaka], [marka], [seri], [yil], [renk], [km], [yakit], [kiraucreti], [tarih], [durumu]) VALUES (N'34F211', N'Renault', N'Clio', N'2013', N'Beyaz', N'9000', N'Benzin+Lpg', 110, N'23.02.2021 19:33:23', N'BOŞ')
INSERT [dbo].[arac] ([plaka], [marka], [seri], [yil], [renk], [km], [yakit], [kiraucreti], [tarih], [durumu]) VALUES (N'80E345', N'Renault', N'Megane', N'2010', N'Yeşil', N'7000', N'Benzin', 110, N'23.02.2021 20:09:53', N'DOLU')
INSERT [dbo].[arac] ([plaka], [marka], [seri], [yil], [renk], [km], [yakit], [kiraucreti], [tarih], [durumu]) VALUES (N'34E123', N'Opel', N'Corsa', N'2007', N'Gri', N'Gri', N'Benzin', 130, N'25.02.2021 14:08:05', N'BOŞ')
GO
INSERT [dbo].[musteri] ([tc], [adsoyad], [telefon], [adres], [email]) VALUES (N'150', N'Rabia Çevik', N'5317260234', N'İstanbul', N'rcevik7@hotmail.com')
INSERT [dbo].[musteri] ([tc], [adsoyad], [telefon], [adres], [email]) VALUES (N'34343444333', N'Deniz Kurtulmuş', N'5387909898', N'Kahramanmaraş', N'deniz595@hotmail.com')
INSERT [dbo].[musteri] ([tc], [adsoyad], [telefon], [adres], [email]) VALUES (N'11', N'Mehmet Demir', N'5380000098', N'Adıyaman', N'mehmet567@hotmail.com')
INSERT [dbo].[musteri] ([tc], [adsoyad], [telefon], [adres], [email]) VALUES (N'1', N'Elanur Yıldırım', N'5443909898', N'Gelibolu', N'ela_877@hotmail.com')
GO
INSERT [dbo].[satis] ([tc], [adsoyad], [plaka], [marka], [seri], [yil], [renk], [gun], [fiyat], [tutar], [tarih1], [tarih2]) VALUES (N'150', N'Rabia Çevik', N'34R500', N'Renault', N'Clio', N'2017', N'Turuncu', 0, 220, 0, N'25.02.2021', N'25.02.2021')
INSERT [dbo].[satis] ([tc], [adsoyad], [plaka], [marka], [seri], [yil], [renk], [gun], [fiyat], [tutar], [tarih1], [tarih2]) VALUES (N'1', N'Elanur Yıldırım', N'34R500', N'Renault', N'Clio', N'2017', N'Turuncu', 0, 330, 0, N'25.02.2021', N'25.02.2021')
INSERT [dbo].[satis] ([tc], [adsoyad], [plaka], [marka], [seri], [yil], [renk], [gun], [fiyat], [tutar], [tarih1], [tarih2]) VALUES (N'150', N'Rabia Çevik', N'34R500', N'Renault', N'Clio', N'2017', N'Turuncu', 0, 110, 0, N'25.02.2021', N'25.02.2021')
INSERT [dbo].[satis] ([tc], [adsoyad], [plaka], [marka], [seri], [yil], [renk], [gun], [fiyat], [tutar], [tarih1], [tarih2]) VALUES (N'11', N'Mehmet Demir', N'34R500', N'Renault', N'Clio', N'2017', N'Turuncu', 0, 330, 0, N'25.02.2021', N'25.02.2021')
INSERT [dbo].[satis] ([tc], [adsoyad], [plaka], [marka], [seri], [yil], [renk], [gun], [fiyat], [tutar], [tarih1], [tarih2]) VALUES (N'11', N'Mehmet Demir', N'34R500', N'Renault', N'Clio', N'2017', N'Turuncu', 0, 220, 0, N'25.02.2021', N'27.02.2021')
INSERT [dbo].[satis] ([tc], [adsoyad], [plaka], [marka], [seri], [yil], [renk], [gun], [fiyat], [tutar], [tarih1], [tarih2]) VALUES (N'11', N'Mehmet Demir', N'34F211', N'Renault', N'Clio', N'2013', N'Beyaz', 3, 220, 660, N'25.02.2021', N'28.02.2021')
INSERT [dbo].[satis] ([tc], [adsoyad], [plaka], [marka], [seri], [yil], [renk], [gun], [fiyat], [tutar], [tarih1], [tarih2]) VALUES (N'34343444333', N'Deniz Kurtulmuş', N'34R500', N'Renault', N'Clio', N'2017', N'Turuncu', 3, 220, 660, N'25.02.2021', N'28.02.2021')
GO
USE [master]
GO
ALTER DATABASE [Arac_Kiralama] SET  READ_WRITE 
GO
