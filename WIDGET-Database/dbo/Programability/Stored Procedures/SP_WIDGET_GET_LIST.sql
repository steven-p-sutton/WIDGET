/*
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


DECLARE	@return_value int
EXEC	@return_value = [dbo].[SP_WIDGET_GET_LIST]
SELECT	'Return Value' = @return_value

GO
*/