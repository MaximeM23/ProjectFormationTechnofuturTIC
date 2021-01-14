CREATE PROCEDURE GetCityIdByValues
@country NVARCHAR(50),
@cp NVARCHAR(50),
@city NVARCHAR(50)
AS
BEGIN
	SELECT IdCity
	FROM City
	WHERE Country = @country AND PostalCode = @cp AND CityName = @city
END
GO
