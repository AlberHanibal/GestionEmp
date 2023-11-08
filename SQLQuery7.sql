-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE PRUEBA.pNuevo (
	@CATEGORIA AS INT,
	@DESCRIPCION AS VARCHAR(200),
	@PRECIOUNIDAD AS DECIMAL(19,2)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- PARA DEPURAR HASTA PINTAR LA SQL PARA VER SI SE CREA BIEN
	DECLARE @CATEGORIA AS INT = NULL

    -- Insert statements for procedure here

	DECLARE @SQL AS VARCHAR(MAX) = 'SELECT CATEGORIAID, 
									DESCRIPCION, 
									PRECIOUNIT AS PRECIO_EURO, 
									PRECIOUNIT*166.386 AS PESETAS 
									FROM PRODUCTOS '

	DECLARE @SQL1 AS VARCHAR(MAX)
IF ISNULL(@CATEGORIA, 0) <> 0
	BEGIN
		SET @SQL1 = 'WHERE CATEGORIAID=' + CAST (@CATEGORIA AS VARCHAR)
		SET @SQL = @SQL + @SQL1
	END

--IF ISNULL(@DESCRIPCION, '') <> ''

--IF ISNULL(@PRECIOUNIDAD, 0) <> 0

	--SELECT CATEGORIAID, 
	--	DESCRIPCION, 
	--	PRECIOUNIT AS PRECIO_EURO, 
	--	PRECIOUNIT*166.386 AS PESETAS 
	--FROM PRODUCTOS
	--WHERE CATEGORIAID = @CATEGORIA
	--	AND DESCRIPCION = @DESCRIPCION
	--	AND PRECIOUNIT = @PRECIOUNIDAD

	PRINT(@SQL)
END
GO
