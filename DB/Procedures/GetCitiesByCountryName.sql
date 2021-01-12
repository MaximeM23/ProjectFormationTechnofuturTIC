CREATE PROCEDURE GetCitiesByCountryName
	@name NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT IdCity, Country, PostalCode, CityName
	FROM City
	WHERE Country = @name
END
GO
