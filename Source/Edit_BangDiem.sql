USE [QLHS]
GO

/****** Object:  Table [dbo].[DIEMTBMON]    Script Date: 5/27/2018 10:37:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DIEMTBMON](
	[MANH] [int] NULL,
	[MAHK] [int] NULL,
	[MALOP] [int] NULL,
	[MAMH] [int] NULL,
	[MAHS] [int] NULL,
	[DTBMON] [float] NULL
) ON [PRIMARY]

GO

USE [QLHS]
GO

/****** Object:  Table [dbo].[BANGDIEM]    Script Date: 5/27/2018 10:37:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BANGDIEM](
	[MANH] [int] NOT NULL,
	[MALOP] [int] NOT NULL,
	[MAHK] [int] NOT NULL,
	[MAMH] [int] NOT NULL,
	[MAHS] [int] NOT NULL,
	[HESO] [int] NULL,
	[LANKIEMTRA] [int] NULL,
	[HINHTHUCKIEMTRA] [nvarchar](50) NULL,
	[DIEM] [float] NULL
) ON [PRIMARY]

GO


