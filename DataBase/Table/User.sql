/****** Object:  Table [dbo].[user3]    Script Date: 07/12/2016 06:24:59 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[user3](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[alias] [varchar](20) NOT NULL,
	[password] [varchar](12) NOT NULL,
	[active] [bit] NOT NULL,
	[creationDate] [datetime] NOT NULL,
	[updateDate] [datetime] NULL,
	[removalDate] [datetime] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_user3] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[user3] ADD  CONSTRAINT [DF_user3_active]  DEFAULT ((1)) FOR [active]
GO

ALTER TABLE [dbo].[user3] ADD  CONSTRAINT [DF_user3_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO

ALTER TABLE [dbo].[user3] ADD  CONSTRAINT [DF_user3_deleted]  DEFAULT ((0)) FOR [deleted]
GO

