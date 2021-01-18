CREATE PROCEDURE GetAllWineTypeCategory
	@idWine INT,
	@idTag INT
AS
BEGIN
	SELECT Category.IdCategory, CategoryName, IdTag
	FROM Category
	JOIN WineCategory ON Category.IdCategory = WineCategory.IdCategory
	WHERE WineCategory.IdWine = @idWine AND Category.IdTag = @idTag
END
GO
