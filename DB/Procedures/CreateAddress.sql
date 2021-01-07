CREATE PROCEDURE CreateAddress
	@IdCity INT,
	@Street NVARCHAR(50),
	@Number NVARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO [Address](IdCity,Number,Street) VALUES (@IdCity,@Number,@Street)
END
GO
