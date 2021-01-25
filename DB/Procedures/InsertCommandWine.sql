CREATE PROCEDURE InsertCommandWine
	@IdCommand INT,
	@IdWine INT,
	@Quantity INT
AS
BEGIN
	INSERT INTO CommandWine(IdCommand,IdWine,Quantity)
	VALUES (@IdCommand,@IdWine,@Quantity)
END
GO
