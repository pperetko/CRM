--Table categories_types
CREATE TABLE [dbo].[categories_types](
	[id_categories_types] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[alias] [int] NOT NULL,
	[show_on_list] [bit] NULL,
 CONSTRAINT [PK_categories_types] PRIMARY KEY CLUSTERED 
(
	[id_categories_types] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--Table category
CREATE TABLE [dbo].[category](
	[id_category] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[id_categories_types] [int] NOT NULL,
	[show_on_list] [bit] NULL,
	[id_tab_filters] [int] NOT NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id_category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[category]  WITH CHECK ADD  CONSTRAINT [FK_category_categories_types] FOREIGN KEY([id_categories_types])
REFERENCES [dbo].[categories_types] ([id_categories_types])
GO

ALTER TABLE [dbo].[category] CHECK CONSTRAINT [FK_category_categories_types]
GO

ALTER TABLE [dbo].[category]  WITH CHECK ADD  CONSTRAINT [FK_category_tab_filters] FOREIGN KEY([id_tab_filters])
REFERENCES [dbo].[tab_filters] ([id_tab_filters])
GO

ALTER TABLE [dbo].[category] CHECK CONSTRAINT [FK_category_tab_filters]
GO


--Table category_sub

CREATE TABLE [dbo].[category_sub] (
    id_category_sub [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    name  varchar(100) NOT NULL,
	show_on_list bit null,
    id_category int FOREIGN KEY REFERENCES category(id_category)
)
go


--Table country



CREATE TABLE [dbo].[country](
	[id_country] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[alpha_2] [varchar](2) NULL,
	[aplha_3] [varchar](3) NULL,
	[country_code] [varchar](3) NULL,
	[iso] [varchar](20) NULL,
	[region] [varchar](20) NULL,
	[sub_region] [varchar](50) NULL,
	[region_code] [varchar](3) NULL,
	[sub_region_code] [varchar](3) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[id_country] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--Table customers

CREATE TABLE [dbo].[customers](
	[id_customers] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](100) NOT NULL,
	[last_name] [varchar](100) NOT NULL,
	[nationality] [varchar](3) NULL,
	[state] [varchar](100) NULL,
	[city] [varchar](100) NULL,
	[street] [varchar](100) NULL,
	[No] [varchar](50) NULL,
	[dob] [date] NULL,
	[email] [varchar](50) NULL,
	[phone] [varchar](20) NULL,
	[phone2] [varchar](20) NULL,
	[job] [varchar](100) NULL,
	[descryption] [text] NULL,
	[status] [int] NULL,
	[post_code] [varchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[id_customers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


--Table logins



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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--Table Menu

CREATE TABLE [dbo].[menu](
	[id_menu] [int] IDENTITY(1,1) NOT NULL,
	[menu] [varchar](200) NULL,
	[parent_id] [nchar](10) NULL,
	[activie] [bit] NULL,
	[orders] [int] NULL,
 CONSTRAINT [PK_menu] PRIMARY KEY CLUSTERED 
(
	[id_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--Table settings


CREATE TABLE [dbo].[settings](
	[id] [smallint] IDENTITY(1,1) NOT NULL,
	[avatar_path] [text] NULL,
 CONSTRAINT [PK_settings] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

--Table status

CREATE TABLE [dbo].[status](
	[id_status] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[id_status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--Table Tab_filters 


CREATE TABLE [dbo].[tab_filters](
	[id_tab_filters] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[fix] [bit] NULL,
 CONSTRAINT [PK_tab_filters] PRIMARY KEY CLUSTERED 
(
	[id_tab_filters] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--table tasks

CREATE TABLE [dbo].[tasks](
	[id_tasks] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](100) NOT NULL,
	[descryption] [varchar](1) NULL,
	[date_created] [datetime] NOT NULL,
	[id_next_task] [int] NULL,
	[status] [varchar](3) NULL,
	[id_customers] [int] NULL,
	[next_contact] [datetime] NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[id_tasks] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO







                