CREATE PROCEDURE GetWinePrices
	@IdWine INT
AS
BEGIN
	SELECT Price, DateOfPrice
	FROM Price
	WHERE IdWine = @IdWine
END
GO
