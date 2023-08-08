-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Kevin Borup Hansen>
-- Create date: 31-05-2022
-- Description:	Procedure to insert value into User table
-- =============================================
ALTER PROCEDURE InsertUser 
	-- Add the parameters for the stored procedure here
	@Username varchar(30), 
	@pws varchar(255),
	@Salt varchar(30)
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
GO
