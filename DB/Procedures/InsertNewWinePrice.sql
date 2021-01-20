CREATE PROCEDURE InsertNewWinePrice
	@Price DECIMAL,
	@IdWine INT
AS
BEGIN
	INSERT INTO Price(Price,DateOfPrice,IdWine)
	VALUES (@Price,GETDATE(),@IdWine)
END
GO
