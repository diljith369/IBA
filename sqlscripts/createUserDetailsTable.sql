USE [IBA]
GO

/****** Object:  Table [dbo].[userdetails]    Script Date: 18/09/2021 2:45:45 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[userdetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](100) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[email] [varchar](100) NULL,
	[isadmin] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[userdetails] ADD  DEFAULT (NULL) FOR [email]
GO

ALTER TABLE [dbo].[userdetails] ADD  DEFAULT ((0)) FOR [isadmin]
GO


