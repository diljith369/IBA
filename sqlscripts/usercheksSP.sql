USE [IBA]
GO

/****** Object:  StoredProcedure [dbo].[userchecks]    Script Date: 18/09/2021 2:52:29 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		aalphaas
-- Create date: 13/09/2021
-- Description:	User check stored proc
-- =============================================
CREATE PROCEDURE [dbo].[userchecks]
(
@uname NVARCHAR(100),  @pass NVARCHAR(100)
)
AS
BEGIN
SET NOCOUNT ON;
SELECT  username,[password],email,isadmin
FROM dbo.userdetails
WHERE username=@uname AND [password]=@pass
end
GO


