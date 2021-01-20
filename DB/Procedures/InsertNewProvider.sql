CREATE PROCEDURE InsertNewProvider
	@providerName NVARCHAR(50), 
	@description NVARCHAR(500),
    @password NVARCHAR(50),
    @emailAddress NVARCHAR(50),
	@phoneNumber NVARCHAR(50)
AS
BEGIN

	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));
	INSERT INTO [dbo].[Provider]
			   ([ProviderName]
			   ,[Description]
			   ,[Password]
			   ,[Salt]
			   ,[EmailAddress]
			   ,[PhoneNumber])
		 VALUES
			   (@providerName,@description,  HASHBYTES('SHA2_512',@salt + @password), @salt,@emailAddress,@phoneNumber)
END
GO
