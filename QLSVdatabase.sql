USE [QUANLYSINHVIEN]
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 14-Dec-21 4:40:54 PM ******/
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
/****** Object:  Table [dbo].[KHOA]    Script Date: 14-Dec-21 4:40:54 PM ******/
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
/****** Object:  Table [dbo].[LOP]    Script Date: 14-Dec-21 4:40:54 PM ******/
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
/****** Object:  Table [dbo].[MONHOC]    Script Date: 14-Dec-21 4:40:54 PM ******/
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
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 14-Dec-21 4:40:54 PM ******/
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
	[MaSV] [int] NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[ID_ND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QUYEN]    Script Date: 14-Dec-21 4:40:54 PM ******/
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
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 14-Dec-21 4:40:54 PM ******/
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
/****** Object:  Table [dbo].[THOIKHOABIEU]    Script Date: 14-Dec-21 4:40:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THOIKHOABIEU](
	[MaMH] [int] NOT NULL,
	[MaLop] [int] NOT NULL,
	[TietBatDau] [int] NULL,
	[TietKetThuc] [int] NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[MaThu] [int] NULL,
 CONSTRAINT [PK_THOIKHOABIEU] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THU]    Script Date: 14-Dec-21 4:40:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THU](
	[MaThu] [int] NOT NULL,
	[TenThu] [nvarchar](10) NULL,
 CONSTRAINT [PK_THU] PRIMARY KEY CLUSTERED 
(
	[MaThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (1, 1, 8, 8, 4)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (1, 4, 10, 10, 1)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (1, 7, 6, 10, 1)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (2, 2, 10, 10, 9)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (2, 4, 4, 5, 10)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (2, 7, 10, 9, 9)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (3, 6, 8, 10, 10)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (8, 1, 10, 10, 10)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (8, 4, 10, 10, 10)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (9, 1, 8, 3, 4)
GO
INSERT [dbo].[DIEM] ([MaSV], [MaMH], [DiemQuaTrinh], [DiemGiuaKy], [DiemCuoiKy]) VALUES (12, 13, 10, 9, 10)
GO
SET IDENTITY_INSERT [dbo].[KHOA] ON 
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (1, N'C??ng ngh??? th??ng tin')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (2, N'Lu???t')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (3, N'Kinh t???')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (4, N'Ngo???i ng???')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (5, N'B??o ch??')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (6, N'K??? thu???t ')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (8, N'??i???n t???')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (9, N'C?? kh??')
GO
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa]) VALUES (11, N'??m nh???c')
GO
SET IDENTITY_INSERT [dbo].[KHOA] OFF
GO
SET IDENTITY_INSERT [dbo].[LOP] ON 
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (1, N'K13-CNTT1', 1)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (2, N'K14-CNTT2', 1)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (5, N'A12-KT1', 3)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (6, N'A12-KT2', 3)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (7, N'A13-KT3', 3)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (8, N'C9-BC1', 5)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (10, N'Y11-NN1', 4)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (12, N'Y10-NN6', 4)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (13, N'K16-CNTT', 1)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (14, N'P09-KTPM1', 6)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (15, N'N09-BC1', 5)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (16, N'B09-L1', 2)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (17, N'Q1-KT4', 6)
GO
INSERT [dbo].[LOP] ([MaLop], [TenLop], [MaKhoa]) VALUES (20, N'AN-123', 11)
GO
SET IDENTITY_INSERT [dbo].[LOP] OFF
GO
SET IDENTITY_INSERT [dbo].[MONHOC] ON 
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (1, N'To??n cao c???p')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (2, N'To??n r???i r???c')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (3, N'Anh v??n c?? b???n')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (4, N'Tri???t h???c ')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (6, N'Qu???n tr??? h???c')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (7, N'Ti???ng Nh???t')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (8, N'Lu???t ')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (11, N'C?? s??? d??? li???u')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (12, N'Mobile')
GO
INSERT [dbo].[MONHOC] ([MaMH], [TenMH]) VALUES (13, N'Thanh nh???c')
GO
SET IDENTITY_INSERT [dbo].[MONHOC] OFF
GO
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] ON 
GO
INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen], [MaSV]) VALUES (1, N'C?????ng', N'cuong123', N'123123', 3, 1)
GO
INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen], [MaSV]) VALUES (2, N'Tr????ng Minh Khang', N'khang123', N'321321', 3, 2)
GO
INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen], [MaSV]) VALUES (3, N'Nguy???n V??n A', N'gv1', N'1', 1, NULL)
GO
INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen], [MaSV]) VALUES (4, N'Ph???m C', N'gv2', N'2', 2, NULL)
GO
INSERT [dbo].[NGUOIDUNG] ([ID_ND], [TenNguoiDung], [TaiKhoan], [MatKhau], [ID_Quyen], [MaSV]) VALUES (6, N'Nguy???n Th??? Thu Huy???n', N'123', N'123', 3, NULL)
GO
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] OFF
GO
SET IDENTITY_INSERT [dbo].[QUYEN] ON 
GO
INSERT [dbo].[QUYEN] ([ID_Quyen], [TenQuyen], [MoTa]) VALUES (1, N'Admin', N'Tr?????ng khoa')
GO
INSERT [dbo].[QUYEN] ([ID_Quyen], [TenQuyen], [MoTa]) VALUES (2, N'Teacher', N'Gi???ng vi??n')
GO
INSERT [dbo].[QUYEN] ([ID_Quyen], [TenQuyen], [MoTa]) VALUES (3, N'Student', N'Sinh vi??n')
GO
SET IDENTITY_INSERT [dbo].[QUYEN] OFF
GO
SET IDENTITY_INSERT [dbo].[SINHVIEN] ON 
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (1, N'Nguy???n Huy C?????ng', N'Nam', CAST(N'2001-08-19T00:00:00.000' AS DateTime), N'T??y Ninh', 15)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (2, N'Tr????ng Minh Khang', N'Nam', CAST(N'2001-08-20T01:00:00.000' AS DateTime), N'TP.HCM', 2)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (3, N'L?? Th??? B', N'N???', CAST(N'2001-08-20T01:00:00.000' AS DateTime), N'H?? N???i', 5)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (4, N'Ph???m Th??? C', N'N???', CAST(N'2001-08-10T00:00:00.000' AS DateTime), N'???? N???ng', 6)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (5, N'A', N'Nam', CAST(N'2021-12-24T00:00:00.000' AS DateTime), N'123', 8)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (6, N'B', N'N???', CAST(N'2021-12-22T00:00:00.000' AS DateTime), N'123S????', 5)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (7, N'Ph???m V??n B', N'Nam', CAST(N'2021-12-06T00:00:00.000' AS DateTime), N'42 Hamg T???', 7)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (8, N'Ph???m Ng???c S??n', N'Nam', CAST(N'2021-12-07T00:00:00.000' AS DateTime), N'Canada', 15)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (9, N'Nguy???n ????ng Khoa', N'Nam', CAST(N'2021-12-22T00:00:00.000' AS DateTime), N'Greece', 15)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (10, N'Nguy???n V??n C', N'Nam', CAST(N'2021-12-05T00:00:00.000' AS DateTime), N'TP.HCM', 15)
GO
INSERT [dbo].[SINHVIEN] ([MaSV], [HoTen], [GioiTinh], [NTNS], [DiaChi], [MaLop]) VALUES (12, N'Nguy???n Thanh T??ng', N'Nam', CAST(N'2021-12-23T00:00:00.000' AS DateTime), N'Th??i B??nh', 20)
GO
SET IDENTITY_INSERT [dbo].[SINHVIEN] OFF
GO
INSERT [dbo].[THOIKHOABIEU] ([MaMH], [MaLop], [TietBatDau], [TietKetThuc], [NgayBatDau], [NgayKetThuc], [MaThu]) VALUES (1, 1, 1, 1, CAST(N'2021-12-13T00:00:00.000' AS DateTime), CAST(N'2021-12-19T00:00:00.000' AS DateTime), 2)
GO
INSERT [dbo].[THOIKHOABIEU] ([MaMH], [MaLop], [TietBatDau], [TietKetThuc], [NgayBatDau], [NgayKetThuc], [MaThu]) VALUES (2, 1, 2, 3, CAST(N'2021-12-13T00:00:00.000' AS DateTime), CAST(N'2021-12-19T00:00:00.000' AS DateTime), 3)
GO
INSERT [dbo].[THOIKHOABIEU] ([MaMH], [MaLop], [TietBatDau], [TietKetThuc], [NgayBatDau], [NgayKetThuc], [MaThu]) VALUES (3, 1, 4, 5, CAST(N'2021-12-13T00:00:00.000' AS DateTime), CAST(N'2021-12-19T00:00:00.000' AS DateTime), 4)
GO
INSERT [dbo].[THOIKHOABIEU] ([MaMH], [MaLop], [TietBatDau], [TietKetThuc], [NgayBatDau], [NgayKetThuc], [MaThu]) VALUES (4, 1, 4, 5, CAST(N'2021-12-14T00:00:00.000' AS DateTime), CAST(N'2021-12-19T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[THU] ([MaThu], [TenThu]) VALUES (2, N'Th??? hai')
GO
INSERT [dbo].[THU] ([MaThu], [TenThu]) VALUES (3, N'Th??? ba')
GO
INSERT [dbo].[THU] ([MaThu], [TenThu]) VALUES (4, N'Th??? t??')
GO
INSERT [dbo].[THU] ([MaThu], [TenThu]) VALUES (5, N'Th??? n??m')
GO
INSERT [dbo].[THU] ([MaThu], [TenThu]) VALUES (6, N'Th??? s??u')
GO
INSERT [dbo].[THU] ([MaThu], [TenThu]) VALUES (7, N'Th??? b???y')
GO
INSERT [dbo].[THU] ([MaThu], [TenThu]) VALUES (8, N'Ch??? nh???t')
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
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_SINHVIEN] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SINHVIEN] ([MaSV])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_SINHVIEN]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP1] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP1]
GO
ALTER TABLE [dbo].[THOIKHOABIEU]  WITH CHECK ADD  CONSTRAINT [FK_THOIKHOABIEU_LOP] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOP] ([MaLop])
GO
ALTER TABLE [dbo].[THOIKHOABIEU] CHECK CONSTRAINT [FK_THOIKHOABIEU_LOP]
GO
ALTER TABLE [dbo].[THOIKHOABIEU]  WITH CHECK ADD  CONSTRAINT [FK_THOIKHOABIEU_MONHOC] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MONHOC] ([MaMH])
GO
ALTER TABLE [dbo].[THOIKHOABIEU] CHECK CONSTRAINT [FK_THOIKHOABIEU_MONHOC]
GO
ALTER TABLE [dbo].[THOIKHOABIEU]  WITH CHECK ADD  CONSTRAINT [FK_THOIKHOABIEU_THU] FOREIGN KEY([MaThu])
REFERENCES [dbo].[THU] ([MaThu])
GO
ALTER TABLE [dbo].[THOIKHOABIEU] CHECK CONSTRAINT [FK_THOIKHOABIEU_THU]
GO
