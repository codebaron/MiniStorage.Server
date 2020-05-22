USE [RentalInventory]
GO

/****** Object:  Table [dbo].[RentalProperty]    Script Date: 7/18/2019 6:56:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RentalProperty](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_RentalProperty] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RentalUnitSize](
	[Id] [bigint] NOT NULL,
	[Name] [varchar](20) NOT NULL,
 CONSTRAINT [PK_RentalUnitSize] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RentalUnitStatus](
	[Id] [bigint] NOT NULL,
	[Description] [varchar](20) NOT NULL,
 CONSTRAINT [PK_RentalUnitStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RentalUnitType](
	[Id] [bigint] NOT NULL,
	[Description] [varchar](20) NOT NULL,
 CONSTRAINT [PK_RentalUnitType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RentalUnit](
	[Id] [bigint] NOT NULL,
	[Name] [varchar](20) NOT NULL,
	[RentalPropertyId] [bigint] NOT NULL,
	[RentalUnitSizeId] [bigint] NOT NULL,
	[RentalUnitStatusId] [bigint] NOT NULL,
	[RentalUnitTypeId] [bigint] NOT NULL,
 CONSTRAINT [PK_RentalUnit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RentalUnit]  WITH CHECK ADD  CONSTRAINT [FK_RentalUnit_RentalProperty] FOREIGN KEY([RentalPropertyId])
REFERENCES [dbo].[RentalProperty] ([Id])
GO

ALTER TABLE [dbo].[RentalUnit] CHECK CONSTRAINT [FK_RentalUnit_RentalProperty]
GO

ALTER TABLE [dbo].[RentalUnit]  WITH CHECK ADD  CONSTRAINT [FK_RentalUnit_RentalUnitSize] FOREIGN KEY([RentalUnitSizeId])
REFERENCES [dbo].[RentalUnitSize] ([Id])
GO

ALTER TABLE [dbo].[RentalUnit] CHECK CONSTRAINT [FK_RentalUnit_RentalUnitSize]
GO

ALTER TABLE [dbo].[RentalUnit]  WITH CHECK ADD  CONSTRAINT [FK_RentalUnit_RentalUnitStatus] FOREIGN KEY([RentalUnitStatusId])
REFERENCES [dbo].[RentalUnitStatus] ([Id])
GO

ALTER TABLE [dbo].[RentalUnit] CHECK CONSTRAINT [FK_RentalUnit_RentalUnitStatus]
GO

ALTER TABLE [dbo].[RentalUnit]  WITH CHECK ADD  CONSTRAINT [FK_RentalUnit_RentalUnitType] FOREIGN KEY([RentalUnitTypeId])
REFERENCES [dbo].[RentalUnitType] ([Id])
GO

ALTER TABLE [dbo].[RentalUnit] CHECK CONSTRAINT [FK_RentalUnit_RentalUnitType]
GO


