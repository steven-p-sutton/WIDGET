SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[SP_WIDGET_GET_LIST]  
AS  
   BEGIN  
   SELECT [Id]  
         ,[Date]  
         ,[Name]
         ,[Count]
         ,[Secret]
   FROM Widget  
END  
GO