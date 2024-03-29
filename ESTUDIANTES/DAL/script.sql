USE [EstudiantesDb]
GO
/****** Object:  Table [dbo].[Incripciones]    Script Date: 13/09/2019 23:28:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Incripciones](
	[IncripcionId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[EstudianteId] [int] NULL,
	[Comentarios] [varchar](30) NULL,
	[Monto] [float] NULL,
	[Deposito] [float] NULL,
	[Balance] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RegitroEstudiantes]    Script Date: 13/09/2019 23:28:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RegitroEstudiantes](
	[EstudianteId] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [varchar](9) NULL,
	[Nombres] [varchar](30) NULL,
	[Apellidos] [varchar](30) NULL,
	[Cedula] [varchar](13) NULL,
	[Telefono] [varchar](13) NULL,
	[Celular] [varchar](13) NULL,
	[Email] [varchar](30) NULL,
	[FechaNacimiento] [date] NULL,
	[Sexo] [varchar](9) NULL,
	[Balance] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
