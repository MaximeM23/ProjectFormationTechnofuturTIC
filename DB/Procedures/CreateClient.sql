CREATE PROCEDURE CreateClient 
	@fn NVARCHAR(50),
	@ln NVARCHAR(50),
	@EmailAddress NVARCHAR(50),
	@Password NVARCHAR(MAX),
	@PhoneNumber NVARCHAR(20),
	@BirthDate Date
AS
BEGIN

	DECLARE @IdRole int
	SET @IdRole = (SELECT IdRole FROM [Role] WHERE RoleName = 'Client')
    INSERT INTO Client(Firstname,Lastname,EmailAddress,[Password],PhoneNumber, BirthDate, Active, IdRole, Salt) 
				VALUES(@fn,@ln,@EmailAddress,@Password,@PhoneNumber,convert(varchar, @BirthDate, 105),'1','2', '0000000')
END
GO
