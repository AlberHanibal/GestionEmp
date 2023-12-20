USE [LIBRERIA]
GO

/****** Object:  Table [biblio].[Clientes]    Script Date: 20/12/2023 9:36:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [biblio].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[DNI] [varchar](11) NOT NULL,
	[Telefono] [varchar](15) NULL,
	[email] [varchar](max) NULL,
	[Domicilio] [varchar](max) NOT NULL,
	[Pwd] [varchar](12) NOT NULL,
	[Fecha Alta] [date] NOT NULL,
	[Fecha Baja] [date] NULL,
	[Prestamos] [int] NOT NULL,
	[Eliminado] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [biblio].[Clientes] ADD  CONSTRAINT [DF_Clientes_Fecha Alta]  DEFAULT (getdate()) FOR [Fecha Alta]
GO

ALTER TABLE [biblio].[Clientes] ADD  CONSTRAINT [DF_Clientes_Prestamos]  DEFAULT ((0)) FOR [Prestamos]
GO

ALTER TABLE [biblio].[Clientes] ADD  CONSTRAINT [DF_Clientes_Eliminado]  DEFAULT ((0)) FOR [Eliminado]
GO

