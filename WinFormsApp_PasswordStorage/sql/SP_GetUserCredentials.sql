USE [EncryptionBase]
GO
/****** Object:  StoredProcedure [dbo].[GetUserCredentials]    Script Date: 08-08-2023 13:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Kevin Borup Hansen
-- Create date: 31-05-2022
-- Description:	Procedure to get ID belonging to user
-- =============================================
ALTER PROCEDURE [dbo].[GetUserCredentials] 
	-- Add the parameters for the stored procedure here
	@Username varchar(30),

    -- Output Parameter
	@pws varbinary(32) = null OUTPUT,
	@Salt varbinary(32) = null OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT @pws = (SELECT pws 
						FROM Users
						WHERE Username = @Username)

    SELECT @Salt = (SELECT Salt 
						FROM Users
						WHERE Username = @Username)

END
