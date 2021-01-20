CREATE PROCEDURE GetWineByProviderId
	@IdProvider INT
AS
BEGIN
SELECT IdWine,WineName,[Description],[Year], IdProvider,[Disabled]
	FROM Wine
	WHERE IdProvider = @IdProvider
END
GO
