USE [master]
GO
/****** Object:  Database [QLKhachSan]    Script Date: 12/15/2023 9:53:45 PM ******/
CREATE DATABASE [QLKhachSan]

GO
ALTER DATABASE [QLKhachSan] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKhachSan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKhachSan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKhachSan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKhachSan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKhachSan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKhachSan] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKhachSan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLKhachSan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKhachSan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKhachSan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKhachSan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKhachSan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKhachSan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKhachSan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKhachSan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKhachSan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKhachSan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKhachSan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKhachSan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKhachSan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKhachSan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKhachSan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKhachSan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKhachSan] SET RECOVERY FULL 
GO
ALTER DATABASE [QLKhachSan] SET  MULTI_USER 
GO
ALTER DATABASE [QLKhachSan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKhachSan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKhachSan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKhachSan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKhachSan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKhachSan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLKhachSan', N'ON'
GO
ALTER DATABASE [QLKhachSan] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLKhachSan] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLKhachSan]
GO
/****** Object:  Table [dbo].[tbl_HoaDon]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPhieuThue] [int] NULL,
	[SoNgayThue] [int] NULL,
	[DonGia] [int] NULL,
	[ThanhTien] [float] NULL,
	[PhuThu] [float] NULL,
	[HeSo] [float] NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Phong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Phong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[TinhTrang] [tinyint] NOT NULL,
	[IDLoaiPhong] [int] NULL,
 CONSTRAINT [PK_tbl_Phong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_User](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_User] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBaoCaoLoaiPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBaoCaoLoaiPhong](
	[ID] [int] NOT NULL,
	[IDLoaiPhong] [int] NULL,
	[DoanhThu] [int] NULL,
	[TyLe] [float] NULL,
 CONSTRAINT [PK_tblBaoCao] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBaoCaoMDSDPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBaoCaoMDSDPhong](
	[ID] [int] NOT NULL,
	[IDPhong] [int] NULL,
	[SoNgayThue] [int] NULL,
	[TyLe] [float] NULL,
 CONSTRAINT [PK_tblBaoCaoMDSDPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[CMND] [varchar](20) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[IDLK] [int] NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiKhach]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiKhach](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoaiKhach] [nvarchar](20) NULL,
	[HeSo] [float] NULL,
 CONSTRAINT [PK_tblLoaiKhach] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiPhong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nchar](10) NULL,
	[DonGia] [int] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuThue]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuThue](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPhong] [int] NULL,
	[IDKH] [int] NULL,
	[NgayThue] [date] NULL,
 CONSTRAINT [PK_tblPhieuThue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_HoaDon] ON 

INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (3, 4, 3, 150000, 450000, 0, 1)
INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (4, 5, 2, 170000, 425000, 0.25, 1)
INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (5, 6, 3, 200000, 750000, 0.25, 1)
INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (6, 7, 2, 150000, 562500, 0.25, 1.5)
INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (7, 9, 3, 170000, 765000, 0, 1.5)
INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (8, 10, 3, 200000, 600000, 0, 1)
INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (9, 11, 4, 150000, 750000, 0.25, 1)
INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (10, 12, 7, 170000, 2231250, 0.25, 1.5)
INSERT [dbo].[tbl_HoaDon] ([ID], [IDPhieuThue], [SoNgayThue], [DonGia], [ThanhTien], [PhuThu], [HeSo]) VALUES (11, 13, 5, 200000, 1250000, 0.25, 1)
SET IDENTITY_INSERT [dbo].[tbl_HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Phong] ON 

INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (1, N'A001', 1, 1)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (2, N'B001', 1, 2)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (3, N'C001', 0, 3)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (4, N'A002', 1, 1)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (11, N'B002', 1, 2)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (12, N'C002', 1, 3)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (13, N'A003', 1, 1)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (14, N'B003', 1, 2)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (15, N'C003', 0, 3)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (17, N'A004', 1, 1)
INSERT [dbo].[tbl_Phong] ([ID], [TenPhong], [TinhTrang], [IDLoaiPhong]) VALUES (19, N'D002', 1, 4)
SET IDENTITY_INSERT [dbo].[tbl_Phong] OFF
GO
INSERT [dbo].[tbl_User] ([TaiKhoan], [MatKhau]) VALUES (N'admin', N'admin')
INSERT [dbo].[tbl_User] ([TaiKhoan], [MatKhau]) VALUES (N'user', N'user')
GO
INSERT [dbo].[tblBaoCaoLoaiPhong] ([ID], [IDLoaiPhong], [DoanhThu], [TyLe]) VALUES (1, 1, 1762500, 19.51)
INSERT [dbo].[tblBaoCaoLoaiPhong] ([ID], [IDLoaiPhong], [DoanhThu], [TyLe]) VALUES (2, 2, 4671250, 51.71)
INSERT [dbo].[tblBaoCaoLoaiPhong] ([ID], [IDLoaiPhong], [DoanhThu], [TyLe]) VALUES (3, 3, 2600000, 28.78)
GO
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (1, 1, 3, 9.68)
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (2, 2, 10, 32.26)
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (3, 3, 5, 16.13)
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (4, 4, 2, 6.45)
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (5, 11, 3, 9.68)
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (6, 12, 3, 9.68)
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (7, 13, 4, 12.9)
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (8, 14, 7, 22.58)
INSERT [dbo].[tblBaoCaoMDSDPhong] ([ID], [IDPhong], [SoNgayThue], [TyLe]) VALUES (9, 15, 5, 16.13)
GO
SET IDENTITY_INSERT [dbo].[tblKhachHang] ON 

INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (11, N'Trần Minh Duy', N'079098002341', N'Bình Tân, Tp.Hò Chí Minh', 1)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (12, N'Nguyễn Minh Tâm', N'083087132098', N'Tân Bình, Tp.Hồ Chí Minh', 1)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (13, N'Lý Thái Nguyên', N'070195001243', N'Tân Phú, Tp.Hồ Chí Minh', 1)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (14, N'Park Min Young', N'009193125343', N'Quận 1, Tp.Hồ Chí Minh', 2)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (15, N'Kim Jae Min', N'009097000913', N'Quận 1, Tp.Hồ Chí Minh', 2)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (16, N'Phạm Ngọc Hân', N'075301071123', N'Thủ Đức, Tp.Hồ Chí Minh', 1)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (17, N'Trương Nguyệt Ánh', N'069194761034', N'Quận 4, Tp.Hồ Chí Minh', 1)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (18, N'Trần Uyên Nhi', N'090198002345', N'Quận 12, Tp.Hồ Chí Minh', 1)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (19, N'Tăng Duy Tân', N'092090892345', N'Quận 11, Tp.Hồ Chí Minh', 1)
INSERT [dbo].[tblKhachHang] ([ID], [HoTen], [CMND], [DiaChi], [IDLK]) VALUES (20, N'Lee Tae Min', N'009099112342', N'Quận 5, Tp.Hồ Chí Minh', 2)
SET IDENTITY_INSERT [dbo].[tblKhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLoaiKhach] ON 

INSERT [dbo].[tblLoaiKhach] ([ID], [LoaiKhach], [HeSo]) VALUES (1, N'Nội địa', 1)
INSERT [dbo].[tblLoaiKhach] ([ID], [LoaiKhach], [HeSo]) VALUES (2, N'Nước ngoài', 1.5)
INSERT [dbo].[tblLoaiKhach] ([ID], [LoaiKhach], [HeSo]) VALUES (11, N'Hàn Quốc  ', 1.3)
SET IDENTITY_INSERT [dbo].[tblLoaiKhach] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLoaiPhong] ON 

INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [GhiChu]) VALUES (1, N'A         ', 150000, N'2 khách')
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [GhiChu]) VALUES (2, N'B         ', 170000, N'2 khách')
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [GhiChu]) VALUES (3, N'C         ', 200000, N'2 khách')
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [GhiChu]) VALUES (4, N'D         ', 250000, N'2 khách')
INSERT [dbo].[tblLoaiPhong] ([ID], [TenLoaiPhong], [DonGia], [GhiChu]) VALUES (15, N'F         ', 300000, N'3 khách')
SET IDENTITY_INSERT [dbo].[tblLoaiPhong] OFF
GO
SET IDENTITY_INSERT [dbo].[tblPhieuThue] ON 

INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (4, 1, 11, CAST(N'2023-11-12' AS Date))
INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (5, 2, 12, CAST(N'2023-12-12' AS Date))
INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (6, 3, 13, CAST(N'2023-12-12' AS Date))
INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (7, 4, 14, CAST(N'2023-12-12' AS Date))
INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (9, 11, 15, CAST(N'2023-12-12' AS Date))
INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (10, 12, 16, CAST(N'2023-12-12' AS Date))
INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (11, 13, 17, CAST(N'2023-12-13' AS Date))
INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (12, 14, 18, CAST(N'2023-12-13' AS Date))
INSERT [dbo].[tblPhieuThue] ([ID], [IDPhong], [IDKH], [NgayThue]) VALUES (13, 15, 19, CAST(N'2023-12-14' AS Date))
SET IDENTITY_INSERT [dbo].[tblPhieuThue] OFF
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tblPhieuThue] FOREIGN KEY([IDPhieuThue])
REFERENCES [dbo].[tblPhieuThue] ([ID])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tblPhieuThue]
GO
ALTER TABLE [dbo].[tbl_Phong]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Phong_tbl_LoaiPhong] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[tblLoaiPhong] ([ID])
GO
ALTER TABLE [dbo].[tbl_Phong] CHECK CONSTRAINT [FK_tbl_Phong_tbl_LoaiPhong]
GO
ALTER TABLE [dbo].[tblKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhachHang_tblLoaiKhach] FOREIGN KEY([IDLK])
REFERENCES [dbo].[tblLoaiKhach] ([ID])
GO
ALTER TABLE [dbo].[tblKhachHang] CHECK CONSTRAINT [FK_tblKhachHang_tblLoaiKhach]
GO
ALTER TABLE [dbo].[tblPhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuThue_tbl_Phong] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[tbl_Phong] ([ID])
GO
ALTER TABLE [dbo].[tblPhieuThue] CHECK CONSTRAINT [FK_tblPhieuThue_tbl_Phong]
GO
ALTER TABLE [dbo].[tblPhieuThue]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuThue_tblKhachHang] FOREIGN KEY([IDKH])
REFERENCES [dbo].[tblKhachHang] ([ID])
GO
ALTER TABLE [dbo].[tblPhieuThue] CHECK CONSTRAINT [FK_tblPhieuThue_tblKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[capNhatLoaiKhach]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[capNhatLoaiKhach]
	@idLoaiKhach int,
	@tenLoaiKhach nchar(10),
	@heSo float
as
begin
	update tblLoaiKhach
	set LoaiKhach = @tenLoaiKhach,
		HeSo = @heSo
	where ID = @idLoaiKhach;

	if @@ROWCOUNT > 0 return 1; ---cập nhật thành công
	else return 0; ---cập nhật thất bại
end
GO
/****** Object:  StoredProcedure [dbo].[capNhatLoaiPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[capNhatLoaiPhong]
	@idLoaiPhong int,
	@tenLoaiPhong nchar(10),
	@donGia int,
	@ghiChu nvarchar(50)
as
begin
	update tblLoaiPhong
	set TenLoaiPhong = @tenLoaiPhong,
		DonGia = @donGia,
		GhiChu = @ghiChu
	where ID = @idLoaiPhong;

	if @@ROWCOUNT > 0 return 1; ---cập nhật thành công
	else return 0; ---cập nhật thất bại
end
GO
/****** Object:  StoredProcedure [dbo].[capNhatPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[capNhatPhong]
	@idLoaiPhong int,
	@tenPhong nvarchar(50),
	@tinhTrang tinyint
as

begin
	insert into tbl_Phong values(@tenPhong,@tinhTrang,@idLoaiPhong);
	if @@ROWCOUNT > 0 return 1;
	else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[ChonPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ChonPhong]
@idPhong int
as
	
begin
	select * from tbl_Phong where ID = @idPhong
end
GO
/****** Object:  StoredProcedure [dbo].[dangNhap]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dangNhap]
	@taiKhoan varchar(50),
	@matKhau varchar(50)
as
begin
	select *
	from tbl_User 
	where TaiKhoan = @taiKhoan
	and MatKhau = @matKhau
end
GO
/****** Object:  StoredProcedure [dbo].[deletePhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deletePhong]
	@idPhong int
as
begin
	delete from tbl_Phong
	where id=@idPhong
	if @@ROWCOUNT > 0 return 1
	else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[loadBCLoaiPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadBCLoaiPhong]
as
begin
	select 
		blp.ID,
		lp.TenLoaiPhong,
		blp.DoanhThu,
		blp.TyLe
	from tblBaoCaoLoaiPhong blp
	inner join tblLoaiPhong lp on blp.IDLoaiPhong = lp.ID
end
GO
/****** Object:  StoredProcedure [dbo].[loadBCMDPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[loadBCMDPhong]
as
begin
	select 
		bmp.ID,
		p.TenPhong,
		bmp.SoNgayThue,
		bmp.TyLe
	from tblBaoCaoMDSDPhong bmp
	inner join tbl_Phong p on bmp.IDPhong = p.ID
end

exec loadBCMDPhong
GO
/****** Object:  StoredProcedure [dbo].[loadDmPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loadDmPhong]
as
begin
	select * from tblLoaiPhong;
end
GO
/****** Object:  StoredProcedure [dbo].[loadDsHoaDon]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadDsHoaDon]
as
begin
	select
		hd.ID,
		p.TenPhong,
		kh.HoTen,
		kh.DiaChi,
		hd.SoNgayThue,
		hd.DonGia,
		hd.ThanhTien,
		hd.PhuThu,
		hd.HeSo
	from tbl_HoaDon hd
	inner join tblPhieuThue pt on hd.IDPhieuThue = pt.ID
	inner join tbl_Phong p on pt.IDPhong = p.ID
	inner join tblKhachHang kh on pt.IDKH = kh.ID

		
end

exec loadDsHoaDon
GO
/****** Object:  StoredProcedure [dbo].[loadDsPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadDsPhong]
as
begin
	select 
	p.ID,
	lp.TenLoaiPhong,
	p.TenPhong,
	lp.DonGia,
	case 
		when p.TinhTrang=1 then N'Hoạt động'
		else N'Không hoạt động'
	end as TinhTrang
	from tbl_Phong p
	inner join tblLoaiPhong lp on IDLoaiPhong = lp.ID
end
GO
/****** Object:  StoredProcedure [dbo].[loadKhachHang]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loadKhachHang]	
as
begin
	select 
	kh.ID,
	kh.HoTen,
	kh.CMND,
	kh.DiaChi,
	lk.LoaiKhach
	from tblKhachHang kh
	inner join tblLoaiKhach lk on kh.IDLK = lk.ID
end
GO
/****** Object:  StoredProcedure [dbo].[loadLoaiKhach]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[loadLoaiKhach]
as
begin
	select * from tblLoaiKhach;
end

GO
/****** Object:  StoredProcedure [dbo].[loadLoaiPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[loadLoaiPhong]
as
begin
	select * from tblLoaiPhong;
end
GO
/****** Object:  StoredProcedure [dbo].[LoadPhieuThuePhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[LoadPhieuThuePhong]
as
begin
	select
		pt.ID,
		kh.HoTen,
		lk.LoaiKhach,
		kh.CMND,
		kh.DiaChi,
		p.TenPhong
	from tblPhieuThue pt
	inner join tblKhachHang kh on pt.IDKH = kh.ID
	inner join tblLoaiKhach lk on kh.IDLK=lk.ID
	inner join tbl_Phong p on pt.IDPhong=p.ID
	
end

exec LoadPhieuThuePhong
GO
/****** Object:  StoredProcedure [dbo].[NhapHoaDon]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[NhapHoaDon]
	@idPhieuThue int,
	@soNgayThue int,
	@phuThu float,
	@heSo float
	
as
begin
	insert into tbl_HoaDon(IDPhieuThue,SoNgayThue,DonGia,PhuThu,HeSo)
	values (
		@idPhieuThue,
		@soNgayThue,
			(select
				lp.DonGia
			from tblPhieuThue pt
			inner join tbl_Phong p on pt.IDPhong = p.ID
			inner join tblLoaiPhong lp on p.IDLoaiPhong = lp.ID
			where pt.ID = @idPhieuThue),	
		@phuThu,
		@heSo
			/*(select 
				lk.HeSo
			from tblPhieuThue pt
			inner join tblKhachHang kh on pt.IDKH=kh.ID
			inner join tblLoaiKhach lk on kh.IDLK=lk.ID
			where pt.ID=@idPhieuThue
			)*/
		)
	if @@ROWCOUNT > 0 return 1
	else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[themKhachHang]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themKhachHang]
	@idLoaiKhach int,
	@hoTen nvarchar(50),
	@cmnd varchar(20),
	@diaChi nvarchar(100)
	
