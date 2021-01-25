CREATE PROCEDURE InsertCommand
	@DateCommand DATE,
	@IdClient INT,
	@IdAddressBilling INT
AS
BEGIN
	
	INSERT INTO Command(IdClient,IdClientAddress,DateOfCommand)
	OUTPUT inserted.IdCommand
	VALUES (@IdClient,(SELECT IdClientAddress FROM ClientAddress WHERE IdAddress = @IdAddressBilling AND IdClient = @IdClient), @DateCommand)
END
GO
