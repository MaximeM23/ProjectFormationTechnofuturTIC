CREATE PROCEDURE GetAddressByClientAddressId 
	@IdClientAddress INT
AS
BEGIN
	SELECT [Address].IdAddress,Street,Number,IdCity
	FROM [Address]
	JOIN ClientAddress ON ClientAddress.IdAddress = [Address].IdAddress
	WHERE IdClientAddress = @IdClientAddress
END
GO
