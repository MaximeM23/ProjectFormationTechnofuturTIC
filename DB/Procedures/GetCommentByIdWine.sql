CREATE PROCEDURE GetCommentByIdWine
	@IdWine INT
AS
BEGIN
	SELECT IdComment,Comment,Note,IdClient
	FROM Comment
	WHERE IdWine = @IdWine
END
GO
