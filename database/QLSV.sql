USE [QLSV]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 9/23/2020 8:37:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [int] NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nchar](10) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 9/23/2020 8:37:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[id] [int] NOT NULL,
	[masv] [nvarchar](50) NULL,
	[ten] [nvarchar](50) NULL,
	[quequan] [nvarchar](50) NULL,
	[sdt] [nchar](12) NULL,
	[diachitro] [nvarchar](50) NULL,
	[chucvu] [bit] NULL,
	[lop] [nvarchar](50) NULL,
	[matkhau] [nvarchar](50) NULL,
	[ngaysinh] [text] NULL,
	[tenchutro] [nvarchar](50) NULL,
	[ngayden] [text] NULL,
	[ngaydi] [text] NULL,
	[gioitinh] [bit] NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
