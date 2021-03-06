USE [master]
GO
/****** Object:  Database [videoclub_db1]    Script Date: 11/10/2016 11:47:55 PM ******/
CREATE DATABASE [videoclub_db1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'videoclub_db1', FILENAME = N'F:\Mis Archivos\Software projects\C#\VideoClub\VideoClub\MaxVideoClub\db\videoclub_db1.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'videoclub_db1_log', FILENAME = N'F:\Mis Archivos\Software projects\C#\VideoClub\VideoClub\MaxVideoClub\db\videoclub_db1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [videoclub_db1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [videoclub_db1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [videoclub_db1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [videoclub_db1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [videoclub_db1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [videoclub_db1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [videoclub_db1] SET ARITHABORT OFF 
GO
ALTER DATABASE [videoclub_db1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [videoclub_db1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [videoclub_db1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [videoclub_db1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [videoclub_db1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [videoclub_db1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [videoclub_db1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [videoclub_db1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [videoclub_db1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [videoclub_db1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [videoclub_db1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [videoclub_db1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [videoclub_db1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [videoclub_db1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [videoclub_db1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [videoclub_db1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [videoclub_db1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [videoclub_db1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [videoclub_db1] SET  MULTI_USER 
GO
ALTER DATABASE [videoclub_db1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [videoclub_db1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [videoclub_db1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [videoclub_db1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [videoclub_db1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [videoclub_db1]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 11/10/2016 11:47:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[User] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Tipo_de_cuenta] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 11/10/2016 11:47:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[NumDeCliente] [int] NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[En_renta] [int] NOT NULL,
	[Fecha_Alta] [varchar](50) NOT NULL,
	[Folio_IFE] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[peliculas]    Script Date: 11/10/2016 11:47:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[peliculas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](50) NOT NULL,
	[Anio] [int] NULL,
	[Genero] [varchar](50) NULL,
	[Existencias] [int] NULL,
	[Fecha_de_ingreso] [varchar](50) NULL,
	[En_renta] [int] NULL,
	[Disponibles] [int] NULL,
 CONSTRAINT [PK_peliculas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 11/10/2016 11:47:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prestamos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TituloDePelicula] [varchar](50) NOT NULL,
	[NumeroDeCliente] [int] NOT NULL,
	[NombreDeCliente] [varchar](50) NOT NULL,
	[Fecha_De_Entrega] [varchar](50) NOT NULL,
	[Fecha_De_Devolucion] [varchar](50) NOT NULL,
	[Multa] [int] NULL,
 CONSTRAINT [PK_Prestamos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD  CONSTRAINT [FK_Prestamos_Prestamos] FOREIGN KEY([id])
REFERENCES [dbo].[Prestamos] ([id])
GO
ALTER TABLE [dbo].[Prestamos] CHECK CONSTRAINT [FK_Prestamos_Prestamos]
GO
USE [master]
GO
ALTER DATABASE [videoclub_db1] SET  READ_WRITE 
GO
