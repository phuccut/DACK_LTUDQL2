USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 06/15/2017 11:19:45 ******/
CREATE DATABASE [QuanLyBanHang] ON  PRIMARY 
( NAME = N'QuanLyBanHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.QTCSDL\MSSQL\DATA\QuanLyBanHang.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.QTCSDL\MSSQL\DATA\QuanLyBanHang_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyBanHang] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QuanLyBanHang] SET ARITHABORT OFF
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QuanLyBanHang] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QuanLyBanHang] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QuanLyBanHang] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QuanLyBanHang] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QuanLyBanHang] SET  ENABLE_BROKER
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QuanLyBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QuanLyBanHang] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QuanLyBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QuanLyBanHang] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QuanLyBanHang] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QuanLyBanHang] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QuanLyBanHang] SET  READ_WRITE
GO
ALTER DATABASE [QuanLyBanHang] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QuanLyBanHang] SET  MULTI_USER
GO
ALTER DATABASE [QuanLyBanHang] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QuanLyBanHang] SET DB_CHAINING OFF
GO
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[VaiTro]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_VaiTro] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[VaiTro] ON
INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (1, N'Quản Lý', NULL)
INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (2, N'Quản Lý Kho', NULL)
INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (3, N'Nhân Viên', NULL)
INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (4, N'Admin', NULL)
SET IDENTITY_INSERT [dbo].[VaiTro] OFF
/****** Object:  Table [dbo].[TyGia]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TyGia](
	[Id] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[TyGiaQuyDoi] [int] NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_TyGia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomHang](
	[Id] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[QuanLy] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhomHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[Id] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MoTa] [nchar](10) NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoHang](
	[Id] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[LienHe] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[KyHieu] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[Id] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNang](
	[Id] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Id_Cha] [int] NULL,
	[Them] [bit] NULL,
	[Xoa] [bit] NULL,
	[Sua] [bit] NULL,
	[Nhap] [bit] NULL,
	[Xuat] [bit] NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BoPhan]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoPhan](
	[Id] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_BoPhan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BoPhan] ([Id], [Ten], [GhiChu], [QuanLy]) VALUES (N'BP01', N'Quản trị viên', NULL, 1)
/****** Object:  Table [dbo].[HangHoa]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[Id] [nvarchar](50) NOT NULL,
	[IdNhomHang] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[IdDonVi] [nvarchar](50) NULL,
	[GiaMua] [int] NULL,
	[GiaBanSi] [int] NULL,
	[GiaBanLe] [int] NULL,
	[ToiThieu] [int] NULL,
	[IdKho] [nvarchar](50) NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[Id] [nvarchar](50) NOT NULL,
	[IdKhuVuc] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[LienHe] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[DiDong] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[Website] [nvarchar](50) NULL,
	[MaSoThue] [int] NULL,
	[SoTaiKhoan] [int] NULL,
	[TenNganHang] [nvarchar](50) NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VaiTro_ChucNang]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro_ChucNang](
	[Id] [int] NOT NULL,
	[IdVaiTro] [int] NULL,
	[IdChucNang] [int] NULL,
	[Them] [bit] NULL,
	[Xoa] [bit] NULL,
	[Sua] [bit] NULL,
	[Nhap] [bit] NULL,
	[Xuat] [bit] NULL,
 CONSTRAINT [PK_VaiTro_ChucNang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Id] [nvarchar](50) NOT NULL,
	[IdBoPhan] [nvarchar](50) NULL,
	[IdQuanLy] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[DiDong] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhanVien] ([Id], [IdBoPhan], [IdQuanLy], [Ten], [DiaChi], [DienThoai], [DiDong], [Email], [QuanLy]) VALUES (N'NV01', N'BP01', NULL, N'Nguyễn Vĩnh Phúc', N'Quạn 10', N'0972594200', N'0972594200', N'phuccut@gmail.com', 1)
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[Id] [nvarchar](50) NOT NULL,
	[IdKhuVuc] [nvarchar](50) NULL,
	[Ten] [nvarchar](100) NULL,
	[LienHe] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](50) NULL,
	[DiDong] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Id] [char](100) NOT NULL,
	[IdNhanVien] [nvarchar](50) NULL,
	[TenTaiKhoan] [nvarchar](100) NULL,
	[MatKhau] [nvarchar](100) NULL,
	[IdVaiTro] [int] NOT NULL,
	[QuanLy] [bit] NULL,
 CONSTRAINT [PK__TaiKhoan__3213E83F7F60ED59] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TaiKhoan] ([Id], [IdNhanVien], [TenTaiKhoan], [MatKhau], [IdVaiTro], [QuanLy]) VALUES (N'1                                                                                         TK01      ', N'NV01', N'admin', N'c4ca4238a0b923820dcc509a6f75849b', 1, 1)
/****** Object:  Table [dbo].[HoaDonMuaHang]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonMuaHang](
	[Id] [nvarchar](50) NOT NULL,
	[IdNCC] [nvarchar](50) NULL,
	[IdNhanVien] [nvarchar](50) NULL,
	[IdKho] [nvarchar](50) NULL,
	[Ngay] [date] NULL,
	[IdDKTT] [int] NULL,
	[IdHTTT] [int] NULL,
	[HanTT] [date] NULL,
	[NgayGiao] [date] NULL,
 CONSTRAINT [PK_HoaDonMuaHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHDMuaHang]    Script Date: 06/15/2017 11:19:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHDMuaHang](
	[Id] [nvarchar](50) NOT NULL,
	[IdHoaDon] [nvarchar](50) NULL,
	[IdMonHang] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[IdLoaiGia] [int] NULL,
	[ChietKhau] [int] NULL,
 CONSTRAINT [PK_CTHDMuaHang] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__TaiKhoan__LoaiTa__014935CB]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [DF__TaiKhoan__LoaiTa__014935CB]  DEFAULT ((0)) FOR [IdVaiTro]
GO
/****** Object:  ForeignKey [FK_HangHoa_DonViTinh]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_DonViTinh] FOREIGN KEY([IdDonVi])
REFERENCES [dbo].[DonViTinh] ([Id])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_DonViTinh]
GO
/****** Object:  ForeignKey [FK_HangHoa_KhoHang]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_KhoHang] FOREIGN KEY([IdKho])
REFERENCES [dbo].[KhoHang] ([Id])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_KhoHang]
GO
/****** Object:  ForeignKey [FK_HangHoa_NhomHang]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhomHang] FOREIGN KEY([IdNhomHang])
REFERENCES [dbo].[NhomHang] ([Id])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhomHang]
GO
/****** Object:  ForeignKey [FK_KhachHang_KhuVuc]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_KhuVuc] FOREIGN KEY([IdKhuVuc])
REFERENCES [dbo].[KhuVuc] ([Id])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_KhuVuc]
GO
/****** Object:  ForeignKey [FK_VaiTro_ChucNang_ChucNang]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[VaiTro_ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_VaiTro_ChucNang_ChucNang] FOREIGN KEY([IdChucNang])
REFERENCES [dbo].[ChucNang] ([Id])
GO
ALTER TABLE [dbo].[VaiTro_ChucNang] CHECK CONSTRAINT [FK_VaiTro_ChucNang_ChucNang]
GO
/****** Object:  ForeignKey [FK_VaiTro_ChucNang_VaiTro]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[VaiTro_ChucNang]  WITH CHECK ADD  CONSTRAINT [FK_VaiTro_ChucNang_VaiTro] FOREIGN KEY([IdVaiTro])
REFERENCES [dbo].[VaiTro] ([id])
GO
ALTER TABLE [dbo].[VaiTro_ChucNang] CHECK CONSTRAINT [FK_VaiTro_ChucNang_VaiTro]
GO
/****** Object:  ForeignKey [FK_NhanVien_BoPhan]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_BoPhan] FOREIGN KEY([IdBoPhan])
REFERENCES [dbo].[BoPhan] ([Id])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_BoPhan]
GO
/****** Object:  ForeignKey [FK_NhaCungCap_KhuVuc]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_KhuVuc] FOREIGN KEY([IdKhuVuc])
REFERENCES [dbo].[KhuVuc] ([Id])
GO
ALTER TABLE [dbo].[NhaCungCap] CHECK CONSTRAINT [FK_NhaCungCap_KhuVuc]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_NhanVien]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([IdNhanVien])
REFERENCES [dbo].[NhanVien] ([Id])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
/****** Object:  ForeignKey [FK_TaiKhoan_VaiTro]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_VaiTro] FOREIGN KEY([IdVaiTro])
REFERENCES [dbo].[VaiTro] ([id])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_VaiTro]
GO
/****** Object:  ForeignKey [FK_HoaDonMuaHang_NhaCungCap]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[HoaDonMuaHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonMuaHang_NhaCungCap] FOREIGN KEY([IdNCC])
REFERENCES [dbo].[NhaCungCap] ([Id])
GO
ALTER TABLE [dbo].[HoaDonMuaHang] CHECK CONSTRAINT [FK_HoaDonMuaHang_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_HoaDonMuaHang_NhanVien]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[HoaDonMuaHang]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonMuaHang_NhanVien] FOREIGN KEY([IdNhanVien])
REFERENCES [dbo].[NhanVien] ([Id])
GO
ALTER TABLE [dbo].[HoaDonMuaHang] CHECK CONSTRAINT [FK_HoaDonMuaHang_NhanVien]
GO
/****** Object:  ForeignKey [FK_CTHDMuaHang_HangHoa]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[CTHDMuaHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDMuaHang_HangHoa] FOREIGN KEY([IdMonHang])
REFERENCES [dbo].[HangHoa] ([Id])
GO
ALTER TABLE [dbo].[CTHDMuaHang] CHECK CONSTRAINT [FK_CTHDMuaHang_HangHoa]
GO
/****** Object:  ForeignKey [FK_CTHDMuaHang_HoaDonMuaHang]    Script Date: 06/15/2017 11:19:46 ******/
ALTER TABLE [dbo].[CTHDMuaHang]  WITH CHECK ADD  CONSTRAINT [FK_CTHDMuaHang_HoaDonMuaHang] FOREIGN KEY([IdHoaDon])
REFERENCES [dbo].[HoaDonMuaHang] ([Id])
GO
ALTER TABLE [dbo].[CTHDMuaHang] CHECK CONSTRAINT [FK_CTHDMuaHang_HoaDonMuaHang]
GO
