CREATE PROCEDURE GetWineById
	@id INT
AS
BEGIN
	SELECT IdWine,WineName,[Description],[Year], IdProvider, [Disabled]
		FROM Wine
		WHERE [Disabled] = 0 AND IdWine = @id
END
GO
