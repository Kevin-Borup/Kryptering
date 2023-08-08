USE [EncryptionBase]
GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 08-08-2023 13:21:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kevin Borup Hansen>
-- Create date: 31-05-2022
-- Description:	Procedure to insert value into User table
-- =============================================
ALTER PROCEDURE [dbo].[InsertUser] 
	-- Add the parameters for the stored procedure here
	@Username varchar(30), 
	@pws varbinary(32),
	@Salt varbinary(32)
AS
BEGIN
	INSERT INTO Users(
	Username,
	pws,
	Salt) 
	VALUES (
	@Username,
	@pws,
	@Salt)

END
