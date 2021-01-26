CREATE PROCEDURE GetAllCommandWineByCommandId
	@IdCommand INT
AS
BEGIN
	SELECT IdCommand, IdWine,Quantity,IdCommandWine
	FROM CommandWine
	WHERE IdCommand = @IdCommand
END
GO
