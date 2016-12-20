/****** Object:  Table [dbo].[binnacle]    Script Date: 07/12/2016 06:25:37 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[binnacle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUser] [int] NOT NULL,
	[name] [varchar](500) NULL,
	[tableName] [varchar](30) NULL,
	[idRowPk] [int] NULL,
	[type] [varchar](50) NULL,
	[previousValue] [varchar](4000) NULL,
	[currentValue] [varchar](4000) NULL,
	[creationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_binnacle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[binnacle] ADD  CONSTRAINT [DF_binnacle_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO

