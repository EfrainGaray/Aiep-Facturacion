USE [master]
GO
/****** Object:  Database [aiepFacturacion]    Script Date: 21-11-2020 23:48:52 ******/
CREATE DATABASE [aiepFacturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'aiepFacturacion', FILENAME = N'/var/opt/mssql/data/aiepFacturacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'aiepFacturacion_log', FILENAME = N'/var/opt/mssql/data/aiepFacturacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [aiepFacturacion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aiepFacturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [aiepFacturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [aiepFacturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [aiepFacturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [aiepFacturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [aiepFacturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [aiepFacturacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [aiepFacturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [aiepFacturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [aiepFacturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [aiepFacturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [aiepFacturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [aiepFacturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [aiepFacturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [aiepFacturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [aiepFacturacion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [aiepFacturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [aiepFacturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [aiepFacturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [aiepFacturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [aiepFacturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [aiepFacturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [aiepFacturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [aiepFacturacion] SET RECOVERY FULL 
GO
ALTER DATABASE [aiepFacturacion] SET  MULTI_USER 
GO
ALTER DATABASE [aiepFacturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [aiepFacturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [aiepFacturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [aiepFacturacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [aiepFacturacion] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'aiepFacturacion', N'ON'
GO
ALTER DATABASE [aiepFacturacion] SET QUERY_STORE = OFF
GO
USE [aiepFacturacion]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 21-11-2020 23:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rut] [varchar](12) NOT NULL,
	[razonSocial] [varchar](45) NOT NULL,
	[direccion] [varchar](80) NULL,
	[telefono] [varchar](15) NULL,
	[email] [varchar](45) NULL,
	[fechaCreacion] [datetime2](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [razonSocial_UNIQUE] UNIQUE NONCLUSTERED 
(
	[razonSocial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [rut_UNIQUE] UNIQUE NONCLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalleDocumento]    Script Date: 21-11-2020 23:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleDocumento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cantidadProducto] [int] NOT NULL,
	[precioProducto] [int] NOT NULL,
	[producto_id] [int] NOT NULL,
	[documento_id] [int] NOT NULL,
	[estado] [smallint] NOT NULL,
	[fechaCreacion] [datetime2](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[documento]    Script Date: 21-11-2020 23:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[documento](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[folio] [varchar](12) NOT NULL,
	[estado] [smallint] NOT NULL,
	[subtotal] [int] NULL,
	[iva] [int] NULL,
	[total] [int] NULL,
	[tipoPago] [smallint] NULL,
	[cliente_id] [int] NOT NULL,
	[empresa_id] [int] NOT NULL,
	[tipoDocumento_id] [int] NOT NULL,
	[fechaCreacion] [datetime2](0) NOT NULL,
	[fechaEmision] [datetime2](7) NULL,
	[observacion] [varchar](80) NULL,
	[creadoPor] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [folio_UNIQUE] UNIQUE NONCLUSTERED 
(
	[folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empresa]    Script Date: 21-11-2020 23:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empresa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rut] [varchar](12) NOT NULL,
	[razonSocial] [varchar](45) NOT NULL,
	[giro] [varchar](255) NULL,
	[direccion] [varchar](80) NULL,
	[telefono] [varchar](15) NULL,
	[email] [varchar](45) NULL,
	[fechaCreacion] [datetime2](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [razon2Social_UNIQUE] UNIQUE NONCLUSTERED 
(
	[razonSocial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [rut2_UNIQUE] UNIQUE NONCLUSTERED 
(
	[rut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 21-11-2020 23:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[empresa_id] [int] NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[codigo] [varchar](12) NOT NULL,
	[stock] [int] NOT NULL,
	[descipcion] [varchar](100) NULL,
	[precio] [int] NOT NULL,
	[fechaCreacion] [datetime2](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [codigo_UNIQUE] UNIQUE NONCLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoDocumento]    Script Date: 21-11-2020 23:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoDocumento](
	[id] [int] NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[fechaCreacion] [datetime2](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 21-11-2020 23:48:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](10) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[fechaCreacion] [datetime2](0) NOT NULL,
	[id_empresa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [usuario_UNIQUE] UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [fk_factura_cliente_idx]    Script Date: 21-11-2020 23:48:56 ******/
CREATE NONCLUSTERED INDEX [fk_factura_cliente_idx] ON [dbo].[documento]
(
	[cliente_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_factura_empresa1_idx]    Script Date: 21-11-2020 23:48:56 ******/
CREATE NONCLUSTERED INDEX [fk_factura_empresa1_idx] ON [dbo].[documento]
(
	[empresa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_factura_tipoDocumento1_idx]    Script Date: 21-11-2020 23:48:56 ******/
CREATE NONCLUSTERED INDEX [fk_factura_tipoDocumento1_idx] ON [dbo].[documento]
(
	[tipoDocumento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[detalleDocumento] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[detalleDocumento] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[documento] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[documento] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[documento] ADD  CONSTRAINT [df_fechaEmision]  DEFAULT ('01/01/1000') FOR [fechaEmision]
GO
ALTER TABLE [dbo].[empresa] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[producto] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[tipoDocumento] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[usuario] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO
ALTER TABLE [dbo].[detalleDocumento]  WITH CHECK ADD  CONSTRAINT [fk_detalleFactura_factura1] FOREIGN KEY([documento_id])
REFERENCES [dbo].[documento] ([id])
GO
ALTER TABLE [dbo].[detalleDocumento] CHECK CONSTRAINT [fk_detalleFactura_factura1]
GO
ALTER TABLE [dbo].[detalleDocumento]  WITH CHECK ADD  CONSTRAINT [fk_detalleFactura_producto1] FOREIGN KEY([producto_id])
REFERENCES [dbo].[producto] ([id])
GO
ALTER TABLE [dbo].[detalleDocumento] CHECK CONSTRAINT [fk_detalleFactura_producto1]
GO
ALTER TABLE [dbo].[documento]  WITH CHECK ADD  CONSTRAINT [fk_factura_cliente] FOREIGN KEY([cliente_id])
REFERENCES [dbo].[cliente] ([id])
GO
ALTER TABLE [dbo].[documento] CHECK CONSTRAINT [fk_factura_cliente]
GO
ALTER TABLE [dbo].[documento]  WITH CHECK ADD  CONSTRAINT [fk_factura_empresa1] FOREIGN KEY([empresa_id])
REFERENCES [dbo].[empresa] ([id])
GO
ALTER TABLE [dbo].[documento] CHECK CONSTRAINT [fk_factura_empresa1]
GO
ALTER TABLE [dbo].[documento]  WITH CHECK ADD  CONSTRAINT [fk_factura_tipoDocumento1] FOREIGN KEY([tipoDocumento_id])
REFERENCES [dbo].[tipoDocumento] ([id])
GO
ALTER TABLE [dbo].[documento] CHECK CONSTRAINT [fk_factura_tipoDocumento1]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [fk_producto_empresa1] FOREIGN KEY([empresa_id])
REFERENCES [dbo].[empresa] ([id])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [fk_producto_empresa1]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_empresa_Usuario] FOREIGN KEY([id_empresa])
REFERENCES [dbo].[empresa] ([id])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_empresa_Usuario]
GO
USE [master]
GO
ALTER DATABASE [aiepFacturacion] SET  READ_WRITE 
GO
