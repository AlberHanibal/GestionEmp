USE [LIBRERIA]
GO
/****** Object:  User [librero]    Script Date: 22/11/2023 11:07:01 ******/
CREATE USER [librero] FOR LOGIN [librero] WITH DEFAULT_SCHEMA=[biblio]
GO
ALTER ROLE [db_owner] ADD MEMBER [librero]
GO
ALTER ROLE [db_datareader] ADD MEMBER [librero]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [librero]
GO
/****** Object:  Schema [biblio]    Script Date: 22/11/2023 11:07:01 ******/
CREATE SCHEMA [biblio]
GO
/****** Object:  Table [biblio].[Autor]    Script Date: 22/11/2023 11:07:01 ******/
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
/****** Object:  Table [biblio].[Clientes]    Script Date: 22/11/2023 11:07:01 ******/
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
/****** Object:  Table [biblio].[Libros]    Script Date: 22/11/2023 11:07:01 ******/
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
/****** Object:  Table [biblio].[Prestamo]    Script Date: 22/11/2023 11:07:01 ******/
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
ALTER TABLE [biblio].[Autor] ADD  CONSTRAINT [DF_Autor_Fecha Alta]  DEFAULT (getdate()) FOR [Fecha Alta]
GO
ALTER TABLE [biblio].[Autor] ADD  CONSTRAINT [DF_Autor_Eliminado]  DEFAULT ((0)) FOR [Eliminado]
GO
ALTER TABLE [biblio].[Clientes] ADD  CONSTRAINT [DF_Clientes_Fecha Alta]  DEFAULT (getdate()) FOR [Fecha Alta]
GO
ALTER TABLE [biblio].[Clientes] ADD  CONSTRAINT [DF_Clientes_Prestamos]  DEFAULT ((0)) FOR [Prestamos]
GO
ALTER TABLE [biblio].[Clientes] ADD  CONSTRAINT [DF_Clientes_Eliminado]  DEFAULT ((0)) FOR [Eliminado]
GO
ALTER TABLE [biblio].[Libros] ADD  CONSTRAINT [DF_Libros_Fecha Alta]  DEFAULT (getdate()) FOR [Fecha Alta]
GO
ALTER TABLE [biblio].[Libros] ADD  CONSTRAINT [DF_Libros_Disponibilidad]  DEFAULT ((1)) FOR [Disponibilidad]
GO
ALTER TABLE [biblio].[Libros] ADD  CONSTRAINT [DF_Libros_Eliminado]  DEFAULT ((0)) FOR [Eliminado]
GO
ALTER TABLE [biblio].[Prestamo] ADD  CONSTRAINT [DF_Prestamo_Fecha Prestamo]  DEFAULT (getdate()) FOR [Fecha Prestamo]
GO
ALTER TABLE [biblio].[Prestamo] ADD  CONSTRAINT [DF_Prestamo_Devuelto]  DEFAULT ((0)) FOR [Devuelto]
GO
/****** Object:  StoredProcedure [biblio].[añadirAutor]    Script Date: 22/11/2023 11:07:01 ******/
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
/****** Object:  StoredProcedure [biblio].[añadirLibro]    Script Date: 22/11/2023 11:07:01 ******/
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
		INSERT INTO Libros (Titulo, ISBN, [Año Publicacion], [ID Autor], Editorial, Genero, Stock, Idioma)
		VALUES (@titulo, @ISBN, @anoPublicacion, @IDAutor, @Editorial, @Genero, @Stock, @Idioma)
END
GO
/****** Object:  StoredProcedure [biblio].[borrarAutor]    Script Date: 22/11/2023 11:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[borrarAutor]
	@ID AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	UPDATE Autor
	SET Eliminado = 1
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [biblio].[borrarLibro]    Script Date: 22/11/2023 11:07:01 ******/
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
	SET Eliminado = 1
	WHERE ID = @ID
END
GO
/****** Object:  StoredProcedure [biblio].[buscarAutor]    Script Date: 22/11/2023 11:07:01 ******/
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
/****** Object:  StoredProcedure [biblio].[buscarLibro]    Script Date: 22/11/2023 11:07:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [biblio].[buscarLibro] 
	@ID AS INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM Libros
	WHERE ID = @ID
END
GO
