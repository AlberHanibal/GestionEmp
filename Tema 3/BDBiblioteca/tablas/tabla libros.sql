USE [LIBRERIA]
GO

/****** Object:  Table [biblio].[Libros]    Script Date: 20/12/2023 9:36:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [biblio].[Libros](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](max) NOT NULL,
	[ISBN] [varchar](20) NOT NULL,
	[Año Publicacion] [int] NULL,
	[ID Autor] [int] NOT NULL,
	[Editorial] [varchar](50) NOT NULL,
	[Genero] [varchar](50) NOT NULL,
	[Fecha Alta] [date] NOT NULL,
	[Fecha Baja] [date] NULL,
	[Stock] [int] NOT NULL,
	[Idioma] [varchar](20) NOT NULL,
	[Disponibilidad] [bit] NOT NULL,
	[Eliminado] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [biblio].[Libros] ADD  CONSTRAINT [DF_Libros_Fecha Alta]  DEFAULT (getdate()) FOR [Fecha Alta]
GO

ALTER TABLE [biblio].[Libros] ADD  CONSTRAINT [DF_Libros_Disponibilidad]  DEFAULT ((1)) FOR [Disponibilidad]
GO

ALTER TABLE [biblio].[Libros] ADD  CONSTRAINT [DF_Libros_Eliminado]  DEFAULT ((0)) FOR [Eliminado]
GO

