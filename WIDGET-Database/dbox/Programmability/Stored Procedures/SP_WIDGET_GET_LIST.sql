CREATE PROCEDURE [dbo].[SP_COUNTRY_GET_LIST]  
AS  
   BEGIN  
   SELECT id  
         ,country  
         ,active 
   FROM Country  
END  