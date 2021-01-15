CREATE PROCEDURE DeleteAddress
	@IdAddress INT
AS
BEGIN
	UPDATE [Address]
	SET Active = 0
	WHERE IdAddress = @IdAddress
END
GO
