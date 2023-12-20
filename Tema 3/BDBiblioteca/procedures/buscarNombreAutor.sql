USE [LIBRERIA]
GO

/****** Object:  StoredProcedure [biblio].[buscarNombreAutor]    Script Date: 20/12/2023 11:32:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[buscarNombreAutor]
	@Nombre AS VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @id INT

    -- Insert statements for procedure here
	SELECT ID AS id FROM Autor
	WHERE CONCAT(Nombre, ' ', Apellido) LIKE @Nombre

	RETURN @id
END
GO

