USE [LIBRERIA]
GO

/****** Object:  StoredProcedure [biblio].[buscarLibroPorTitulo]    Script Date: 10/01/2024 10:50:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[buscarLibroPorTitulo]
	-- Add the parameters for the stored procedure here
	@Titulo AS VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Libros
	WHERE Titulo LIKE @Titulo
END
GO

