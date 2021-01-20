CREATE PROCEDURE InsertWineCategory 
	@IdWine INT,
	@IdCategory INT
AS
BEGIN
	INSERT INTO WineCategory(IdWine, IdCategory)
	VALUES(@IdWine,@IdCategory)
END
GO
