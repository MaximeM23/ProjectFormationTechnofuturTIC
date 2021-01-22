CREATE PROCEDURE EnableWineById 
	@Id INT
AS
BEGIN
	UPDATE Wine
	SET [Disabled] = 0
	WHERE IdWine = @Id
END
GO
