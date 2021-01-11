CREATE PROCEDURE GetClientByMailAndPasswordMatch
	@email NVARCHAR(50),
	@password NVARCHAR(MAX)
AS
BEGIN
    -- Insert statements for procedure here
	SELECT IdClient,Firstname, Lastname,  EmailAddress, PhoneNumber,BirthDate, Active, IdRole, Salt
	FROM Client
	WHERE Active = 1 AND [password] = HASHBYTES('SHA2_512',Salt + @password) AND EmailAddress = @email

END
GO
