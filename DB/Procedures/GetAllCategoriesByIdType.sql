CREATE PROCEDURE GetAllCategoriesByIdType 
	@IdType INT
AS
BEGIN
	SELECT IdCategory, CategoryName,IdTag
	FROM Category
	WHERE IdTag = @IdType
END
GO
