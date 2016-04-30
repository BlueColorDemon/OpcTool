USE [BC_GraduationDesign]
GO

/****** Object:  Table [dbo].[TagData]    Script Date: 2016/4/30 20:51:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TagData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServerName] [nvarchar](250) NULL,
	[AliasName] [nvarchar](250) NULL,
	[TagValue] [nchar](10) NULL,
	[CreateTime] [datetime] NULL,
 CONSTRAINT [PK_TagData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


