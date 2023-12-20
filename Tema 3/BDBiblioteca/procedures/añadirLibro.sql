USE [LIBRERIA]
GO

/****** Object:  StoredProcedure [biblio].[añadirLibro]    Script Date: 20/12/2023 11:31:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[añadirLibro]
	@titulo AS VARCHAR(MAX),
	@ISBN AS VARCHAR(20),
	@anoPublicacion AS INT,
	@IDAutor AS INT,
	@Editorial AS VARCHAR(50),
	@Genero AS VARCHAR(50),
	@Stock AS INT,
	@Idioma AS VARCHAR(20)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	-- comprobar si existe el libro
	IF EXISTS (SELECT * FROM Autor WHERE ID = @IDAutor)
		BEGIN
			IF EXISTS (SELECT * FROM Libros WHERE Titulo LIKE @titulo AND ISBN LIKE @ISBN)
				UPDATE Libros
				SET Eliminado = 0, [Fecha Baja] = NULL
				WHERE Titulo LIKE @titulo AND ISBN LIKE @ISBN
			ELSE 
				INSERT INTO Libros (Titulo, ISBN, [Año Publicacion], [ID Autor], Editorial, Genero, Stock, Idioma)
				VALUES (@titulo, @ISBN, @anoPublicacion, @IDAutor, @Editorial, @Genero, @Stock, @Idioma)
		END
END
GO

