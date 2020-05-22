USE [RentalInventory]
GO

INSERT INTO [dbo].[RentalProperty]([Id], [Name]) VALUES(1, 'BUILDING A');
INSERT INTO [dbo].[RentalProperty]([Id], [Name]) VALUES(2, 'BUILDING B');
INSERT INTO [dbo].[RentalProperty]([Id], [Name]) VALUES(3, 'BUILDING C');
INSERT INTO [dbo].[RentalProperty]([Id], [Name]) VALUES(4, 'PARKING D');
GO

INSERT INTO [dbo].[RentalUnitSize]([Id], [Name]) VALUES(1, '5x10');
INSERT INTO [dbo].[RentalUnitSize]([Id], [Name]) VALUES(2, '10x10');
INSERT INTO [dbo].[RentalUnitSize]([Id], [Name]) VALUES(3, '10x15');
INSERT INTO [dbo].[RentalUnitSize]([Id], [Name]) VALUES(4, '10x20');
INSERT INTO [dbo].[RentalUnitSize]([Id], [Name]) VALUES(5, '10x30');
INSERT INTO [dbo].[RentalUnitSize]([Id], [Name]) VALUES(6, 'STANDARD PARKING');
GO

INSERT INTO [dbo].[RentalUnitType]([Id], [Description]) VALUES(1, 'STANDARD');
INSERT INTO [dbo].[RentalUnitType]([Id], [Description]) VALUES(2, 'CLIMATE CONTROL');
INSERT INTO [dbo].[RentalUnitType]([Id], [Description]) VALUES(3, 'PARKING');
INSERT INTO [dbo].[RentalUnitType]([Id], [Description]) VALUES(4, 'COVERED PARKING');
GO

INSERT INTO [dbo].[RentalUnitStatus]([Id], [Description]) VALUES(1, 'VACANT');
INSERT INTO [dbo].[RentalUnitStatus]([Id], [Description]) VALUES(2, 'MANAGEMENT HOLD');
INSERT INTO [dbo].[RentalUnitStatus]([Id], [Description]) VALUES(3, 'CUSTOMER HOLD');
INSERT INTO [dbo].[RentalUnitStatus]([Id], [Description]) VALUES(4, 'RENTED');
INSERT INTO [dbo].[RentalUnitStatus]([Id], [Description]) VALUES(5, 'DELINQUENT');
GO