CREATE PROCEDURE [dbo].[sp_InsertDriver]
	@ParameterDriverType DriverType READONLY
AS
	INSERT INTO Driver (FirstName,LastName,Number,PhotoPath,Wins)
	SELECT FirstName,LastName,Number,PhotoPath,Wins AS NewValues FROM @ParameterDriverType
RETURN 0
