CREATE PROCEDURE InsertNewComment 
	@IdClient INT,
	@Note TINYINT,
	@IdWine INT,
	@Comment TEXT
AS
BEGIN
	INSERT INTO Comment(IdClient,Note,IdWine,Comment)
	VALUES (@IdClient,@Note,@IdWine,@Comment)
END
GO