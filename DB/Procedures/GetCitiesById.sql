CREATE PROCEDURE GetCitiesById
	@Id INT
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdCity,PostalCode,Country,CityName
	FROM City
	WHERE IdCity = @Id
END
GO
