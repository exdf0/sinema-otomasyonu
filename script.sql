USE [master]
GO
/****** Object:  Database [SinemaOtomasyonu]    Script Date: 4/8/2022 3:44:32 PM ******/
CREATE DATABASE [SinemaOtomasyonu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SinemaOtomasyonu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SinemaOtomasyonu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SinemaOtomasyonu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\SinemaOtomasyonu_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SinemaOtomasyonu] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SinemaOtomasyonu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SinemaOtomasyonu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET ARITHABORT OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SinemaOtomasyonu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SinemaOtomasyonu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SinemaOtomasyonu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SinemaOtomasyonu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SinemaOtomasyonu] SET  MULTI_USER 
GO
ALTER DATABASE [SinemaOtomasyonu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SinemaOtomasyonu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SinemaOtomasyonu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SinemaOtomasyonu] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SinemaOtomasyonu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SinemaOtomasyonu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SinemaOtomasyonu] SET QUERY_STORE = OFF
GO
USE [SinemaOtomasyonu]
GO
/****** Object:  Table [dbo].[admins]    Script Date: 4/8/2022 3:44:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admins](
	[k_adi] [nchar](16) NOT NULL,
	[sifre] [nchar](16) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Film_Bilgiler]    Script Date: 4/8/2022 3:44:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film_Bilgiler](
	[FilmId] [int] IDENTITY(1,1) NOT NULL,
	[FilmAdi] [varchar](50) NOT NULL,
	[Yonetmen] [varchar](250) NULL,
	[FilmTuru] [varchar](50) NULL,
	[FilmSuresi] [varchar](50) NULL,
	[tarih] [varchar](50) NULL,
	[YapimYili] [varchar](50) NULL,
	[Resim] [varchar](250) NULL,
 CONSTRAINT [PK_Film_Bilgiler] PRIMARY KEY CLUSTERED 
(
	[FilmAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salon_Bilgileri]    Script Date: 4/8/2022 3:44:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon_Bilgileri](
	[SalonId] [int] IDENTITY(1,1) NOT NULL,
	[SalonAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Salon_Bilgileri] PRIMARY KEY CLUSTERED 
(
	[SalonAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satis_Bilgileri]    Script Date: 4/8/2022 3:44:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satis_Bilgileri](
	[SatisId] [int] IDENTITY(1,1) NOT NULL,
	[KoltukNo] [varchar](50) NULL,
	[SalonAdi] [varchar](50) NULL,
	[FilmAdi] [varchar](50) NULL,
	[Tarih] [varchar](50) NULL,
	[Saat] [varchar](50) NULL,
	[Ad] [varchar](50) NULL,
	[Soyad] [varchar](50) NULL,
	[Ucret] [varchar](50) NULL,
	[SatisTarihi] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seans_Bilgileri]    Script Date: 4/8/2022 3:44:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seans_Bilgileri](
	[SeansId] [int] IDENTITY(1,1) NOT NULL,
	[FilmAdi] [varchar](50) NULL,
	[SalonAdi] [varchar](50) NULL,
	[Tarih] [varchar](50) NULL,
	[Seans] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[admins] ([k_adi], [sifre]) VALUES (N'admin           ', N'admin           ')
INSERT [dbo].[admins] ([k_adi], [sifre]) VALUES (N'hakan           ', N'123456          ')
INSERT [dbo].[admins] ([k_adi], [sifre]) VALUES (N'irem            ', N'123456          ')
GO
SET IDENTITY_INSERT [dbo].[Film_Bilgiler] ON 

INSERT [dbo].[Film_Bilgiler] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (1002, N'Alice in Borderland', N'Kimi Border', N'korku', N'1 saat 15 dakika', N'4/8/2022', N'2022', N'C:\Users\Hakan Arslan\Desktop\tasarımlar\exdf\1_moRojY4kK_7xVC0JLvejLg.jpeg')
INSERT [dbo].[Film_Bilgiler] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (4, N'Batman', N'Hakan Arslan', N'aksiyon', N'1 saat 15 dakika', N'4/7/2022', N'2022', N'C:\Users\Hakan Arslan\Desktop\tasarımlar\c#\stranger_.jpg')
INSERT [dbo].[Film_Bilgiler] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (3, N'Stranger Things', N'Hakan & İrem', N'korku', N'3 saat 15 dakika', N'4/7/2022', N'2022', N'C:\Users\Hakan Arslan\Desktop\tasarımlar\c#\stranger_.jpg')
INSERT [dbo].[Film_Bilgiler] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (2, N'Stranger Things The Movie', N'Hakan Arslan & İremnur Çakıralp', N'korku', N'2 saat 30 dakika', N'4/7/2022', N'2022', N'C:\Users\Hakan Arslan\Desktop\tasarımlar\c#\stranger_.jpg')
INSERT [dbo].[Film_Bilgiler] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (5, N'Superman', N'Hakan Arslan', N'aksiyon', N'2 saat 15 dakika', N'4/8/2022', N'2022', N'C:\Users\Hakan Arslan\Desktop\tasarımlar\c#\stranger_.jpg')
INSERT [dbo].[Film_Bilgiler] ([FilmId], [FilmAdi], [Yonetmen], [FilmTuru], [FilmSuresi], [tarih], [YapimYili], [Resim]) VALUES (1, N'Test Film', N'Hakan Arslan', N'korku', N'3 saat 15 dakika', N'4/2/2022', N'2004', N'C:\Users\Hakan Arslan\Desktop\tasarımlar\exdf\original.gif')
SET IDENTITY_INSERT [dbo].[Film_Bilgiler] OFF
GO
SET IDENTITY_INSERT [dbo].[Salon_Bilgileri] ON 

INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (1, N'salon 1')
INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (3, N'salon 2')
INSERT [dbo].[Salon_Bilgileri] ([SalonId], [SalonAdi]) VALUES (5, N'salon 3')
SET IDENTITY_INSERT [dbo].[Salon_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Satis_Bilgileri] ON 

INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (1, N'2', N'salon 1', N'Test Film', N'22/03/2022', N'12.33', N'Hakan', N'Arslan', N'22', N'4/6/2022')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (2, N'38', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'hakan', N'arslan', N'3', N'4/7/2022 2:22:31 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (3, N'42', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'irem nur', N'arslan', N'2', N'4/7/2022 2:24:36 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (4, N'29', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'Hakan', N'Arslan', N'45', N'4/7/2022 2:41:17 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (5, N'23', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'Hakan', N'Baba', N'45', N'4/7/2022 2:41:53 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (6, N'47', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'hakan', N'dede', N'45', N'4/7/2022 2:43:45 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (7, N'46', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'Hakan', N'Arslan', N'43', N'4/7/2022 2:46:22 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (9, N'18', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'kırmızı', N'çizgi', N'55', N'4/7/2022 2:59:30 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (10, N'14', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'ahmet', N'kaya', N'77', N'4/7/2022 3:01:24 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (11, N'15', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'ece', N'kaya', N'77', N'4/7/2022 3:01:35 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (16, N'22', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'emir', N'arslan', N'33', N'4/7/2022 3:06:54 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (19, N'31', N'salon 2', N'Stranger Things', N'4/7/2022', N'nnnnnnnnnnnnnnnnnnnnnnnnnnnnnn', N'Umutcan Recep', N'Topcuoglu', N'80', N'4/7/2022 4:23:27 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (21, N'15', N'salon 1', N'Test Film', N'4/8/2022', N'11:00:00', N'Hakan', N'Arslan', N'44', N'4/7/2022 4:19:36 PM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (22, N'16', N'salon 1', N'Test Film', N'4/8/2022', N'11:00:00', N'Emin', N'Kara', N'44', N'4/7/2022 4:19:48 PM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (8, N'45', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'hakanze', N'fahre', N'22', N'4/7/2022 2:49:51 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (12, N'39', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'Serkan', N'Şalış', N'33', N'4/7/2022 3:03:10 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (13, N'39', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'Serkan', N'Şalış', N'33', N'4/7/2022 3:03:12 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (14, N'30', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'Arda', N'Kara', N'55', N'4/7/2022 3:04:54 AM')
INSERT [dbo].[Satis_Bilgileri] ([SatisId], [KoltukNo], [SalonAdi], [FilmAdi], [Tarih], [Saat], [Ad], [Soyad], [Ucret], [SatisTarihi]) VALUES (15, N'31', N'salon 1', N'Test Film', N'4/7/2022', N'14:00:00', N'umut', N'topcu', N'33', N'4/7/2022 3:05:46 AM')
SET IDENTITY_INSERT [dbo].[Satis_Bilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[Seans_Bilgileri] ON 

INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (1, N'Test Film', N'salon 1', N'4/5/2022', N'11:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (2, N'Test Film', N'salon 1', N'4/5/2022', N'11:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (3, N'Test Film', N'salon 1', N'4/7/2022', N'14:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (4, N'Test Film', N'salon 1', N'4/8/2022', N'11:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (5, N'Stranger Things The Movie', N'salon 2', N'4/7/2022', N'12:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (6, N'Stranger Things', N'salon 2', N'4/7/2022', N'13:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (7, N'Batman', N'salon 2', N'4/7/2022', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (8, N'Batman', N'salon 2', N'4/7/2022', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (9, N'Batman', N'salon 2', N'4/7/2022', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (10, N'Batman', N'salon 2', N'4/7/2022', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (11, N'Batman', N'salon 2', N'4/7/2022', N'16:00:00')
INSERT [dbo].[Seans_Bilgileri] ([SeansId], [FilmAdi], [SalonAdi], [Tarih], [Seans]) VALUES (12, N'Superman', N'salon 2', N'4/8/2022', N'15:00:00')
SET IDENTITY_INSERT [dbo].[Seans_Bilgileri] OFF
GO
USE [master]
GO
ALTER DATABASE [SinemaOtomasyonu] SET  READ_WRITE 
GO
