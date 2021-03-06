USE [SGISI]
GO
/****** Object:  Table [dbo].[DigitoVerificadorVertical]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DigitoVerificadorVertical](
	[tabla] [varchar](50) NOT NULL,
	[digito] [char](32) NOT NULL,
 CONSTRAINT [PK_DigitoVerificadorVertical] PRIMARY KEY CLUSTERED 
(
	[tabla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventoBitacora]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventoBitacora](
	[id_evento_bitacora] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[descripcion] [text] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[id_evento_bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Familia]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia](
	[id_familia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[id_familia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaPatente](
	[id_familia] [int] NOT NULL,
	[id_patente] [int] NOT NULL,
 CONSTRAINT [PK_FamiliaPatente] PRIMARY KEY CLUSTERED 
(
	[id_familia] ASC,
	[id_patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[id_idioma] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[id_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Palabra]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Palabra](
	[id_palabra] [int] IDENTITY(1,1) NOT NULL,
	[cadena] [text] NOT NULL,
 CONSTRAINT [PK_Palabra] PRIMARY KEY CLUSTERED 
(
	[id_palabra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PalabraTraducida]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PalabraTraducida](
	[id_idioma] [int] NOT NULL,
	[id_palabra] [int] NOT NULL,
	[cadena_traducida] [varchar](200) NOT NULL,
 CONSTRAINT [PK_PalabraTraducida] PRIMARY KEY CLUSTERED 
(
	[id_palabra] ASC,
	[id_idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patente]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patente](
	[id_patente] [int] IDENTITY(1,1) NOT NULL,
	[id_padre] [int] NULL,
	[nombre] [varchar](50) NOT NULL,
	[formulario] [varchar](50) NULL,
	[imagen] [varchar](50) NULL,
 CONSTRAINT [PK_Patente] PRIMARY KEY CLUSTERED 
(
	[id_patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sector]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[id_sector] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[gerencia] [varchar](50) NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[id_sector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_sector] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[id_familia] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[EventoBitacora] ON 

INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1, 5, CAST(N'2017-05-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (2, 5, CAST(N'2017-05-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (3, 5, CAST(N'2017-05-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (4, 5, CAST(N'2017-05-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (5, 5, CAST(N'2017-05-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (6, 5, CAST(N'2017-05-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (7, 5, CAST(N'2017-05-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (8, 5, CAST(N'2017-05-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (9, 5, CAST(N'2017-05-25' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (10, 5, CAST(N'2017-05-25' AS Date), N'Salió')
SET IDENTITY_INSERT [dbo].[EventoBitacora] OFF
SET IDENTITY_INSERT [dbo].[Familia] ON 

INSERT [dbo].[Familia] ([id_familia], [nombre]) VALUES (1, N'Administrador')
SET IDENTITY_INSERT [dbo].[Familia] OFF
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([id_idioma], [nombre]) VALUES (1, N'Administrador')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
SET IDENTITY_INSERT [dbo].[Sector] ON 

INSERT [dbo].[Sector] ([id_sector], [nombre], [gerencia]) VALUES (1, N'Soporte', N'Tecnologia')
SET IDENTITY_INSERT [dbo].[Sector] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [id_sector], [nombre], [apellido], [username], [password], [id_familia]) VALUES (5, 1, N'Esteban', N'Mas', N'mase', N'3ca5b0696fb1d53f64658075b7f83102', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Familia] FOREIGN KEY([id_familia])
REFERENCES [dbo].[Familia] ([id_familia])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Familia]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Sector] FOREIGN KEY([id_sector])
REFERENCES [dbo].[Sector] ([id_sector])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Sector]
GO
/****** Object:  StoredProcedure [dbo].[actualizar_familiar_usuario]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizar_familiar_usuario]

@iduser int, @idfamilia int

as
begin

update USUARIO 

set ID_FAMILIA=@idfamilia where ID_USUARIO=@iduser
end
GO
/****** Object:  StoredProcedure [dbo].[Alta_Usuario]    Script Date: 25/5/2017 6:59:27 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Alta_Usuario]
@nombre varchar(50), @apellido varchar(50), @username varchar(50), @pass VARCHAR(50) 

as
begin

--declare @iduser int
--set @iduser=(select count (*) from USUARIO)
--if @iduser>0
--begin
--set @iduser =(select max (ID_USUARIO) from USUARIO)
--end
--set @iduser=@iduser+1

insert into dbo.USUARIO (nombre,apellido,username,password)
values (@nombre,@apellido,@username,@pass) 

end
GO