as
begin
	insert into tblKhachHang values(@hoTen,@cmnd,@diaChi,@idLoaiKhach);
	if @@ROWCOUNT > 0 return 1;
	else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[themLoaiKhach]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themLoaiKhach]
	@tenLoaiKhach nvarchar(20),
	@heSo float
as
begin
	insert into tblLoaiKhach values(@tenLoaiKhach,@heSo);
	if @@ROWCOUNT > 0 return 1;
	else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[themLoaiPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[themLoaiPhong]
	@tenLoaiPhong nchar(10),
	@donGia float,
	@ghiChu nvarchar(50)
as
begin
	insert into tblLoaiPhong values(@tenLoaiPhong, @donGia, @ghiChu);
	if @@ROWCOUNT > 0 return 1;
	else return 0;
end
GO
/****** Object:  StoredProcedure [dbo].[TinhTongTien]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TinhTongTien]
    @DonGia DECIMAL(18, 2),
    @PhuThu DECIMAL(18, 2),
    @SoNgayThue INT,
    @HeSo DECIMAL(18, 2),
    @ThanhTien DECIMAL(18, 2) OUTPUT
AS
BEGIN
    SET @ThanhTien = (@DonGia + @DonGia * @PhuThu) * @SoNgayThue * @HeSo;
END
GO
/****** Object:  StoredProcedure [dbo].[updatePhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updatePhong]
@idPhong int,
@tenPhong nvarchar(50),
@idLoaiPhong int,
@tinhTrang tinyint
as
begin
	update tbl_Phong
	set TenPhong = @tenPhong,
		IDLoaiPhong = @idLoaiPhong,
		TinhTrang = @tinhTrang
	where 
		ID = @idPhong --chỉ update 1 phòng có id = id truyền vào
	if @@ROWCOUNT > 0 return 1 --nếu update thành công trả về 1
	else return 0
end
GO
/****** Object:  StoredProcedure [dbo].[xoaLoaiPhong]    Script Date: 12/15/2023 9:53:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaLoaiPhong]
	@idLoaiPhong int
as
begin
	delete from tblLoaiPhong where ID = @idLoaiPhong
	if @@ROWCOUNT > 0 return 1 
	else return 0
end
GO
USE [master]
GO
ALTER DATABASE [QLKhachSan] SET  READ_WRITE 
GO
