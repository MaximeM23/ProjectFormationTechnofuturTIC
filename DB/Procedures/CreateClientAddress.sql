CREATE PROCEDURE CreateClientAddress
	@IdAddress INT,
	@IdClient INT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO ClientAddress(IdAddress,IdClient) VALUES (@IdAddress,@IdClient)
END
GO
