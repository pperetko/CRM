USE [CRM]
GO

/****** Object:  Table [dbo].[Country]    Script Date: 02/13/2018 11:33:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tasks](
	[id_tasks] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](100) NOT NULL,
	[descryption] [varchar] NULL,
	[date_created] [datetime] NOT NULL,
	[id_next_task] [integer] NULL,
	[status] [varchar](3) NULL,
	[id_customers] [integer] NULL,
	[next_contact] [datetime] NULL,
	
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[id_tasks] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


