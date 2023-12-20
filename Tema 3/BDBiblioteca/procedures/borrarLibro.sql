USE [LIBRERIA]
GO

/****** Object:  StoredProcedure [biblio].[borrarLibro]    Script Date: 20/12/2023 11:31:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[borrarLibro] 
	@ID AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Libros
	SET Eliminado = 1, [Fecha Baja] = GETDATE()
	WHERE ID = @ID
END
GO

