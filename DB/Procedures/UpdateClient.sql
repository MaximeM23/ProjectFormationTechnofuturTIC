CREATE PROCEDURE UpdateClient
	@IdUser INT,
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@EmailAddress NVARCHAR(50),
	@Password NVARCHAR(MAX),
	@PhoneNumber NVARCHAR(20),
	@BirthDate Date
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Client
	SET BirthDate = @BirthDate, EmailAddress = @EmailAddress, Firstname = @fn, Lastname = @ln, [Password] = @Password, PhoneNumber = @PhoneNumber
	FROM Client
	WHERE Client.IdClient = @IdUser
END
GO
