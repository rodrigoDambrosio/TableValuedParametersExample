CREATE PROCEDURE [dbo].[sp_UpdateDriver]
	@ParameterDriverType DriverType READONLY
AS
	UPDATE Driver
	SET Driver.FirstName = ec.FirstName, Driver.LastName=ec.LastName, Driver.Number=ec.Number, Driver.PhotoPath=ec.PhotoPath, Driver.Wins=ec.Wins
    FROM dbo.Driver INNER JOIN @ParameterDriverType AS ec
    ON dbo.Driver.Id = ec.Id
	Where Driver.Id=ec.Id

