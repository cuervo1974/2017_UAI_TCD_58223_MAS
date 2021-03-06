USE [master]
GO
/****** Object:  Database [SGISI]    Script Date: 10 jul. 2017 03:06:27 ******/
CREATE DATABASE [SGISI]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SGISI', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.UAI\MSSQL\DATA\SGISI.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SGISI_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.UAI\MSSQL\DATA\SGISI_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SGISI] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SGISI].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SGISI] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SGISI] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SGISI] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SGISI] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SGISI] SET ARITHABORT OFF 
GO
ALTER DATABASE [SGISI] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SGISI] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SGISI] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SGISI] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SGISI] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SGISI] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SGISI] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SGISI] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SGISI] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SGISI] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SGISI] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SGISI] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SGISI] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SGISI] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SGISI] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SGISI] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SGISI] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SGISI] SET RECOVERY FULL 
GO
ALTER DATABASE [SGISI] SET  MULTI_USER 
GO
ALTER DATABASE [SGISI] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SGISI] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SGISI] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SGISI] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SGISI] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SGISI', N'ON'
GO
ALTER DATABASE [SGISI] SET QUERY_STORE = OFF
GO
USE [SGISI]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [SGISI]
GO
/****** Object:  Table [dbo].[DigitoVerificadorVertical]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[EventoBitacora]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[Familia]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[Idioma]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[Palabra]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[PalabraTraducida]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[Patente]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[Sector]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 10 jul. 2017 03:06:27 ******/
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
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (11, 5, CAST(N'2017-06-05' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (12, 5, CAST(N'2017-06-05' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (13, 5, CAST(N'2017-06-05' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (14, 5, CAST(N'2017-06-05' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (15, 5, CAST(N'2017-06-05' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (16, 5, CAST(N'2017-06-13' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (17, 5, CAST(N'2017-06-13' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (18, 5, CAST(N'2017-06-13' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (19, 5, CAST(N'2017-06-13' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (20, 5, CAST(N'2017-06-19' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (21, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (22, 5, CAST(N'2017-06-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (23, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (24, 5, CAST(N'2017-06-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (25, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (26, 5, CAST(N'2017-06-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (27, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (28, 5, CAST(N'2017-06-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (29, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (30, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (31, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (32, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (33, 5, CAST(N'2017-06-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (34, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (35, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (36, 5, CAST(N'2017-06-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (37, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (38, 5, CAST(N'2017-06-23' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1021, 5, CAST(N'2017-06-23' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1022, 5, CAST(N'2017-07-03' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1023, 5, CAST(N'2017-07-03' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1024, 5, CAST(N'2017-07-03' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1025, 5, CAST(N'2017-07-03' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1026, 5, CAST(N'2017-07-03' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1027, 5, CAST(N'2017-07-03' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1028, 5, CAST(N'2017-07-04' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1029, 5, CAST(N'2017-07-04' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1030, 5, CAST(N'2017-07-04' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1031, 5, CAST(N'2017-07-04' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1032, 5, CAST(N'2017-07-04' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1033, 5, CAST(N'2017-07-04' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1034, 5, CAST(N'2017-07-04' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1035, 5, CAST(N'2017-07-04' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1036, 5, CAST(N'2017-07-04' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1037, 5, CAST(N'2017-07-04' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1038, 5, CAST(N'2017-07-04' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1039, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1040, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1041, 5, CAST(N'2017-07-09' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1042, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1043, 5, CAST(N'2017-07-09' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1044, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1045, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1046, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1047, 5, CAST(N'2017-07-09' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1048, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1049, 5, CAST(N'2017-07-09' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1050, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1051, 5, CAST(N'2017-07-09' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1052, 5, CAST(N'2017-07-09' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1053, 5, CAST(N'2017-07-09' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1054, 5, CAST(N'2017-07-10' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1055, 5, CAST(N'2017-07-10' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1056, 5, CAST(N'2017-07-10' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1057, 5, CAST(N'2017-07-10' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1058, 5, CAST(N'2017-07-10' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1059, 5, CAST(N'2017-07-10' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1060, 5, CAST(N'2017-07-10' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1061, 5, CAST(N'2017-07-10' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1062, 5, CAST(N'2017-07-10' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1063, 5, CAST(N'2017-07-10' AS Date), N'Salió')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1064, 5, CAST(N'2017-07-10' AS Date), N'Ingresó')
INSERT [dbo].[EventoBitacora] ([id_evento_bitacora], [id_usuario], [fecha], [descripcion]) VALUES (1065, 5, CAST(N'2017-07-10' AS Date), N'Salió')
SET IDENTITY_INSERT [dbo].[EventoBitacora] OFF
SET IDENTITY_INSERT [dbo].[Familia] ON 

INSERT [dbo].[Familia] ([id_familia], [nombre]) VALUES (1, N'Administrador')
INSERT [dbo].[Familia] ([id_familia], [nombre]) VALUES (2, N'Responsable')
INSERT [dbo].[Familia] ([id_familia], [nombre]) VALUES (3, N'Tecnico')
SET IDENTITY_INSERT [dbo].[Familia] OFF
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 1)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 2)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 3)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 4)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 5)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 6)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 7)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 8)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 9)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 10)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 11)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 12)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (1, 13)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (2, 3)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (2, 9)
INSERT [dbo].[FamiliaPatente] ([id_familia], [id_patente]) VALUES (3, 3)
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([id_idioma], [nombre]) VALUES (1, N'Inglés')
INSERT [dbo].[Idioma] ([id_idioma], [nombre]) VALUES (2, N'Portugués')
INSERT [dbo].[Idioma] ([id_idioma], [nombre]) VALUES (3, N'Alemán')
INSERT [dbo].[Idioma] ([id_idioma], [nombre]) VALUES (4, N'Francés')
INSERT [dbo].[Idioma] ([id_idioma], [nombre]) VALUES (5, N'Italiano')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
SET IDENTITY_INSERT [dbo].[Palabra] ON 

INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (1, N'Usuario')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (2, N'Contraseña')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (3, N'Ingresar')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (4, N'Salir')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (5, N'Idiomas')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (6, N'Familias')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (7, N'Nombre')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (8, N'Apellido')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (9, N'Sector')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (10, N'Familia')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (11, N'Aceptar')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (12, N'Cancelar')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (13, N'Agregar')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (14, N'Anular')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (15, N'Dejar el campo "Contraseña" vacío si no se desea modificar.')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (16, N'Cambiar Idioma')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (17, N'Accesos')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (18, N'Inventario')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (19, N'Bitacora')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (20, N'Soporte')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (21, N'Reportes')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (22, N'Apertura SR')
INSERT [dbo].[Palabra] ([id_palabra], [cadena]) VALUES (23, N'Usuarios')
SET IDENTITY_INSERT [dbo].[Palabra] OFF
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 1, N'User')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 2, N'Password')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 3, N'Enter')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 4, N'Exit')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 5, N'Languages')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 6, N'Families')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 7, N'First Name')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 8, N'Last Name')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 9, N'Department')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 10, N'Family')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 11, N'Accept')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 12, N'Cancel')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 13, N'Add')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 14, N'Cancel')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 15, N'Leave empty "Password" field if you do not want to change.')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 16, N'Change Language')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 17, N'Access')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 18, N'Inventory')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 19, N'Logs')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 20, N'Support')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 21, N'Reports')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 22, N'Open SR')
INSERT [dbo].[PalabraTraducida] ([id_idioma], [id_palabra], [cadena_traducida]) VALUES (1, 23, N'Users')
SET IDENTITY_INSERT [dbo].[Patente] ON 

INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (1, NULL, N'Accesos', NULL, N'Seguridad')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (2, 1, N'Usuarios', N'FormUsuarios', N'Personas')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (3, NULL, N'Soporte', NULL, N'Hoja')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (4, 3, N'Apertura SR', N'FormSoporte', N'Hoja')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (5, 1, N'Familias', N'FormFamilias', N'Conexiones')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (6, NULL, N'Idiomas', N'FormIdiomas', N'Palabras')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (7, NULL, N'Inventario', N'FormInventario', N'Configuracion')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (8, NULL, N'Bitacora', N'FormEventosBitacora', N'Lupa')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (9, NULL, N'Reportes', NULL, N'Grafico_Torta')
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (10, 9, N'Resporte Tickets', N'FormReporteTickets', NULL)
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (11, 9, N'Reporte Horas', N'FormReporteHoras', NULL)
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (12, 9, N'Reporte Tickets Usuario', N'FormReporteTicketUsuario', NULL)
INSERT [dbo].[Patente] ([id_patente], [id_padre], [nombre], [formulario], [imagen]) VALUES (13, 9, N'Reporte Horas Usuario', N'FormReporteHorasUsuario', NULL)
SET IDENTITY_INSERT [dbo].[Patente] OFF
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
/****** Object:  StoredProcedure [dbo].[actualizar_familiar_usuario]    Script Date: 10 jul. 2017 03:06:27 ******/
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
/****** Object:  StoredProcedure [dbo].[Alta_Usuario]    Script Date: 10 jul. 2017 03:06:27 ******/
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
USE [master]
GO
ALTER DATABASE [SGISI] SET  READ_WRITE 
GO
