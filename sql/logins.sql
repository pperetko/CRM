USE [CRM]
GO

/****** Object:  Table [dbo].[country]    Script Date: 02/13/2018 12:01:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[logins](
	[id_logins] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](100) NOT NULL,
	[name] [varchar](100) NULL,
	[login] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
	[bloced] [bit] NULL,
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[id_logins] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


