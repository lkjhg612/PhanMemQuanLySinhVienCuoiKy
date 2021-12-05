USE [QUANLYSINHVIEN]
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 12/5/2021 11:00:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIEM](
	[MaSV] [int] NOT NULL,
	[MaMH] [int] NOT NULL,
	[DiemQuaTrinh] [float] NULL,
	[DiemGiuaKy] [float] NULL,
	[DiemCuoiKy] [float] NULL,
 CONSTRAINT [PK_DIEM] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/5/2021 11:00:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MaKhoa] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 12/5/2021 11:00:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOP](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaKhoa] [int] NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 12/5/2021 11:00:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MaMH] [int] IDENTITY(1,1) NOT NULL,
	[TenMH] [nvarchar](20) NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 12/5/2021 11:00:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[ID_ND] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiDung] [nvarchar](20) NULL,
	[TaiKhoan] [nvarchar](10) NULL,
	[MatKhau] [nvarchar](10) NULL,
	[ID_Quyen] [int] NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[ID_ND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 12/5/2021 11:00:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QUYEN](
	[ID_Quyen] [int] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](10) NULL,
	[MoTa] [nvarchar](50) NULL,
 CONSTRAINT [PK_QUYEN] PRIMARY KEY CLUSTERED 
(
	[ID_Quyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 12/5/2021 11:00:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MaSV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NTNS] [datetime] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[MaLop] [int] NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (1, 5, 7, 8, 9)
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (1, 8, 9, 10, 10)
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (1, 9, 8, 8, 8)
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (2, 2, 7, 9, 10)
GO
SET IDENTITY_INSERT [dbo].[KHOA] ON 

INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (1, N'Công nghệ thông tin')
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (2, N'Luật')
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (3, N'Kinh tế')
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (4, N'Ngoại ngữ')
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (5, N'Báo chí')
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (8, N'Kỹ thuật')
SET IDENTITY_INSERT [dbo].[KHOA] OFF
GO
SET IDENTITY_INSERT [dbo].[LOP] ON 

INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (1, N'K13-CNTT1', 1)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (2, N'K14-CNTT2', 1)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (3, N'N11-L1', 2)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (4, N'N12-L2', 2)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (5, N'A12-KT1', 3)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (6, N'A12-KT2', 3)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (7, N'A13-KT4', 3)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (8, N'C9-BC1', 5)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (9, N'C8-BC2', 5)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (10, N'Y11-NN1', 4)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (11, N'Y10-NN2', 4)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (12, N'Y9-NN3', 4)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (13, N'K123-KT1', 8)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (14, N'K55-NN4', 4)
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (16, N'X45-KT2', 8)
SET IDENTITY_INSERT [dbo].[LOP] OFF
GO
SET IDENTITY_INSERT [dbo].[MONHOC] ON 

INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (1, N'Toán cao cấp')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (2, N'Toán rời rạc')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (3, N'Anh văn cơ bản')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (5, N'Lập trình')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (7, N'Tiếng Nhật')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (8, N'Luật ')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (9, N'Kinh tế ')
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (10, N'Quản trị')
SET IDENTITY_INSERT [dbo].[MONHOC] OFF
GO
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] ON 

INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen]) VALUES (1, N'Cường', N'cuong123', N'123123', 2)
INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen]) VALUES (2, N'Khang', N'khang123', N'321321', 2)
INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen]) VALUES (3, N'Nguyễn B', N'gv1', N'1', 1)
INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen]) VALUES (4, N'Phạm C', N'gv2', N'2', 1)
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] OFF
GO
SET IDENTITY_INSERT [dbo].[QUYEN] ON 

INSERT [dbo].[QUYEN] ([ID_Quyen], [TenQuyen], [MoTa]) VALUES (1, N'Admin', N'Giảng viên đăng nhập')
INSERT [dbo].[QUYEN] ([ID_Quyen], [TenQuyen], [MoTa]) VALUES (2, N'Member', N'Sinh viên đăng nhập')
SET IDENTITY_INSERT [dbo].[QUYEN] OFF
GO
SET IDENTITY_INSERT [dbo].[SINHVIEN] ON 

INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (1, N'Nguyễn Huy Cường', N'Nam', CAST(N'2001-08-19T00:00:00.000' AS DateTime), N'Tây Ninh', 1)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (2, N'Trương Minh Khang', N'Nam', CAST(N'2001-08-20T01:00:00.000' AS DateTime), N'TP.HCM', 2)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (3, N'Lê Thị B', N'Nữ', CAST(N'2001-08-20T00:00:00.000' AS DateTime), N'Hà Nội', 5)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (5, N'Nguyễn Văn A', N'Nam', CAST(N'2001-08-07T00:00:00.000' AS DateTime), N'Tây Nguyên', 16)
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (7, N'Lê Thị C', N'Nữ', CAST(N'2001-08-20T00:00:00.000' AS DateTime), N'TP.HCM', 13)
SET IDENTITY_INSERT [dbo].[SINHVIEN] OFF
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_MONHOC1] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MONHOC] ([MaMH])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_MONHOC1]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_SINHVIEN1] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SINHVIEN] ([MaSV])
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_SINHVIEN1]
GO
ALTER TABLE [dbo].[LOP]  WITH CHECK ADD  CONSTRAINT [FK_LOP_KHOA1] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[KHOA] ([MaKhoa])
GO
ALTER TABLE [dbo].[LOP] CHECK CONSTRAINT [FK_LOP_KHOA1]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_QUYEN] FOREIGN KEY([ID_Quyen])
REFERENCES [dbo].[QUYEN] ([ID_Quyen])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_QUYEN]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP1] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP1]
GO
