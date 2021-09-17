USE [IBA]
GO

/****** Object:  StoredProcedure [dbo].[deleteuser]    Script Date: 18/09/2021 2:51:53 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		aalphaas
-- Create date: 13/09/2021
-- Description:	User check stored proc
-- =============================================
CREATE PROCEDURE [dbo].[deleteuser]
(
@email NVARCHAR(100)
)
AS
BEGIN
SET NOCOUNT ON;
delete from  userdetails
WHERE email=@email
end
GO


