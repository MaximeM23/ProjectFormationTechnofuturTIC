USE [WineSellingProject]
GO
/****** Object:  StoredProcedure [dbo].[SelectClientById]    Script Date: 05-01-21 10:20:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SelectClientById]
@Id INT
AS
BEGIN
    SELECT IdClient,Firstname, Lastname,  EmailAddress, PhoneNumber,BirthDate, Active, IdRole
	FROM Client
	WHERE Active = 1 AND IdClient = @Id
END