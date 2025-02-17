USE [empresa]
GO
/****** Object:  StoredProcedure [PRUEBA].[pNuevo]    Script Date: 15/11/2023 9:08:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [PRUEBA].[pNuevo] (
	@CATEGORIA AS INT,
	@DESCRIPCION AS VARCHAR(MAX),
	@PRECIOUNIDAD AS DECIMAL(19,2)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	DECLARE @SQL AS VARCHAR(MAX) = 'SELECT CATEGORIAID, 
									DESCRIPCION, 
									PRECIOUNIT AS PRECIO_EURO, 
									PRECIOUNIT*166.386 AS PESETAS 
									FROM PRODUCTOS'
	PRINT(@SQL)
	DECLARE @SQL1 AS VARCHAR(MAX)
	DECLARE @UNPARAMETRO AS VARCHAR(2) = 'NO'
IF ISNULL(@CATEGORIA, 0) <> 0
	BEGIN
		IF @UNPARAMETRO = 'NO'
			BEGIN
				SET @SQL = @SQL + ' WHERE '
				SET @UNPARAMETRO = 'SI'
			END
		SET @SQL1 = 'CATEGORIAID = ' + CAST (@CATEGORIA AS VARCHAR)
		SET @SQL = @SQL + @SQL1
	END

IF ISNULL(@DESCRIPCION, '') <> ''
	BEGIN
		IF @UNPARAMETRO = 'NO'
			BEGIN
				SET @SQL = @SQL + ' WHERE '
				SET @UNPARAMETRO = 'SI'
			END
		ELSE 
			SET @SQL = @SQL + ' AND '
	
		SET @SQL1 = 'DESCRIPCION LIKE ' + '''%' +  CAST (@DESCRIPCION AS VARCHAR) + '%'''
		SET @SQL = @SQL + @SQL1
	END
IF ISNULL(@PRECIOUNIDAD, 0) <> 0
	BEGIN
		IF @UNPARAMETRO = 'NO'
			BEGIN
				SET @SQL = @SQL + ' WHERE '
				SET @UNPARAMETRO = 'SI'
			END
		ELSE
			SET @SQL = @SQL + ' AND '

		SET @SQL1 = 'PRECIOUNIT = ' + CAST (@PRECIOUNIDAD AS VARCHAR)
		SET @SQL = @SQL + @SQL1
	END
	--SELECT CATEGORIAID,
	--	DESCRIPCION,
	--	PRECIOUNIT AS PRECIO_EURO,
	--	PRECIOUNIT*166.386 AS PESETAS
	--FROM PRODUCTOS
	--WHERE CATEGORIAID = @CATEGORIA
	--	AND DESCRIPCION = @DESCRIPCION
	--	AND PRECIOUNIT = @PRECIOUNIDAD

	PRINT(@SQL)
	EXEC(@SQL)
END
