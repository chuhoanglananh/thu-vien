USE [master]
GO
/****** Object:  Database [quản lý thư viện]    Script Date: 5/24/17 2:48:31 AM ******/
CREATE DATABASE [quản lý thư viện]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'quản lý thư viện', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\quản lý thư viện.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quản lý thư viện_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\quản lý thư viện_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quản lý thư viện] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quản lý thư viện].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quản lý thư viện] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [quản lý thư viện] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [quản lý thư viện] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [quản lý thư viện] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [quản lý thư viện] SET ARITHABORT OFF 
GO
ALTER DATABASE [quản lý thư viện] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [quản lý thư viện] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [quản lý thư viện] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [quản lý thư viện] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [quản lý thư viện] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [quản lý thư viện] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [quản lý thư viện] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [quản lý thư viện] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [quản lý thư viện] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [quản lý thư viện] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [quản lý thư viện] SET  DISABLE_BROKER 
GO
ALTER DATABASE [quản lý thư viện] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [quản lý thư viện] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [quản lý thư viện] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [quản lý thư viện] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [quản lý thư viện] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [quản lý thư viện] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [quản lý thư viện] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [quản lý thư viện] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [quản lý thư viện] SET  MULTI_USER 
GO
ALTER DATABASE [quản lý thư viện] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [quản lý thư viện] SET DB_CHAINING OFF 
GO
ALTER DATABASE [quản lý thư viện] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [quản lý thư viện] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [quản lý thư viện]
GO
/****** Object:  Table [dbo].[chitietphieumuon]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[chitietphieumuon](
	[SoPhieuMuon] [char](50) NULL,
	[MaSach] [char](50) NULL,
	[HenTra] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[loaisach]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[loaisach](
	[MaLS] [char](50) NOT NULL,
	[TenLS] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[muonsach]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[muonsach](
	[SoPhieuMuon] [char](50) NOT NULL,
	[MaThe] [char](50) NULL,
	[MaNV] [char](50) NULL,
	[NgayMuon] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nhanvien](
	[MaNV] [char](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [int] NOT NULL,
	[DienThoai] [char](20) NOT NULL,
	[MatKhau] [char](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [char](50) NOT NULL,
	[TenNXB] [nvarchar](100) NOT NULL,
	[DiaChiNXB] [nvarchar](100) NOT NULL,
	[Website] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[phat]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[phat](
	[MaSach] [char](50) NULL,
	[MaThe] [char](50) NULL,
	[LyDoPhat] [nvarchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sach]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sach](
	[MaSach] [char](50) NOT NULL,
	[TenSach] [nvarchar](100) NOT NULL,
	[TacGia] [nvarchar](50) NULL,
	[MaNXB] [char](50) NULL,
	[MaLS] [char](50) NULL,
	[NamXB] [int] NULL,
	[LanXB] [int] NULL,
	[SoLuong] [int] NOT NULL,
	[NoiDung] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[sinhvien](
	[MaThe] [char](50) NOT NULL,
	[TenSV] [nvarchar](50) NOT NULL,
	[Ngaysinh] [datetime] NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Lop] [nvarchar](50) NOT NULL,
	[Khoa] [nvarchar](50) NOT NULL,
	[NgayCapThe] [datetime] NOT NULL,
	[NgayHetHan] [datetime] NOT NULL,
	[gioitinh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[taikhoan](
	[TenTk] [char](50) NOT NULL,
	[MatKhau] [char](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenTk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[trasach]    Script Date: 5/24/17 2:48:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trasach](
	[SoPhieuMuon] [char](50) NULL,
	[MaSach] [char](50) NULL,
	[MaNV] [char](50) NULL,
	[NgayTra] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[chitietphieumuon]  WITH CHECK ADD FOREIGN KEY([SoPhieuMuon])
REFERENCES [dbo].[muonsach] ([SoPhieuMuon])
GO
ALTER TABLE [dbo].[muonsach]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[nhanvien] ([MaNV])
GO
ALTER TABLE [dbo].[muonsach]  WITH CHECK ADD FOREIGN KEY([MaThe])
REFERENCES [dbo].[sinhvien] ([MaThe])
GO
ALTER TABLE [dbo].[phat]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[sach] ([MaSach])
GO
ALTER TABLE [dbo].[phat]  WITH CHECK ADD FOREIGN KEY([MaThe])
REFERENCES [dbo].[sinhvien] ([MaThe])
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD FOREIGN KEY([MaLS])
REFERENCES [dbo].[loaisach] ([MaLS])
GO
ALTER TABLE [dbo].[sach]  WITH CHECK ADD FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[trasach]  WITH CHECK ADD FOREIGN KEY([SoPhieuMuon])
REFERENCES [dbo].[muonsach] ([SoPhieuMuon])
GO
USE [master]
GO
ALTER DATABASE [quản lý thư viện] SET  READ_WRITE 
GO
