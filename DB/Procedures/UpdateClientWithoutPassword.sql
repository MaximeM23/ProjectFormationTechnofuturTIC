CREATE PROCEDURE UpdateClientWithoutPassword
	@IdUser INT,
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@EmailAddress NVARCHAR(50),
	@PhoneNumber NVARCHAR(20),
	@BirthDate Date
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Client
	SET BirthDate = @BirthDate, EmailAddress = @EmailAddress, Firstname = @fn, Lastname = @ln, PhoneNumber = @PhoneNumber
	FROM Client
	WHERE Client.IdClient = @IdUser
END
