CREATE PROCEDURE FindEmail
	@email NVARCHAR(50)
	@idUser int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT IdClient
	FROM Client
	WHERE EmailAddress = @email AND IdClient != @idUser
END
GO
