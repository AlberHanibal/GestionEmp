Ejercicio 1, creación tabla

USE [LIBRERIA]
GO

/****** Object:  Table [dbo].[SIETEyMEDIA]    Script Date: 21/02/2024 12:11:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SIETEyMEDIA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nick_Jugador] [varchar](50) NOT NULL,
	[Apuesta] [int] NOT NULL,
	[Ganancia] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SIETEyMEDIA] ADD  CONSTRAINT [DF_SIETEyMEDIA_Fecha]  DEFAULT (getdate()) FOR [Fecha]
GO


Ejercicio 2


1)

USE [EXAMEN]
GO
/****** Object:  StoredProcedure [dbo].[notaFinal]    Script Date: 21/02/2024 12:09:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[notaFinal] (
	-- Add the parameters for the stored procedure here
	@nombre varchar(50)
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	DECLARE @mediaExam float,
	@mediaPrac float,
	@notaFinal float,
	@nombreAl nvarchar(50),
	@apellidos nvarchar(50)


	
	SELECT @mediaExam = AVG([1er_trimestre_examen] + [2do_trimestre_examen] + [3er_trimestre_examen])
	FROM [dbo].[calificaciones] WHERE Nombre = @nombre
	SELECT @mediaExam = AVG([1er_trimestre_practicas] + [2do_trimestre_practicas] + [3er_trimestre_practicas])
	FROM [dbo].[calificaciones] WHERE Nombre = @nombre
	set @notaFinal = @mediaExam * 0.6 + @mediaPrac * 0.4
	SELECT Nombre = @nombreAl, Apellidos = @apellidos from [dbo].[calificaciones] WHERE Nombre = @nombre
	SELECT @nombreAl, @apellidos, @notaFinal
END


2)
-- nada


3)
SELECT AVG([1er_trimestre_examen] + [1er_trimestre_practicas]) as mediaPrimerTrimestre,
AVG([2do_trimestre_examen] + [2do_trimestre_practicas]) as mediaSegundoTrimestre,
AVG([3er_trimestre_examen] + [3er_trimestre_practicas]) as mediaTercerTrimestre
from [dbo].[calificaciones]


4)

SELECT COUNT(Nombre) AS aprobados1trimestre  
FROM [dbo].[calificaciones]
WHERE ([1er_trimestre_examen] + [1er_trimestre_practicas]) > 5;
SELECT COUNT(Nombre) AS aprobados2trimestre  
FROM [dbo].[calificaciones]
WHERE ([2do_trimestre_examen] + [2do_trimestre_practicas]) > 5;
SELECT COUNT(Nombre) AS aprobados3trimestre  
FROM [dbo].[calificaciones]
WHERE ([3er_trimestre_examen] + [3er_trimestre_practicas]) > 5;

