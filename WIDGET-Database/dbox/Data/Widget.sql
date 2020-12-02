/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Date]
      ,[Name]
      ,[Count]
      ,[Secret]
  FROM [Widget].[dbo].[Widget]

DELETE FROM [dbo].[Widget]

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200101', N'Widget01', 100, N'Secret01')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200102', N'Widget02', 100, N'Secret02')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200103', N'Widget03', 100, N'Secret03')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200104', N'Widget04', 100, N'Secret04')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200105', N'Widget05', 100, N'Secret05')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200106', N'Widget06', 100, N'Secret06')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200107', N'Widget07', 100, N'Secret07')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200108', N'Widget08', 100, N'Secret08')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200109', N'Widget09', 100, N'Secret09')

INSERT INTO [dbo].[Widget] ([Date], [Name], [Count], [Secret]) 
	VALUES (N'20200110', N'Widget10', 100, N'Secret10')