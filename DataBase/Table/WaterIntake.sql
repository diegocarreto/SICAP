/****** Object:  Table [dbo].[waterIntake]    Script Date: 07/12/2016 07:59:55 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[WaterIntake](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idHabitant] [int] NOT NULL,
	[idStreet] [int] NOT NULL,
	[exteriorNumber] [varchar](10) NULL,
	[interiorNumber] [varchar](10) NULL,
	[colony] [varchar](50) NULL,
	[active] [bit] NOT NULL,
	[creationDate] [datetime] NOT NULL,
	[updateDate] [datetime] NULL,
	[removalDate] [datetime] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_waterIntake] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[waterIntake] ADD  CONSTRAINT [DF_waterIntake_active]  DEFAULT ((1)) FOR [active]
GO

ALTER TABLE [dbo].[waterIntake] ADD  CONSTRAINT [DF_waterIntake_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO

ALTER TABLE [dbo].[waterIntake] ADD  CONSTRAINT [DF_waterIntake_deleted]  DEFAULT ((0)) FOR [deleted]
GO

