CREATE PROCEDURE GetCountries
AS
BEGIN

    -- Insert statements for procedure here
	SELECT DISTINCT Country
	FROM City
END
GO
