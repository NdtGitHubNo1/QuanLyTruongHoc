create database QuanLyTruongHoc
GO
USE [QuanLyTruongHoc]
GO

/****** Object:  Table [dbo].[tblCTGD]    Script Date: 2020-12-22 20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCTGD](
	[MaLop] [nchar](10) NOT NULL,
	[MaGV] [nchar](10) NULL,
	[NgayDay] [date] NOT NULL,
	[Tiet] [int] NOT NULL,
 CONSTRAINT [CTDG1_pk] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC,
	[NgayDay] ASC,
	[Tiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[tblGiaoVien]    Script Date: 2020-12-22 20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGiaoVien](
	[MaGV] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GT] [nchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
	[Luong] [bigint] NULL,
	[MaMon] [nchar](10) NULL,
 CONSTRAINT [PK_tblGiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHocSinh]    Script Date: 2020-12-22 20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHocSinh](
	[MaHS] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GT] [nchar](3) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[PhuHuynh] [nvarchar](50) NULL,
	[MaLop] [nchar](10) NULL,
 CONSTRAINT [PK_tblHocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLop]    Script Date: 2020-12-22 20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLop](
	[MaLop] [nchar](10) NOT NULL,
	[TenLop] [nchar](10) NOT NULL,
	[GVCN] [nchar](10) NULL,
 CONSTRAINT [PK_tblLop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMonHoc]    Script Date: 2020-12-22 20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonHoc](
	[MaMon] [nchar](10) NOT NULL,
	[TenMon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblMonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 2020-12-22 20:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000001', N'GV00000005', CAST(N'2021-01-29' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000001', N'GV00000005', CAST(N'2021-01-29' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000001', N'GV00000009', CAST(N'2021-01-30' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000001', N'GV00000007', CAST(N'2021-01-30' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000001', N'GV00000003', CAST(N'2021-02-02' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000001', N'GV00000003', CAST(N'2021-02-02' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000002', N'GV00000003', CAST(N'2021-02-05' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000002', N'GV00000003', CAST(N'2021-02-05' AS Date), 2)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000002', N'GV00000003', CAST(N'2021-02-05' AS Date), 3)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000002', N'GV00000009', CAST(N'2021-02-06' AS Date), 4)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000002', N'GV00000009', CAST(N'2021-02-06' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000002', N'GV00000009', CAST(N'2021-02-07' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000003', N'GV00000009', CAST(N'2021-02-07' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000003', N'GV00000009', CAST(N'2021-02-07' AS Date), 2)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000003', N'GV00000009', CAST(N'2021-02-08' AS Date), 3)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000003', N'GV00000004', CAST(N'2021-02-08' AS Date), 4)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000003', N'GV00000004', CAST(N'2021-02-08' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000003', N'GV00000004', CAST(N'2021-02-08' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000004', N'GV00000007', CAST(N'2021-02-09' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000004', N'GV00000007', CAST(N'2021-02-09' AS Date), 2)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000004', N'GV00000007', CAST(N'2021-02-09' AS Date), 3)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000004', N'GV00000007', CAST(N'2021-02-09' AS Date), 4)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000004', N'GV00000007', CAST(N'2021-02-09' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000004', N'GV00000007', CAST(N'2021-02-10' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000005', N'GV00000006', CAST(N'2021-02-10' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000005', N'GV00000006', CAST(N'2021-02-10' AS Date), 2)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000005', N'GV00000006', CAST(N'2021-02-10' AS Date), 3)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000005', N'GV00000006', CAST(N'2021-02-10' AS Date), 4)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000005', N'GV00000006', CAST(N'2021-02-10' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000005', N'GV00000006', CAST(N'2021-02-10' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000006', N'GV00000001', CAST(N'2021-02-10' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000006', N'GV00000001', CAST(N'2021-02-11' AS Date), 2)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000006', N'GV00000001', CAST(N'2021-02-11' AS Date), 3)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000006', N'GV00000001', CAST(N'2021-02-11' AS Date), 4)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000006', N'GV00000001', CAST(N'2021-02-11' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000006', N'GV00000001', CAST(N'2021-02-11' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000007', N'GV00000005', CAST(N'2021-02-12' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000007', N'GV00000005', CAST(N'2021-02-12' AS Date), 2)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000007', N'GV00000005', CAST(N'2021-02-12' AS Date), 3)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000007', N'GV00000005', CAST(N'2021-02-12' AS Date), 4)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000007', N'GV00000005', CAST(N'2021-02-12' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000007', N'GV00000005', CAST(N'2021-02-12' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000008', N'GV00000009', CAST(N'2021-02-12' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000008', N'GV00000009', CAST(N'2021-02-12' AS Date), 2)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000008', N'GV00000009', CAST(N'2021-02-12' AS Date), 3)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000008', N'GV00000009', CAST(N'2021-02-12' AS Date), 4)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000008', N'GV00000009', CAST(N'2021-02-12' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000008', N'GV00000009', CAST(N'2021-02-12' AS Date), 6)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000009', N'GV00000008', CAST(N'2021-02-13' AS Date), 1)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000009', N'GV00000008', CAST(N'2021-02-13' AS Date), 2)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000009', N'GV00000008', CAST(N'2021-02-13' AS Date), 3)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000009', N'GV00000008', CAST(N'2021-02-13' AS Date), 4)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000009', N'GV00000008', CAST(N'2021-02-13' AS Date), 5)
INSERT [dbo].[tblCTGD] ([MaLop], [MaGV], [NgayDay], [Tiet]) VALUES (N'LOP0000009', N'GV00000008', CAST(N'2021-02-13' AS Date), 6)
GO
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000001', N'Lê Viết Hoàng Anh', N'Nam', CAST(N'2020-12-22' AS Date), N'Nghệ An', 365366349, 7000000, N'MH02      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000002', N'Đoàn Tiến Đạt', N'Nam', CAST(N'1976-02-02' AS Date), N'Hải Phòng', 986574325, 8000000, N'MH05      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000003', N'Lê Tiến Dũng', N'Nam', CAST(N'1975-03-19' AS Date), N'Thanh Hóa', 986574321, 13000000, N'MH01      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000004', N'Trần Thị Huyền', N'Nu ', CAST(N'1975-04-30' AS Date), N'Hà Tĩnh', 235698753, 8000000, N'MH06      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000005', N'Bạch Thị Diệu Linh', N'Nu ', CAST(N'1977-05-01' AS Date), N'Hòa Bình', 369852365, 7000000, N'MH03      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000006', N'Đoàn Quang Long', N'Nam', CAST(N'1930-02-03' AS Date), N'Hải Dương', 983652147, 7500000, N'MH01      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000007', N'Phạm Văn Lượng', N'Nam', CAST(N'1977-05-27' AS Date), N'Ninh Bình', 856987135, 8000000, N'MH07      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000008', N'Nguyễn Hòa Nhật Quang', N'Nam', CAST(N'1982-07-07' AS Date), N'An Giang', 236987452, 5000000, N'MH05      ')
INSERT [dbo].[tblGiaoVien] ([MaGV], [HoTen], [GT], [NgaySinh], [DiaChi], [SDT], [Luong], [MaMon]) VALUES (N'GV00000009', N'Lê Thành Trung', N'Nam', CAST(N'1960-02-29' AS Date), N'Điện Biên', 456987565, 10000000, N'MH04      ')
GO
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000001', N'Đặng Đức Anh', N'Nam', CAST(N'2003-12-21' AS Date), N'Hà Nội', N'Nguyễn Anh Dũng', N'LOP0000001')
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000002', N'Lê Tuấn Minh', N'Nam', CAST(N'2003-02-13' AS Date), N'Hà Nội', N'Nguyễn Thị Kim Khánh', N'LOP0000009')
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000003', N'Hoàng Đình Đạt', N'Nam', CAST(N'2005-02-15' AS Date), N'Hà Nội', N'Nguyễn Thị Thanh', N'LOP0000005')
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000004', N'Lương Văn Luận', N'Nam', CAST(N'2005-12-06' AS Date), N'Hà Nội', N'Huỳnh Văn Tá', N'LOP0000001')
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000005', N'Trần Minh Nghiệp', N'Nam', CAST(N'2005-08-18' AS Date), N'Hà Nội', N'Lê Anh Thắng', N'LOP0000002')
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000006', N'Nguyễn Đình Minh', N'Nam', CAST(N'2004-02-14' AS Date), N'Hà Nội', N'Nguyễn Mai Chi', N'LOP0000006')
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000007', N'Võ Khương Lĩnh', N'Nam', CAST(N'2004-04-01' AS Date), N'Hà Nội', N'Nguyễn Huy Hoàng', N'LOP0000005')
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000008', N'Nguyễn Chí Công', N'Nam', CAST(N'2004-03-26' AS Date), N'Hà Nội', N'Nguyễn Quốc Thiện', N'LOP0000004')
INSERT [dbo].[tblHocSinh] ([MaHS], [HoTen], [GT], [NgaySinh], [DiaChi], [PhuHuynh], [MaLop]) VALUES (N'HS00000009', N'Phí Xuân Đạo', N'Nam', CAST(N'2005-06-03' AS Date), N'Hà Nội', N'Lưu Thị Sâm', N'LOP0000008')
GO
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000001', N'10A       ', N'GV00000001')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000002', N'10B       ', N'GV00000006')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000003', N'10C       ', N'GV00000004')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000004', N'11A       ', N'GV00000002')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000005', N'11B       ', N'GV00000005')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000006', N'11C       ', N'GV00000003')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000007', N'12A       ', N'GV00000009')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000008', N'12B       ', N'GV00000007')
INSERT [dbo].[tblLop] ([MaLop], [TenLop], [GVCN]) VALUES (N'LOP0000009', N'12C       ', N'GV00000008')
GO
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon]) VALUES (N'MH01      ', N'Toán')
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon]) VALUES (N'MH02      ', N'Vật Lý')
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon]) VALUES (N'MH03      ', N'Hóa Học')
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon]) VALUES (N'MH04      ', N'Ngữ Văn')
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon]) VALUES (N'MH05      ', N'Lịch Sử')
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon]) VALUES (N'MH06      ', N'Địa Lý')
INSERT [dbo].[tblMonHoc] ([MaMon], [TenMon]) VALUES (N'MH07      ', N'Tiếng Anh')
GO
INSERT [dbo].[tblUser] ([Username], [Password]) VALUES (N'admin', N'admin')
GO
ALTER TABLE [dbo].[tblCTGD]  WITH CHECK ADD FOREIGN KEY([MaGV])
REFERENCES [dbo].[tblGiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[tblCTGD]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[tblLop] ([MaLop])
GO
ALTER TABLE [dbo].[tblGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_tblGiaoVien_tblMonHoc] FOREIGN KEY([MaMon])
REFERENCES [dbo].[tblMonHoc] ([MaMon])
GO
ALTER TABLE [dbo].[tblGiaoVien] CHECK CONSTRAINT [FK_tblGiaoVien_tblMonHoc]
GO
ALTER TABLE [dbo].[tblHocSinh]  WITH CHECK ADD  CONSTRAINT [FK_tblHocSinh_tblLop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[tblLop] ([MaLop])
GO
ALTER TABLE [dbo].[tblHocSinh] CHECK CONSTRAINT [FK_tblHocSinh_tblLop]
GO
ALTER TABLE [dbo].[tblLop]  WITH CHECK ADD  CONSTRAINT [FK_tblLop_tblGiaoVien] FOREIGN KEY([GVCN])
REFERENCES [dbo].[tblGiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[tblLop] CHECK CONSTRAINT [FK_tblLop_tblGiaoVien]
GO