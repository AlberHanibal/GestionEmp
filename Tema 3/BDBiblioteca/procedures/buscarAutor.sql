USE [LIBRERIA]
GO

/****** Object:  StoredProcedure [biblio].[buscarAutor]    Script Date: 20/12/2023 11:31:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[buscarAutor] 
	@ID AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	SELECT * FROM Autor
	WHERE ID = @ID
END
GO

