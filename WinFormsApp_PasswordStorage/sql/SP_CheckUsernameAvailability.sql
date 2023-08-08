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
-- Author:		Kevin Borup Hansen
-- Create date: 31-05-2022
-- Description:	Procedure to get ID belonging to user
-- =============================================
CREATE PROCEDURE CheckUsernameAvailability 
	-- Add the parameters for the stored procedure here
	@Username varchar(30),

    -- Output Parameter
	@available BIT = null OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT @available = (SELECT
                            CASE WHEN EXISTS
                            (
                                SELECT * FROM Users WHERE Username = @Username
                            ) 
                            THEN 1
                            ELSE 0
                        END)

END
GO
