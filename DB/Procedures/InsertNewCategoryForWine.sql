CREATE PROCEDURE InsertNewCategoryForWine
	@IdWine INT,
	@IdCategory INT
AS
BEGIN
	INSERT INTO WineCategory(IdCategory,IdWine)
	VALUES (@IdCategory,@IdWine)
END
GO
