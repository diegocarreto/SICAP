/****** Object:  Table [dbo].[payment]    Script Date: 07/12/2016 06:26:32 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[payment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idWaterIntake] [int] NOT NULL,
	[month] [int] NOT NULL,
	[year] [int] NOT NULL,
	[amount] [money] NOT NULL,
	[observations] [varchar](2000) NULL,
	[creationDate] [datetime] NOT NULL,
	[updateDate] [datetime] NULL,
	[removalDate] [datetime] NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_payment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[payment] ADD  CONSTRAINT [DF_payment_creationDate]  DEFAULT (getdate()) FOR [creationDate]
GO

ALTER TABLE [dbo].[payment] ADD  CONSTRAINT [DF_payment_deleted]  DEFAULT ((0)) FOR [deleted]
GO

