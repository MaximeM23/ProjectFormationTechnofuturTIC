CREATE PROCEDURE GetCommandByIdCommand
	@IdCommand INT
AS
BEGIN
	SELECT IdClient,IdCommand,DateOfCommand,IdClientAddress
	FROM Command
END
GO
