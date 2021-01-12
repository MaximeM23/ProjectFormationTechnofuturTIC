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

	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));

	UPDATE Client
	SET BirthDate = @BirthDate, EmailAddress = @EmailAddress, Firstname = @fn, Lastname = @ln, [Password] = HASHBYTES('SHA2_512',@salt + @Password), PhoneNumber = @PhoneNumber, Salt = @salt
	FROM Client
	WHERE Client.IdClient = @IdUser
END
GO
