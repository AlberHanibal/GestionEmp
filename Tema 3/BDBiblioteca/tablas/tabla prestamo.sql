USE [LIBRERIA]
GO

/****** Object:  Table [biblio].[Prestamo]    Script Date: 20/12/2023 9:36:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [biblio].[Prestamo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Libro] [int] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[Fecha Prestamo] [date] NOT NULL,
	[Fecha Devolucion] [date] NULL,
	[Fecha Limite] [date] NULL,
	[Devuelto] [bit] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [biblio].[Prestamo] ADD  CONSTRAINT [DF_Prestamo_Fecha Prestamo]  DEFAULT (getdate()) FOR [Fecha Prestamo]
GO

ALTER TABLE [biblio].[Prestamo] ADD  CONSTRAINT [DF_Prestamo_Devuelto]  DEFAULT ((0)) FOR [Devuelto]
GO

