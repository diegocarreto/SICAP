/****** Object:  Table [dbo].[habitant]    Script Date: 07/12/2016 06:22:05 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[habitant](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[paterno] [varchar](50) NOT NULL,
	[materno] [varchar](50) NULL,
	[active] [bit] NOT NULL,
	[observations] [varchar](2000) NULL,
	[creationDate] [datetime] NOT NULL,
	[updateDate] [datetime] NULL,
	[removalDate] [datetime] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_habitant] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[habitant] ADD  CONSTRAINT [DF_habitant_active]  DEFAULT ((1)) FOR [active]
GO

ALTER TABLE [dbo].[habitant] ADD  CONSTRAINT [DF_habitant_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO

ALTER TABLE [dbo].[habitant] ADD  CONSTRAINT [DF_habitant_deleted]  DEFAULT ((0)) FOR [deleted]
GO


