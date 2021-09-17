/****** Script for SelectTopNRows command from SSMS  ******/
USE [IBA]
GO

INSERT INTO [dbo].[userdetails]
           ([username]
           ,[password]
           ,[email]
           ,[isadmin])
     VALUES
           ('test','test123','test@iba.com',1)
GO
