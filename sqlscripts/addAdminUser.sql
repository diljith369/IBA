USE [IBA]
GO

INSERT INTO [dbo].[userdetails]
           ([username]
           ,[password]
           ,[email]
           ,[isadmin])
     VALUES
           ('admin','password','admin@iba.com',1)
GO


