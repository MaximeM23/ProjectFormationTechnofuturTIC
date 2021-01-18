CREATE PROCEDURE GetWineById
	@id INT
AS
BEGIN
	SELECT IdWine,WineName,[Description],[Year], IdProvider
		FROM Wine
		WHERE [Disabled] = 1 AND IdWine = @id
END
GO
