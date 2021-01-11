CREATE PROCEDURE RegisterClient
@Email NVARCHAR(50),
@Password NVARCHAR(50)
AS
BEGIN
	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));
	
	INSERT INTO Client (EmailAddress,[Password], Salt, IdRole,Active)
	OUTPUT inserted.IdClient
	VALUES (@Email, HASHBYTES('SHA2_512',@salt + @Password), @salt, 3, 1)
END
GO
