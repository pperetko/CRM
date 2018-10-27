

USE [CRM]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 02/13/2018 11:02:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[country](
	[id_country] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[alpha_2][varchar](2) NULL,
	[aplha_3][varchar](3)NULL,
	[country_code] [varchar](3) NULL,
	[iso] [varchar](20) NULL,
	[region] [varchar](20) NULL,
	[sub_region] [varchar](50) NULL,
	[region_code] [varchar](3) NULL,
	[sub_region_code] [varchar](3) NULL,
	
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[id_country] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


