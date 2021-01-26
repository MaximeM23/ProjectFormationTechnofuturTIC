CREATE PROCEDURE GetCommentByIdWine
	@IdWine INT
AS
BEGIN
	SELECT IdComment,Comment,Note,IdClient,IdWine
	FROM Comment
	WHERE IdWine = @IdWine
END
GO
