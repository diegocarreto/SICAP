/****** Object:  Table [dbo].[catalog]    Script Date: 08/12/2016 03:11:16 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[catalog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[creationDate] [datetime] NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_catalog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[catalog] ADD  CONSTRAINT [DF_catalog_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO

ALTER TABLE [dbo].[catalog] ADD  CONSTRAINT [DF_catalog_deleted]  DEFAULT ((0)) FOR [deleted]
GO

