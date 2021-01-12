CREATE PROCEDURE GetCities
	
AS
BEGIN
	SET NOCOUNT ON;

	SELECT IdCity, Country, PostalCode, CityName
	FROM City
END
GO
