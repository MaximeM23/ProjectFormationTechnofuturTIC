CREATE PROCEDURE GetAllWine
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT IdWine,WineName,[Description],[Year], IdProvider, [Disabled]
	FROM Wine
	WHERE [Disabled] = 0
END
GO
