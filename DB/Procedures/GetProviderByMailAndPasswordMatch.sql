CREATE PROCEDURE GetProviderByMailAndPasswordMatch
	@email NVARCHAR(50),
	@password NVARCHAR(MAX)
AS
BEGIN
	SELECT IdProvider,ProviderName, [Description],  EmailAddress, PhoneNumber, Salt
		FROM [Provider]
		WHERE [password] = HASHBYTES('SHA2_512',Salt + @password) AND EmailAddress = @email
END
GO