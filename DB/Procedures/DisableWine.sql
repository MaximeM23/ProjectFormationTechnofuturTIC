CREATE PROCEDURE DisableWine
	@IdWine INT
AS
BEGIN
	UPDATE Wine
	SET [Disabled] = 1
	WHERE IdWine = @IdWine
END
GO
