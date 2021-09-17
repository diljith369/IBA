USE [IBA]
GO

/****** Object:  StoredProcedure [dbo].[edituser]    Script Date: 18/09/2021 2:52:13 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		aalphaas
-- Create date: 13/09/2021
-- Description:	User check stored proc
-- =============================================
CREATE PROCEDURE [dbo].[edituser]
(
@usrname NVARCHAR(100),
@pswd NVARCHAR(100),
@email NVARCHAR(100),
@admin int
)
AS
BEGIN
SET NOCOUNT ON;
update  userdetails
set username = @usrname,
	[password] = @pswd,
	email = @email,
	isadmin = @admin
WHERE email=@email
end
GO


