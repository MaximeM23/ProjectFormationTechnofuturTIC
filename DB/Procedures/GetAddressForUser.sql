CREATE PROCEDURE GetAddressesForUser
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT [Address].IdAddress ,Street,Number,IdCity
	FROM [Address]
	JOIN ClientAddress ON [Address].IdAddress = ClientAddress.IdAddress AND ClientAddress.IdClient = @Id
END
GO
