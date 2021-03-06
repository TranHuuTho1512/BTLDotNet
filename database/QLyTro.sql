USE [QuanLyTro]
GO
/****** Object:  Table [dbo].[tblChuTro]    Script Date: 6/30/2020 1:59:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChuTro](
	[IDChuTro] [nvarchar](20) NOT NULL,
	[TenChuTro] [nvarchar](100) NOT NULL,
	[CMNDChuTro] [nvarchar](15) NOT NULL,
	[DiaChiChuTro] [nvarchar](100) NOT NULL,
	[SDTChuTro] [int] NOT NULL,
	[EmailChuTro] [nvarchar](100) NULL,
	[TrangThaiChoThue] [nvarchar](20) NOT NULL,
	[Pass] [nvarchar](20) NULL,
 CONSTRAINT [PK_tblChuTro] PRIMARY KEY CLUSTERED 
(
	[IDChuTro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 6/30/2020 1:59:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhong](
	[IDPhong] [nvarchar](20) NOT NULL,
	[TrangThaiPhong] [nvarchar](50) NOT NULL,
	[GiaPhong] [money] NOT NULL,
	[SoLuongSVSong] [int] NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[IDChuTro] [nvarchar](20) NOT NULL,
	[NgayBatDau] [date] NULL,
 CONSTRAINT [PK__tblPhong__81CB11524D73AFF8] PRIMARY KEY CLUSTERED 
(
	[IDPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 6/30/2020 1:59:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[MSSV] [nvarchar](20) NOT NULL,
	[TenSV] [nvarchar](50) NOT NULL,
	[QueQuanSV] [nvarchar](25) NOT NULL,
	[SDTSV] [nvarchar](50) NOT NULL,
	[NamSinhSV] [date] NULL,
	[TruongHoc] [nvarchar](50) NOT NULL,
	[KhoaSV] [nvarchar](20) NULL,
	[IDPhong] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_tblSinhVien] PRIMARY KEY CLUSTERED 
(
	[MSSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChuTro] ([IDChuTro], [TenChuTro], [CMNDChuTro], [DiaChiChuTro], [SDTChuTro], [EmailChuTro], [TrangThaiChoThue], [Pass]) VALUES (N'18038171  ', N'Trần Hữu Thọ', N'123456789      ', N'HCM', 123456789, N'tranhuutho@gmail.com                              ', N'Còn                 ', N'123456              ')
INSERT [dbo].[tblChuTro] ([IDChuTro], [TenChuTro], [CMNDChuTro], [DiaChiChuTro], [SDTChuTro], [EmailChuTro], [TrangThaiChoThue], [Pass]) VALUES (N'18053681  ', N'Lê Nguyễn Thành Vinh', N'123456789', N'HCM', 123456789, N'lenguyenthanhvinh@gmail.com', N'Còn', N'123456              ')
INSERT [dbo].[tblChuTro] ([IDChuTro], [TenChuTro], [CMNDChuTro], [DiaChiChuTro], [SDTChuTro], [EmailChuTro], [TrangThaiChoThue], [Pass]) VALUES (N'18061881  ', N'Nguyễn Duy Đường Vũ ', N'123456789      ', N'HCM', 123456789, N'nguyenduyduongvu@gmail.com                        ', N'Còn                 ', N'123456              ')
INSERT [dbo].[tblChuTro] ([IDChuTro], [TenChuTro], [CMNDChuTro], [DiaChiChuTro], [SDTChuTro], [EmailChuTro], [TrangThaiChoThue], [Pass]) VALUES (N'18069461  ', N'Nguyễn Ngọc Hậu', N'123456789', N'HCM', 123456789, N'nguyenngochau@gmail.com', N'Còn', N'123456              ')
INSERT [dbo].[tblChuTro] ([IDChuTro], [TenChuTro], [CMNDChuTro], [DiaChiChuTro], [SDTChuTro], [EmailChuTro], [TrangThaiChoThue], [Pass]) VALUES (N'18078251  ', N'Nguyễn Thành Lâm', N'123456789', N'HCM', 123456789, N'nguyenthanhlam@gmail.com', N'Còn', N'123456              ')
GO
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'1         ', N'Còn       ', 2000000.0000, 5, N'A1.1      ', N'18038171  ', CAST(N'2019-12-05' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'10        ', N'Hết       ', 1500000.0000, 5, N'B1.2      ', N'18053681  ', CAST(N'2018-12-03' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'11        ', N'Còn       ', 2000000.0000, 6, N'A1.1      ', N'18061881  ', CAST(N'2019-03-05' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'12        ', N'Hết       ', 1500000.0000, 5, N'A1.2      ', N'18061881  ', CAST(N'2018-05-12' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'13        ', N'Hết       ', 2500000.0000, 5, N'A1.3      ', N'18061881  ', CAST(N'2017-11-10' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'14        ', N'Hết', 2000000.0000, 5, N'B1.1      ', N'18061881  ', CAST(N'2019-02-27' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'15        ', N'Hết       ', 2400000.0000, 5, N'B1.2      ', N'18061881  ', CAST(N'2018-11-12' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'16        ', N'Hết       ', 1500000.0000, 5, N'A1.1      ', N'18069461  ', CAST(N'2019-11-09' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'17        ', N'Còn       ', 2500000.0000, 5, N'A1.2      ', N'18069461  ', CAST(N'2019-03-26' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'18        ', N'Còn       ', 3500000.0000, 5, N'A1.3      ', N'18069461  ', CAST(N'2018-10-10' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'19        ', N'Hết       ', 2500000.0000, 5, N'B1.1      ', N'18069461  ', CAST(N'2017-03-19' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'2         ', N'Hết       ', 2000000.0000, 5, N'A1.2      ', N'18038171  ', CAST(N'2018-04-11' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'20        ', N'Hết       ', 3000000.0000, 5, N'B1.2      ', N'18069461  ', CAST(N'2018-12-10' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'21        ', N'Còn       ', 2500000.0000, 5, N'A1.1      ', N'18078251  ', CAST(N'2019-05-19' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'22        ', N'Còn       ', 3000000.0000, 5, N'A1.2      ', N'18078251  ', CAST(N'2017-01-15' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'23        ', N'Còn       ', 1500000.0000, 5, N'A1.3      ', N'18078251  ', CAST(N'2019-11-12' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'24        ', N'Hết       ', 2000000.0000, 5, N'B1.1      ', N'18078251  ', CAST(N'2018-06-01' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'25        ', N'Còn       ', 3000000.0000, 5, N'B1.2      ', N'18078251  ', CAST(N'2019-11-20' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'3         ', N'Hết       ', 2000000.0000, 5, N'A1.3      ', N'18038171  ', CAST(N'2018-05-20' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'4         ', N'Hết       ', 2000000.0000, 5, N'B1.1      ', N'18038171  ', CAST(N'2018-05-01' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'5         ', N'Hết       ', 3000000.0000, 5, N'B1.2      ', N'18038171  ', CAST(N'2019-06-03' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'6         ', N'Còn       ', 3000000.0000, 5, N'A1.1      ', N'18053681  ', CAST(N'2018-08-04' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'7         ', N'Hết       ', 1000000.0000, 5, N'A1.2      ', N'18053681  ', CAST(N'2018-11-11' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'8         ', N'Còn       ', 2000000.0000, 5, N'A1.3      ', N'18053681  ', CAST(N'2018-12-15' AS Date))
INSERT [dbo].[tblPhong] ([IDPhong], [TrangThaiPhong], [GiaPhong], [SoLuongSVSong], [TenPhong], [IDChuTro], [NgayBatDau]) VALUES (N'9         ', N'Còn       ', 1000000.0000, 5, N'B1.1      ', N'18053681  ', CAST(N'2017-01-20' AS Date))
GO
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1801      ', N'Trần Nguyên Giáp', N'HCM', N'0990222212     ', CAST(N'2000-01-02' AS Date), N'IUH', N'May', N'1         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1802      ', N'Phạm Văn Đồng', N'Hà Nội', N'0124568539     ', CAST(N'1998-01-01' AS Date), N'IUH', N'Cơ Điện Tử', N'1         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1803      ', N'Nguyễn Xí', N'Sóc Trăng', N'0966442528     ', CAST(N'1999-03-05' AS Date), N'IUH', N'MK', N'1         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1804      ', N'Phan Đăng Lưu', N'Cà Mau', N'0961230982     ', CAST(N'1999-03-05' AS Date), N'IUH', N'MK', N'1         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1805      ', N'Nguyễn Kiệm', N'An Giang', N'0987272801     ', CAST(N'1999-03-05' AS Date), N'IUH', N'CNTT', N'1         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1806      ', N'Phan Huy Ích', N'Phú Yên', N'0961232223     ', CAST(N'1999-03-05' AS Date), N'IUH', N'CNTT', N'2         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1807      ', N'Phạm Văn Chiêu', N'Bình Định', N'0127387830     ', CAST(N'2000-07-12' AS Date), N'IUH', N'Xây Dựng', N'2         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1808      ', N'Trần Minh Nghĩa', N'Vũng Tàu', N'0192388266     ', CAST(N'2000-08-15' AS Date), N'IUH', N'NNA', N'2         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1809      ', N'Trần Dần', N'Ca Mau', N'0561728022     ', CAST(N'1996-09-18' AS Date), N'IUH', N'KT', N'2         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1810      ', N'Trần Hoàng Long', N'Bắc Ninh', N'0912333441     ', CAST(N'1998-08-20' AS Date), N'IUH', N'Hóa', N'2         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1811      ', N'Nguyễn Văn Hoàng', N'Hà Nội', N'0123456789     ', CAST(N'1999-01-20' AS Date), N'IUH', N'NNA', N'3         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1812      ', N'Bùi Thành Nam', N'Trà Vinh', N'0189237890     ', CAST(N'1997-02-27' AS Date), N'IUH', N'Sinh Học', N'3         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1813      ', N'Nguyễn Thế Vinh', N'Phú Thọ', N'0356112889     ', CAST(N'1999-03-04' AS Date), N'IUH', N'May', N'3         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1814      ', N'Nguyễn Ninh', N'Kiên Giang', N'0328890911     ', CAST(N'1999-09-28' AS Date), N'IUH', N'Điện Tử', N'3         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1815      ', N'Đào Duy Anh', N'Hà Nội', N'0318902371     ', CAST(N'1998-12-12' AS Date), N'IUH', N'Cơ Khí', N'3         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1816      ', N'Trường Chinh', N'Hà Nam', N'0346763780     ', CAST(N'1999-01-15' AS Date), N'IUH', N'May', N'4         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1817      ', N'Âu Cơ', N'Phú Thọ', N'0126487991     ', CAST(N'2000-12-20' AS Date), N'IUH', N'NNA', N'4         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1818      ', N'Lạc Long Quân ', N'Hải Phòng', N'0389200123     ', CAST(N'2000-05-18' AS Date), N'IUH', N'CNTT', N'4         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1819      ', N'Phạm Văn Bạch', N'Hà Nội', N'0128938942     ', CAST(N'2000-10-09' AS Date), N'IUH', N'Cơ Khí', N'4         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1820      ', N'Nguyễn Bỉnh Khiêm', N'Lâm Đồng', N'0572993119     ', CAST(N'1999-11-01' AS Date), N'IUH', N'Thiết Kế', N'4         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1821      ', N'Nguyễn Trãi', N'ĐắkLắc', N'0367822910     ', CAST(N'1997-12-21' AS Date), N'IUH', N'Nhiệt Lạnh', N'5         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1822      ', N'Nguyễn Chí Hùng', N'Ninh Thuận ', N'0933882891     ', CAST(N'1998-03-26' AS Date), N'IUH', N'Cơ Khí', N'5         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1823      ', N'Lý Thường Kiệt', N'Bình Thuận', N'0977328900     ', CAST(N'1999-02-09' AS Date), N'IUH', N'NNA', N'5         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1824      ', N'Lê Duẩn', N'Cà Mau', N'0978128889     ', CAST(N'1999-10-19' AS Date), N'IUH', N'CNTT', N'5         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1825      ', N'Võ Văn Ngân', N'Kiên Giang', N'0923382086     ', CAST(N'2000-12-12' AS Date), N'IUH', N'May', N'5         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1826      ', N'Trần Lê Bảo Trân', N'Bến Tre', N'0977729028     ', CAST(N'2001-05-19' AS Date), N'IUH', N'Cơ Điện Tử', N'6         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1827      ', N'Nguyễn Thị Minh Khai', N'Lào Cai', N'0562778009     ', CAST(N'2000-12-16' AS Date), N'IUH', N'May', N'6         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1828      ', N'Nguyễn Thị Bích Thảo', N'Hưng Yên', N'0893038012     ', CAST(N'1999-05-06' AS Date), N'IUH', N'Ô Tô', N'6         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1829      ', N'Lê Thị Riêng', N'Điện Biên', N'0972683789     ', CAST(N'1999-01-12' AS Date), N'IUH', N'QTKS', N'6         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1830      ', N'Phan Văn Trị', N'Quảng Trị', N'0923338179     ', CAST(N'2001-10-09' AS Date), N'IUH', N'MK', N'7         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1831      ', N'Lê Đức Thọ', N'Phú Thọ', N'0293888653     ', CAST(N'2000-01-02' AS Date), N'IUH', N'TMDL', N'7         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1832      ', N'Bùi Quang Trung', N'Hòa Bình', N'0982229304     ', CAST(N'2001-11-07' AS Date), N'IUH', N'Nhiệt Lạnh', N'7         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1833      ', N'Cù Chính Lan', N'Hà Giang', N'0927746888     ', CAST(N'2000-12-07' AS Date), N'IUH', N'May', N'8         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1834      ', N'Nguyễn Lan Hương', N'Quảng Bình', N'0927782761     ', CAST(N'1999-07-27' AS Date), N'IUH', N'QTKS', N'8         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1835      ', N'Nguyễn Thị Qua Môn', N'Bình Định', N'0283824003     ', CAST(N'2001-12-03' AS Date), N'IUH', N'NNA', N'8         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1836      ', N'Trần Đoàn', N'Hòa Bình', N'0928734768     ', CAST(N'2000-10-01' AS Date), N'IUH', N'Thiết Kế', N'9         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1837      ', N'Lùi Thị Tiến Lên', N'Quảng Ninh', N'0374802800     ', CAST(N'2001-11-01' AS Date), N'IUH', N'Cơ Khí', N'9         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1838      ', N'Nguyễn Đường Tăng', N'Quảng Nam', N'0984479379     ', CAST(N'1998-03-03' AS Date), N'IUH', N'Điện Tử', N'9         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1839      ', N'Tôn Ngộ Nghĩnh', N'Thừa Thiên Huế', N'0928383482     ', CAST(N'1999-02-01' AS Date), N'IUH', N'Kế Toán', N'9         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1840      ', N'Bạch Cốt Tinh', N'Quảng Ninh', N'0283402282     ', CAST(N'2001-04-01' AS Date), N'IUH', N'An Ninh', N'9         ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1841      ', N'Huyện Thanh Quan', N'An Giang', N'0299234488     ', CAST(N'2000-12-17' AS Date), N'IUH', N'Ngân Hàng', N'10        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1842      ', N'Hồ Xuân Hương', N'Lâm Đồng', N'0283769209     ', CAST(N'2001-02-19' AS Date), N'IUH', N'May', N'10        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1843      ', N'Đào Thị Vàng ', N'Hà Giang', N'0293884663     ', CAST(N'1999-09-18' AS Date), N'IUH', N'Ngân Hàng', N'10        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1845      ', N'Tăng Thành Đạt', N'Nghệ An', N'0926472890     ', CAST(N'1999-09-12' AS Date), N'IUH', N'CNTT', N'10        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1846', N'Lê Luân', N'Hà Nội', N'0928379128', CAST(N'1999-01-07' AS Date), N'IUH', N'CNTT', N'11        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1847      ', N'Lê Luân', N'Hà Nội', N'0928379128', CAST(N'1999-01-07' AS Date), N'IUH', N'Cơ Khí', N'11        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1848      ', N'Lê Văn Minh', N'An Giang', N'0982726641     ', CAST(N'2001-12-02' AS Date), N'IUH', N'QTKS', N'11        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1849      ', N'Bùi Thị Thúy Kiều', N'Bắc Ninh', N'0922793789     ', CAST(N'2000-07-08' AS Date), N'IUH', N'May', N'11        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1850      ', N'Nguyễn Ngọc Bích', N'Bình Thuận ', N'0925673978     ', CAST(N'2000-01-09' AS Date), N'IUH', N'Hóa ', N'11        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1851      ', N'Sa Ngộ Tĩnh', N'Bình Định', N'0927654728     ', CAST(N'2001-05-19' AS Date), N'IUH', N'NNA', N'12        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1852      ', N'Trư Ngộ Năng', N'An Giang', N'0927389479     ', CAST(N'1999-11-12' AS Date), N'IUH', N'Điện Tử', N'12        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1853      ', N'Nguyễn Đường Giảm', N'Quảng Ngãi', N'0982652381     ', CAST(N'1998-10-10' AS Date), N'IUH', N'QTKS', N'12        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1854      ', N'Trần Minh Nghĩa', N'Khánh Hòa', N'0837739917     ', CAST(N'1998-12-03' AS Date), N'IUH', N'CNTT', N'12        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1855      ', N'Nguyễn Nhật Hưng', N'Khánh Hòa ', N'0982653899     ', CAST(N'1999-03-15' AS Date), N'IUH', N'CNTT', N'13        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1856      ', N'Nguyễn Văn Hà ', N'Thanh Hóa', N'0928736899     ', CAST(N'2000-12-19' AS Date), N'IUH', N'Thiết Kế', N'13        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1857      ', N'Trần Thanh Duy', N'Bình Thuận ', N'0878839262     ', CAST(N'2000-08-15' AS Date), N'IUH', N'Xây Dựng', N'13        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1858      ', N'Nguyễn Quốc Huy', N'Ninh Thuận ', N'0949802922     ', CAST(N'1999-12-10' AS Date), N'IUH', N'Điện Tử', N'13        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1859      ', N'Nguyễn Thanh Hoài', N'Đồng Nai', N'0827849009     ', CAST(N'2000-11-02' AS Date), N'IUH', N'CNTT', N'14        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1860      ', N'Trương Thành Lộc', N'Sóc Trăng', N'0397469232     ', CAST(N'1999-06-25' AS Date), N'IUH', N'May', N'14        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1861      ', N'Lê Thành Vinh', N'HCM', N'0977463535     ', CAST(N'2000-12-08' AS Date), N'IUH', N'Ngân Hàng', N'14        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1862      ', N'Văn Minh Hoàng', N'Đồng Tháp', N'0872993701     ', CAST(N'1999-12-09' AS Date), N'IUH', N'May', N'14        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1863      ', N'Nguyễn Hồng Nhung', N'Bình Thuận', N'0982725880     ', CAST(N'2000-08-09' AS Date), N'IUH', N'Kế Toán', N'15        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1864      ', N'Nguyễn Thị Bích Đào', N'Cần Thơ', N'0928726577     ', CAST(N'1999-12-04' AS Date), N'IUH', N'QTKS', N'15        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1865      ', N'Trương Thị Diễm', N'Vĩnh Long', N'0988265151     ', CAST(N'2000-11-08' AS Date), N'IUH', N'Ngân Hàng', N'15        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1866      ', N'Nguyễn Thành Liêu', N'Quảng Nam', N'0912727333     ', CAST(N'2000-12-14' AS Date), N'IUH', N'Cơ Khí', N'15        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1867      ', N'Nguyễn Quốc Bảo', N'Bình Thuận', N'0192838383     ', CAST(N'2000-09-15' AS Date), N'IUH', N'May', N'16        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1868      ', N'Trần Khánh Trung', N'Ninh Thuận', N'0928376671     ', CAST(N'1999-10-18' AS Date), N'IUH', N'Điện Tử', N'16        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1869      ', N'Mai Quốc Khánh', N'Bắc Giang', N'0128389991     ', CAST(N'1999-12-03' AS Date), N'IUH', N'QTKS', N'16        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1870      ', N'Trần Ngọc Duy', N'Cà Mau', N'0982637899     ', CAST(N'1998-03-25' AS Date), N'IUH', N'Thiết Kế', N'16        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1871      ', N'Phan Duy Mạnh', N'Vĩnh Long', N'0928378818     ', CAST(N'1999-03-22' AS Date), N'IUH', N'Ngân Hàng', N'17        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1872      ', N'Phan Mạnh Quỳnh', N'Kiên Giang', N'0992366723     ', CAST(N'1998-11-08' AS Date), N'IUH', N'CNTT', N'17        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1873      ', N'Nguyễn Chí Toàn', N'Hậu Giang', N'0182737881     ', CAST(N'1999-12-09' AS Date), N'IUH', N'May', N'17        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1874      ', N'Nguyễn Chí Tĩnh', N'Bạc Liêu', N'0192883667     ', CAST(N'2000-12-07' AS Date), N'IUH', N'Cơ Khí', N'17        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1875      ', N'Bùi Công Tiến', N'Cần Thơ', N'0388366282     ', CAST(N'2000-05-15' AS Date), N'IUH', N'Ngân Hàng', N'17        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1876      ', N'Lê Võ Hữu Thái', N'Thanh Hóa', N'0938766121     ', CAST(N'1999-12-07' AS Date), N'IUH', N'Xây Dựng', N'18        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1877      ', N'Trần Thành Công', N'Đắc Nông', N'0298377712     ', CAST(N'1999-12-09' AS Date), N'IUH', N'NNA', N'18        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1878      ', N'Nguyễn Minh Mẫn', N'ĐắkLắc', N'0983661781     ', CAST(N'1998-10-03' AS Date), N'IUH', N'NNA', N'18        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1879      ', N'Trần Văn Từ', N'Bình Dương', N'0289482212     ', CAST(N'2001-12-12' AS Date), N'IUH', N'CNTT', N'19        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1880      ', N'Từ Văn Tư', N'Long An', N'0293871231     ', CAST(N'2001-01-02' AS Date), N'IUH', N'May', N'19        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1881      ', N'Nguyễn Văn Tân', N'Tiền Giang', N'0293877221     ', CAST(N'2000-10-10' AS Date), N'IUH', N'Kế Toán', N'19        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1882      ', N'Trần Đặng Đăng Khoa', N'Tiền Giang', N'0987626811     ', CAST(N'1997-12-11' AS Date), N'IUH', N'Cơ Khí', N'19        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1883      ', N'Hà Việt Hoàng', N'Hà Tĩnh', N'0971277123     ', CAST(N'1999-07-12' AS Date), N'IUH', N'CNTT', N'19        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1884      ', N'Hà Bá ', N'Vĩnh Phúc', N'0927812911     ', CAST(N'1998-11-12' AS Date), N'IUH', N'Xây Dựng', N'20        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1885      ', N'Nguyễn Hải Long Vương', N'Điện Biên', N'0293877223     ', CAST(N'1999-07-21' AS Date), N'IUH', N'Nhiệt Lạnh', N'20        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1886      ', N'Nguyễn Mạnh Cần', N'Đà Nẵng', N'0956271821     ', CAST(N'2000-11-21' AS Date), N'IUH', N'Hóa Vô Cơ', N'20        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1887      ', N'Nguyễn Thị Bích Trâm', N'Bình Thuận', N'0298781123     ', CAST(N'1999-12-25' AS Date), N'IUH', N'Sinh Học', N'20        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1888      ', N'Lê Cẩm Bình', N'Hà Nội', N'0928761612     ', CAST(N'1999-11-10' AS Date), N'IUH', N'May', N'21        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1889      ', N'Lê Răng Lợi', N'Hải Dương', N'0129997552     ', CAST(N'1999-04-15' AS Date), N'IUH', N'CNTT', N'21        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1890      ', N'Mai Thị Quế', N'Nghệ An', N'0298388293     ', CAST(N'1999-04-18' AS Date), N'IUH', N'NNA', N'21        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1891      ', N'Trần Cọp', N'Quảng Ngãi', N'0928881231     ', CAST(N'2000-12-10' AS Date), N'IUH', N'Ngân Hàng', N'21        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1892      ', N'Phan Văn Luân', N'Quãng Bình', N'0928377492     ', CAST(N'1997-02-14' AS Date), N'IUH', N'Xây Dựng', N'21        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1893      ', N'Diva Cát Thy', N'HCM', N'0983478831     ', CAST(N'1997-08-15' AS Date), N'IUH', N'Kế Toán', N'22        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1894      ', N'DJ Mie', N'HCM', N'0192378122     ', CAST(N'1999-11-12' AS Date), N'IUH', N'CNTT', N'22        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1895      ', N'Nguyễn Hồng Thanh', N'Cần Thơ', N'0298748291     ', CAST(N'1999-11-09' AS Date), N'IUH', N'May', N'22        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1896      ', N'Trấn Thành', N'Bạc Liêu', N'0928377211     ', CAST(N'2000-12-19' AS Date), N'IUH', N'Cơ Khí', N'23        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1897      ', N'Hariwon', N'Thừa Thiên Huế', N'0947728342     ', CAST(N'1998-10-02' AS Date), N'IUH', N'Nhiệt Lạnh', N'23        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1898      ', N'Triệu Vân', N'Thanh Hoas', N'0293812331     ', CAST(N'1999-10-12' AS Date), N'IUH', N'May', N'23        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1899      ', N'Quýt Bà Bầu', N'Hải Phòng', N'0922792394     ', CAST(N'2000-04-17' AS Date), N'IUH', N'NNA', N'24        ')
INSERT [dbo].[tblSinhVien] ([MSSV], [TenSV], [QueQuanSV], [SDTSV], [NamSinhSV], [TruongHoc], [KhoaSV], [IDPhong]) VALUES (N'1900      ', N'Triệu Quân Sự', N'Đà Nẵng', N'0923113113     ', CAST(N'2000-12-12' AS Date), N'IUH', N'May', N'25        ')
GO
ALTER TABLE [dbo].[tblPhong]  WITH CHECK ADD  CONSTRAINT [FK_tblPhong_tblChuTro] FOREIGN KEY([IDChuTro])
REFERENCES [dbo].[tblChuTro] ([IDChuTro])
GO
ALTER TABLE [dbo].[tblPhong] CHECK CONSTRAINT [FK_tblPhong_tblChuTro]
GO
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [FK_tblSinhVien_tblPhong] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[tblPhong] ([IDPhong])
GO
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [FK_tblSinhVien_tblPhong]
GO
