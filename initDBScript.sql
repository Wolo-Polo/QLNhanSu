USE [master]
GO
/****** Object:  Database [QLNhanSu]    Script Date: 11/1/2020 8:54:02 PM ******/
CREATE DATABASE [QLNhanSu] ON  PRIMARY 
( NAME = N'QLNhanSu', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLNhanSu.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLNhanSu_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QLNhanSu_log.LDF' , SIZE = 576KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLNhanSu] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNhanSu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNhanSu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNhanSu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNhanSu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNhanSu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNhanSu] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNhanSu] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLNhanSu] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNhanSu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNhanSu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNhanSu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNhanSu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNhanSu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNhanSu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNhanSu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNhanSu] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLNhanSu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNhanSu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNhanSu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNhanSu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNhanSu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNhanSu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNhanSu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNhanSu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNhanSu] SET  MULTI_USER 
GO
ALTER DATABASE [QLNhanSu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNhanSu] SET DB_CHAINING OFF 
GO
USE [QLNhanSu]
GO
/****** Object:  UserDefinedFunction [dbo].[Fn_Find]    Script Date: 11/1/2020 8:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Fn_Find]()
RETURNS @bang TABLE (manv CHAR(5), tennv NVARCHAR(20), ngaycong DATE, ghichu NVARCHAR(20))
AS
BEGIN
	INSERT INTO @bang
	        ( manv, tennv, ngaycong, ghichu )
	SELECT dbo.CONG.manv, tennv, ngaycong, ghichu FROM dbo.CONG INNER JOIN dbo.NHANVIEN ON NHANVIEN.MaNV = CONG.MaNV
	RETURN
END 
GO
/****** Object:  UserDefinedFunction [dbo].[tblluong]    Script Date: 11/1/2020 8:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[tblluong]()
RETURNS @bang TABLE (manv CHAR(4), tennv nvarchar(20), nam INT, thang INT, socong INT, tongluong float)
AS
BEGIN
INSERT INTO @bang
	SELECT CONG.MaNV[Mã nhân viên], TenNV[Tên nhân viên], YEAR(NgayCong)[Năm],MONTH(NgayCong)[Tháng], COUNT(NgayCong)[Số công], HeSoPC*5000000*COUNT(NgayCong)[Lương] 
FROM dbo.NHANVIEN INNER JOIN dbo.CONG ON CONG.MaNV = NHANVIEN.MaNV INNER JOIN dbo.CHUCVU ON CHUCVU.MaCV = NHANVIEN.MaCV
GROUP BY CONG.MaNV, TenNV , MONTH(NgayCong),YEAR(NgayCong),HeSoPC
RETURN 
END
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 11/1/2020 8:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [nchar](5) NOT NULL,
	[TenCV] [nvarchar](20) NOT NULL,
	[HeSoPC] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONG]    Script Date: 11/1/2020 8:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONG](
	[MaNV] [nchar](5) NOT NULL,
	[NgayCong] [date] NOT NULL,
	[GhiChu] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[NgayCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONGTAC]    Script Date: 11/1/2020 8:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGTAC](
	[MaNV] [nchar](5) NOT NULL,
	[NgayCongTac] [nvarchar](20) NOT NULL,
	[NoiCongTac] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[NgayCongTac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/1/2020 8:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nchar](5) NOT NULL,
	[TenNV] [nvarchar](20) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](7) NOT NULL,
	[SDT] [nchar](15) NULL,
	[Email] [nvarchar](30) NOT NULL,
	[TaiKhoan] [nvarchar](20) NOT NULL,
	[MatKhau] [nvarchar](20) NOT NULL,
	[Quyen] [bit] NOT NULL,
	[MaPB] [nchar](5) NOT NULL,
	[MaCV] [nchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 11/1/2020 8:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MaPB] [nchar](5) NOT NULL,
	[TenPB] [nvarchar](20) NOT NULL,
	[NgayTL] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRINHDO]    Script Date: 11/1/2020 8:54:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRINHDO](
	[MaNV] [nchar](5) NOT NULL,
	[Nganh] [nvarchar](20) NOT NULL,
	[TrinhDo] [nvarchar](20) NOT NULL,
	[Truong] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[Nganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HeSoPC]) VALUES (N'CV01 ', N'Giám đóc', 3)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HeSoPC]) VALUES (N'CV02 ', N'Trưởng phòng', 2)
INSERT [dbo].[CHUCVU] ([MaCV], [TenCV], [HeSoPC]) VALUES (N'CV03 ', N'Nhân viên', 1)
INSERT [dbo].[CONG] ([MaNV], [NgayCong], [GhiChu]) VALUES (N'NV01 ', CAST(N'2010-03-02' AS Date), N'')
INSERT [dbo].[CONG] ([MaNV], [NgayCong], [GhiChu]) VALUES (N'NV02 ', CAST(N'2010-03-02' AS Date), N'')
INSERT [dbo].[CONG] ([MaNV], [NgayCong], [GhiChu]) VALUES (N'NV02 ', CAST(N'2010-04-02' AS Date), N'')
INSERT [dbo].[CONG] ([MaNV], [NgayCong], [GhiChu]) VALUES (N'NV03 ', CAST(N'2010-03-02' AS Date), N'')
INSERT [dbo].[CONG] ([MaNV], [NgayCong], [GhiChu]) VALUES (N'NV03 ', CAST(N'2010-04-02' AS Date), N'')
INSERT [dbo].[CONG] ([MaNV], [NgayCong], [GhiChu]) VALUES (N'NV03 ', CAST(N'2010-05-02' AS Date), N'')
INSERT [dbo].[CONGTAC] ([MaNV], [NgayCongTac], [NoiCongTac]) VALUES (N'NV01 ', N'2010-03-02', N'Hải Phòng')
INSERT [dbo].[CONGTAC] ([MaNV], [NgayCongTac], [NoiCongTac]) VALUES (N'NV01 ', N'2010-04-02', N'Hà Nội')
INSERT [dbo].[CONGTAC] ([MaNV], [NgayCongTac], [NoiCongTac]) VALUES (N'NV02 ', N'2010-03-02', N'Hải Phòng')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [SDT], [Email], [TaiKhoan], [MatKhau], [Quyen], [MaPB], [MaCV]) VALUES (N'NV01 ', N'Hoàng Dược Sư', CAST(N'2001-08-09' AS Date), N'Nam', N'0916102895     ', N'taolaluyen@gmail.com', N'hdsu01', N'su01', 1, N'PB01 ', N'CV01 ')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [SDT], [Email], [TaiKhoan], [MatKhau], [Quyen], [MaPB], [MaCV]) VALUES (N'NV02 ', N'Chu Bá Thông', CAST(N'2001-08-09' AS Date), N'Nam', N'0916102895     ', N'taolaluyen@gmail.com', N'cbthong02', N'thong02', 0, N'PB02 ', N'CV02 ')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [SDT], [Email], [TaiKhoan], [MatKhau], [Quyen], [MaPB], [MaCV]) VALUES (N'NV03 ', N'Âu Dương Phong', CAST(N'2001-08-09' AS Date), N'Nam', N'0916102895     ', N'taolaluyen@gmail.com', N'adphong03', N'phong03', 0, N'PB01 ', N'CV03 ')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [SDT], [Email], [TaiKhoan], [MatKhau], [Quyen], [MaPB], [MaCV]) VALUES (N'NV04 ', N'Nhậm Doanh Doanh', CAST(N'2001-08-29' AS Date), N'Nữ', N'0916102895     ', N'taolaluyen@gmail.com', N'nddoanh04', N'doanh04', 1, N'PB03 ', N'CV03 ')
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [NgayTL]) VALUES (N'PB01 ', N'Phòng Tài chính', CAST(N'2000-02-03' AS Date))
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [NgayTL]) VALUES (N'PB02 ', N'Phòng Kinh doanh', CAST(N'2000-02-03' AS Date))
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [NgayTL]) VALUES (N'PB03 ', N'Phòng Kế toán', CAST(N'2000-02-03' AS Date))
INSERT [dbo].[PHONGBAN] ([MaPB], [TenPB], [NgayTL]) VALUES (N'PB04 ', N'Phòng Tuyển dụng', CAST(N'2000-02-03' AS Date))
INSERT [dbo].[TRINHDO] ([MaNV], [Nganh], [TrinhDo], [Truong]) VALUES (N'NV01 ', N'CNTT', N'Kỹ sư', N'HAUI')
INSERT [dbo].[TRINHDO] ([MaNV], [Nganh], [TrinhDo], [Truong]) VALUES (N'NV01 ', N'Điện', N'Kĩ sư', N'HAUI')
INSERT [dbo].[TRINHDO] ([MaNV], [Nganh], [TrinhDo], [Truong]) VALUES (N'NV02 ', N'Điện', N'Cử nhân', N'HAUI')
INSERT [dbo].[TRINHDO] ([MaNV], [Nganh], [TrinhDo], [Truong]) VALUES (N'NV02 ', N'Tự động hóa', N'Cử nhân', N'HAUI')
INSERT [dbo].[TRINHDO] ([MaNV], [Nganh], [TrinhDo], [Truong]) VALUES (N'NV03 ', N'Điện Tử', N'Cao đẳng', N'HAUI')
INSERT [dbo].[TRINHDO] ([MaNV], [Nganh], [TrinhDo], [Truong]) VALUES (N'NV04 ', N'Công nghệ thông tin', N'Thạc sĩ', N'HaUI')
ALTER TABLE [dbo].[CONG]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien4] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[CONG] CHECK CONSTRAINT [fk_nhanvien4]
GO
ALTER TABLE [dbo].[CONGTAC]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien3] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[CONGTAC] CHECK CONSTRAINT [fk_nhanvien3]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [fk_chucvu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [fk_chucvu]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [fk_phongban] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PHONGBAN] ([MaPB])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [fk_phongban]
GO
ALTER TABLE [dbo].[TRINHDO]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien2] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TRINHDO] CHECK CONSTRAINT [fk_nhanvien2]
GO
USE [master]
GO
ALTER DATABASE [QLNhanSu] SET  READ_WRITE 
GO
