USE [LIBRERIA]
GO

/****** Object:  StoredProcedure [biblio].[añadirAutor]    Script Date: 20/12/2023 11:30:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[añadirAutor]
	@Nombre AS VARCHAR(50),
	@Apellido AS VARCHAR(50),
	@FechaNacimiento AS DATE,
	@Nacionalidad AS VARCHAR(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	IF EXISTS (SELECT ID FROM Autor WHERE Nombre = @Nombre AND Apellido = @Apellido AND Eliminado = 1)
		UPDATE Autor 
		SET Eliminado = 0, [Fecha Baja] = null
		WHERE Nombre = @Nombre AND Apellido = @Apellido
	ELSE 
		INSERT INTO Autor (Nombre, Apellido, [Fecha Nacimiento], Nacionalidad)
		VALUES (@Nombre, @Apellido, @FechaNacimiento, @Nacionalidad)
END
GO

