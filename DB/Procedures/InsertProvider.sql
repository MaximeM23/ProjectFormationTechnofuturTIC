CREATE PROCEDURE InsertProvider
	@ProviderName NVARCHAR(50),
	@Email NVARCHAR(50),
	@Password NVARCHAR(MAX),
	@Description TEXT,
	@PhoneNumber NVARCHAR(50)
AS
BEGIN		
	DECLARE @salt NVARCHAR(8)
	Set @salt = (SUBSTRING(CONVERT(NVARCHAR,RAND()),3,8));
	
	INSERT INTO Provider (ProviderName,[Description],PhoneNumber,EmailAddress,[Password], Salt)
	OUTPUT inserted.IdProvider
	VALUES (@ProviderName,@Description,@PhoneNumber,@Email, HASHBYTES('SHA2_512',@salt + @Password), @salt)
END
GO