USE [LIBRERIA]
GO

/****** Object:  StoredProcedure [biblio].[buscarAutorPorNombre]    Script Date: 10/01/2024 10:49:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[buscarAutorPorNombre]
	-- Add the parameters for the stored procedure here
	@Nombre AS VARCHAR(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Autor
	WHERE CONCAT(Nombre, ' ', Apellido) LIKE @Nombre
END
GO

