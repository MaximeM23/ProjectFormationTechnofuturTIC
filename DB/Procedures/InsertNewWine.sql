CREATE PROCEDURE InsertNewWine 
@WineName NVARCHAR(50),
@Description TEXT,
@Year INT,
@IdProvider INT
AS
BEGIN
INSERT INTO [dbo].[Wine]
           ([WineName]
           ,[Description]
           ,[Year]
           ,[Disabled]
           ,[IdProvider])
	OUTPUT inserted.IdWine
     VALUES
           (@WineName, @Description, @Year,1,@IdProvider)
END
GO
