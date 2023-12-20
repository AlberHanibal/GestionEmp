USE [LIBRERIA]
GO

/****** Object:  StoredProcedure [biblio].[IDAutorDadoNombreApellido]    Script Date: 20/12/2023 11:32:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[IDAutorDadoNombreApellido]
	-- Add the parameters for the stored procedure here
	@Nombre AS VARCHAR(50),
	@Apellido AS VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @id as int

    -- Insert statements for procedure here
	SELECT ID as id FROM Autor WHERE nombre = @Nombre AND apellido = @Apellido

	RETURN @id
END
GO

