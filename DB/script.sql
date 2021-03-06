USE [master]
GO
/****** Object:  Database [SanalEgitim]    Script Date: 30.12.2019 14:57:18 ******/
CREATE DATABASE [SanalEgitim]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SanalEgitim', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SanalEgitim.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SanalEgitim_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SanalEgitim_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SanalEgitim] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SanalEgitim].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SanalEgitim] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SanalEgitim] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SanalEgitim] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SanalEgitim] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SanalEgitim] SET ARITHABORT OFF 
GO
ALTER DATABASE [SanalEgitim] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SanalEgitim] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SanalEgitim] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SanalEgitim] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SanalEgitim] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SanalEgitim] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SanalEgitim] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SanalEgitim] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SanalEgitim] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SanalEgitim] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SanalEgitim] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SanalEgitim] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SanalEgitim] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SanalEgitim] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SanalEgitim] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SanalEgitim] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SanalEgitim] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SanalEgitim] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SanalEgitim] SET  MULTI_USER 
GO
ALTER DATABASE [SanalEgitim] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SanalEgitim] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SanalEgitim] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SanalEgitim] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SanalEgitim] SET DELAYED_DURABILITY = DISABLED 
GO
USE [SanalEgitim]
GO
/****** Object:  Table [dbo].[AsamaBilgi]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsamaBilgi](
	[Asama] [int] NULL CONSTRAINT [DF_AsamaBilgi_Asama]  DEFAULT ((0)),
	[OgrenciID] [int] NULL,
	[SoruID] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Konu]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Konu](
	[KonuID] [int] NOT NULL,
	[KonuAd] [nvarchar](50) NULL,
 CONSTRAINT [PK_Konu] PRIMARY KEY CLUSTERED 
(
	[KonuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KonuDetay]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KonuDetay](
	[OgrenciID] [int] NOT NULL,
	[KonuID] [int] NULL,
	[DogruSayisi] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[OgrenciID] [int] NOT NULL,
	[OgrenciAd] [nvarchar](15) NULL,
	[OgrenciSoyad] [nvarchar](15) NULL,
	[Sifre] [varchar](5) NULL,
	[TCKN] [nvarchar](11) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ogretmen]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ogretmen](
	[OgrAd] [nvarchar](15) NULL,
	[OgrSoyad] [nvarchar](15) NULL,
	[OgrSifre] [varchar](5) NULL,
	[OgrTCKN] [nvarchar](11) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Soru]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Soru](
	[SoruID] [int] IDENTITY(1,1) NOT NULL,
	[cevapA] [nvarchar](80) NULL,
	[cevapB] [nvarchar](80) NULL,
	[cevapC] [nvarchar](80) NULL,
	[cevapD] [nvarchar](80) NULL,
	[DogruCevap] [nvarchar](1) NULL,
	[KonuID] [int] NULL,
	[SoruMetni] [nvarchar](250) NULL,
	[Resim] [varchar](300) NULL CONSTRAINT [DF_Soru_Resim]  DEFAULT (NULL),
 CONSTRAINT [PK_Soru] PRIMARY KEY CLUSTERED 
(
	[SoruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TarihBilgi]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TarihBilgi](
	[OgrenciID] [int] NOT NULL,
	[SinavTarih] [date] NULL,
	[DogruSayisi] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[OgrenciBilgi]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[OgrenciBilgi]
AS
SELECT dbo.Ogrenci.OgrenciID, dbo.Ogrenci.OgrenciAd, dbo.Ogrenci.OgrenciSoyad, dbo.TarihBilgi.SinavTarih, dbo.TarihBilgi.DogruSayisi, dbo.Konu.KonuAd, dbo.KonuDetay.DogruSayisi AS KonuDogruSayisi
FROM     dbo.Konu INNER JOIN
                  dbo.KonuDetay ON dbo.Konu.KonuID = dbo.KonuDetay.KonuID INNER JOIN
                  dbo.Ogrenci ON dbo.KonuDetay.OgrenciID = dbo.Ogrenci.OgrenciID INNER JOIN
                  dbo.TarihBilgi ON dbo.Ogrenci.OgrenciID = dbo.TarihBilgi.OgrenciID

GO
/****** Object:  View [dbo].[SoruKonuBilgi]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[SoruKonuBilgi]
AS
SELECT dbo.Soru.SoruID, dbo.Soru.SoruMetni, dbo.Konu.KonuID, dbo.Konu.KonuAd
FROM     dbo.Konu INNER JOIN
                  dbo.Soru ON dbo.Konu.KonuID = dbo.Soru.KonuID

GO
ALTER TABLE [dbo].[KonuDetay]  WITH CHECK ADD  CONSTRAINT [FK_KonuDetay_Konu] FOREIGN KEY([KonuID])
REFERENCES [dbo].[Konu] ([KonuID])
GO
ALTER TABLE [dbo].[KonuDetay] CHECK CONSTRAINT [FK_KonuDetay_Konu]
GO
ALTER TABLE [dbo].[KonuDetay]  WITH CHECK ADD  CONSTRAINT [FK_KonuDetay_Ogrenci] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[KonuDetay] CHECK CONSTRAINT [FK_KonuDetay_Ogrenci]
GO
ALTER TABLE [dbo].[Soru]  WITH CHECK ADD  CONSTRAINT [FK_Soru_Konu] FOREIGN KEY([KonuID])
REFERENCES [dbo].[Konu] ([KonuID])
GO
ALTER TABLE [dbo].[Soru] CHECK CONSTRAINT [FK_Soru_Konu]
GO
ALTER TABLE [dbo].[TarihBilgi]  WITH CHECK ADD  CONSTRAINT [FK_TarihBilgi_Ogrenci] FOREIGN KEY([OgrenciID])
REFERENCES [dbo].[Ogrenci] ([OgrenciID])
GO
ALTER TABLE [dbo].[TarihBilgi] CHECK CONSTRAINT [FK_TarihBilgi_Ogrenci]
GO
/****** Object:  StoredProcedure [dbo].[AsamaArttir]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AsamaArttir]
@OgrenciID int,
@SoruID int 
as
UPDATE AsamaBilgi SET Asama=1 WHERE SoruID=@SoruID and OgrenciID=@OgrenciID
GO
/****** Object:  StoredProcedure [dbo].[AsamaEkle]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AsamaEkle]
@OgrenciID int,
@SoruID int
as
insert into AsamaBilgi(OgrenciID,SoruID) values (@OgrenciID,@SoruID)
GO
/****** Object:  StoredProcedure [dbo].[GirisYap]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GirisYap]
@TCKN nvarchar(11),
@Sifre varchar(5)
as
SELECT * FROM Ogrenci WHERE TCKN=@TCKN and Sifre=@Sifre
GO
/****** Object:  StoredProcedure [dbo].[KonuBilgiCek]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[KonuBilgiCek]
@OgrenciID int 
as
Select KD.DogruSayisi,K.KonuAd From KonuDetay KD INNER JOIN Konu  K ON K.KonuID=KD.KonuID
WHERE OgrenciID=@OgrenciID 
GO
/****** Object:  StoredProcedure [dbo].[KonuNot]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KonuNot]
@OgrenciID int,
@KonuID int,
@DogruSayisi int
as
UPDATE KonuDetay SET DogruSayisi+=@DogruSayisi WHERE OgrenciID=@OgrenciID AND KonuID=@KonuID
GO
/****** Object:  StoredProcedure [dbo].[OgrenciName]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgrenciName]
as
Select OgrenciAd +' '+OgrenciSoyad From Ogrenci
GO
/****** Object:  StoredProcedure [dbo].[OgretmenGiris]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OgretmenGiris]
@TCKN nvarchar(11),
@Sifre varchar(5)
as
SELECT * FROM Ogretmen WHERE OgrTCKN=@TCKN and OgrSifre=@Sifre
GO
/****** Object:  StoredProcedure [dbo].[SoruEkle]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SoruEkle]
@cevapA nvarchar(80),
@cevapB nvarchar(80),
@cevapC nvarchar(80),
@cevapD nvarchar(80),
@DogruCevap nvarchar(80),
@KonuID int,
@SoruMetni nvarchar(250),
@Resim varchar(300)
as
insert into Soru(cevapA,cevapB,cevapC,cevapD,DogruCevap,KonuID,SoruMetni,Resim) values (@cevapA,@cevapB,@cevapC,@cevapD,@DogruCevap,@KonuID,@SoruMetni,@Resim)
GO
/****** Object:  StoredProcedure [dbo].[SoruGetir]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SoruGetir]
@OgrenciID int
as
Select top 5 S.cevapA,S.cevapB,S.cevapC,S.cevapD,S.DogruCevap,S.KonuID,S.Resim,S.SoruID,S.SoruMetni,AB.Asama FROM Soru S INNER JOIN AsamaBilgi AB ON S.SoruID=AB.SoruID
INNER JOIN Ogrenci O ON O.OgrenciID=AB.OgrenciID
 Where AB.Asama=0 AND  AB.OgrenciID=@OgrenciID Order By NEWID()
GO
/****** Object:  StoredProcedure [dbo].[SoruListele]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SoruListele]
as
Select DogruCevap,KonuID,SoruID,SoruMetni From Soru
GO
/****** Object:  StoredProcedure [dbo].[TarihBilgiCek]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TarihBilgiCek]
@OgrenciID int
as
Select SinavTarih,DogruSayisi From TarihBilgi WHERE OgrenciID=@OgrenciID
GO
/****** Object:  StoredProcedure [dbo].[TariheGoreNot]    Script Date: 30.12.2019 14:57:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TariheGoreNot]
@OgrenciID int,
@SinavTarih date,
@DogruSayisi int
as
INSERT INTO TarihBilgi(OgrenciID,SinavTarih,DogruSayisi) VALUES (@OgrenciID,@SinavTarih,@DogruSayisi)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Konu"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 126
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KonuDetay"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 148
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Ogrenci"
            Begin Extent = 
               Top = 7
               Left = 532
               Bottom = 170
               Right = 726
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TarihBilgi"
            Begin Extent = 
               Top = 7
               Left = 774
               Bottom = 148
               Right = 968
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OgrenciBilgi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OgrenciBilgi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Konu"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 126
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Soru"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SoruKonuBilgi'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'SoruKonuBilgi'
GO
USE [master]
GO
ALTER DATABASE [SanalEgitim] SET  READ_WRITE 
GO
