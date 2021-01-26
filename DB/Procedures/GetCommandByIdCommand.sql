CREATE PROCEDURE GetCommandByIdCommand
	@IdCommand INT
AS
BEGIN
	SELECT IdClient,IdCommand,DateOfCommand,IdClientAddress
	FROM Command
	WHERE IdCommand = @IdCommand
END
GO
