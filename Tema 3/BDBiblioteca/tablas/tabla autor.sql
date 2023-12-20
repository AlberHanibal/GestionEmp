USE [LIBRERIA]
GO

/****** Object:  Table [biblio].[Autor]    Script Date: 20/12/2023 9:35:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [biblio].[Autor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Fecha Nacimiento] [date] NULL,
	[Nacionalidad] [varchar](40) NULL,
	[Fecha Alta] [date] NOT NULL,
	[Fecha Baja] [date] NULL,
	[Eliminado] [bit] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [biblio].[Autor] ADD  CONSTRAINT [DF_Autor_Fecha Alta]  DEFAULT (getdate()) FOR [Fecha Alta]
GO

ALTER TABLE [biblio].[Autor] ADD  CONSTRAINT [DF_Autor_Eliminado]  DEFAULT ((0)) FOR [Eliminado]
GO

