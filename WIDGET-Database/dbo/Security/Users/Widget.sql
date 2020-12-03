CREATE USER [Widget]
	WITH PASSWORD = 'widget'

GO

GRANT CONNECT TO [Widget]
go

ALTER LOGIN Mary5 ENABLE;
go

ALTER LOGIN Mary5 WITH PASSWORD = '<enterStrongPasswordHere>';
go

ALTER LOGIN Mary5 WITH NAME = John2;
go

ALTER LOGIN [Mary5] WITH PASSWORD = '****' UNLOCK ;
go


DROP LOGIN Widget;
CREATE LOGIN Widget WITH PASSWORD = 'password';
ALTER LOGIN Widget WITH PASSWORD = 'widget';
Grant select on Widget to Widget;

USE [master]
GO



/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Widget]    Script Date: 03/12/2020 14:55:10 ******/
CREATE LOGIN [Widget] WITH PASSWORD=N'SFOG9aNHpsSjSBJrJAvrai1DbzsHbWP5MST+HdTq3KY=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

ALTER LOGIN [Widget] DISABLE;

ALTER LOGIN [Widget] ENABLE;
ALTER LOGIN Widget WITH PASSWORD = 'widget';

GO


USE [Widget]
GO

/****** Object:  User [Widget]    Script Date: 03/12/2020 15:09:23 ******/
DROP USER [Widget]
GO

/****** Object:  User [Widget]    Script Date: 03/12/2020 15:09:23 ******/
CRE

USE [master]
GO

/****** Object:  Login [Widget]    Script Date: 03/12/2020 15:10:04 ******/
DROP LOGIN [Widget]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Widget]    Script Date: 03/12/2020 15:10:04 ******/
CREATE LOGIN [Widget] WITH PASSWORD=N'8x/V5E81+vaQLpZV7bS6+l7QiXLXKQv+n6PBRxw66TM=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

ALTER LOGIN [Widget] DISABLE
GO

USE [Widget]
GO


DECLARE	@return_value int

EXEC	@return_value = [dbo].[SP_WIDGET_GET_LIST]

SELECT	'Return Value' = @return_value

GO


