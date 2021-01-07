CREATE PROCEDURE UpdateAddress
	@IdAddress INT,
	@IdCity int,
	@Number NVARCHAR(50),
	@Street NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE [Address]
	SET IdCity = @IdCity, Number = @Number, Street = @Street
	FROM [Address]
	WHERE [Address].IdAddress = @IdAddress
END
GO
