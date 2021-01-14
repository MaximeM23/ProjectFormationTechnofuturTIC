CREATE PROCEDURE InsertNewUserAddress
@Idclient INT,
@Street NVARCHAR(50),
@Number NVARCHAR(50),
@City INT,
@PostalCode NVARCHAR(50),
@Country NVARCHAR(50)
AS
BEGIN
	
	INSERT INTO [Address] (Street,Number,IdCity)
	OUTPUT inserted.IdAddress
    VALUES (@Street,@Number,(SELECT IdCity FROM City WHERE Country = @Country AND PostalCode = @PostalCode AND CityName = @City))

	INSERT INTO ClientAddress (IdAddress,IdClient) 
	VALUES (SCOPE_IDENTITY(),@Idclient)
END
GO
