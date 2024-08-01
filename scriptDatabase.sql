USE [master]
GO

/****** Object:  Database [TiendaDB]    Script Date: 31/7/2024 23:10:51 ******/
CREATE DATABASE [TiendaDB]
GO

USE [TiendaDB]
GO

USE [TiendaDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 31/7/2024 23:15:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 31/7/2024 23:15:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 31/7/2024 23:15:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[Stock] [int] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductosDeseados]    Script Date: 31/7/2024 23:15:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductosDeseados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[NombreUsuario] [nvarchar](max) NOT NULL,
	[FechaCreacion] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProductosDeseados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240731230040_001', N'8.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240801035605_002', N'8.0.0')
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([Id], [Nombre]) VALUES (1, N'Hogar')
INSERT [dbo].[Categorias] ([Id], [Nombre]) VALUES (2, N'Tecnologia')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (5, N'Play Station', N'consola', 2, 1)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (6, N'celular', N'consola', 2, 10)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (7, N'Lampara led', N'Lampara de neon azul', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (8, N'Escritorio gamer', N'Esritorio', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (9, N'Lampara led azul', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (10, N'Lampara led roja', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (11, N'Lampara led verde ', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (12, N'Lampara led morado', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (13, N'Lampara led celeste', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (14, N'Lampara led amarillo', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (15, N'Lampara led rosado', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (16, N'Lampara led fucsia', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (17, N'Lampara led café', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (18, N'Lampara led 2', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (19, N'Lampara led 3', N'Lampara de neon', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (20, N'Lampara led', N'Lampara de neon azul', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (21, N'Escritorio gamer', N'Esritorio', 1, 3)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (22, N'Lampara led azul 1', N'Lampara de neon', 1, 1)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (23, N'Lampara led roja 2', N'Lampara de neon', 1, 24)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (24, N'Lampara led verde 3', N'Lampara de neon', 1, 43)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (25, N'Lampara led morado 4', N'Lampara de neon', 1, 33)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (26, N'Lampara led celeste 5', N'Lampara de neon', 1, 31)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (27, N'Lampara led amarillo 6', N'Lampara de neon', 1, 13)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (28, N'Lampara led rosado 7', N'Lampara de neon', 1, 34)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (29, N'Lampara led fucsia 8', N'Lampara de neon', 1, 10)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (30, N'Lampara led café 9', N'Lampara de neon', 1, 20)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (31, N'Lampara led 2 10', N'Lampara de neon', 1, 15)
INSERT [dbo].[Productos] ([Id], [Nombre], [Descripcion], [CategoriaId], [Stock]) VALUES (32, N'Lampara led 3 11', N'Lampara de neon', 1, 10)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductosDeseados] ON 

INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (1, 5, N'elias', CAST(N'2024-07-31T20:05:03.7401750' AS DateTime2))
INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (2, 6, N'pepito', CAST(N'2024-07-31T20:09:20.2275682' AS DateTime2))
INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (3, 5, N'elias', CAST(N'2024-07-31T20:09:55.2797361' AS DateTime2))
INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (4, 5, N'xavier', CAST(N'2024-07-31T20:31:21.6713705' AS DateTime2))
INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (5, 6, N'fsds', CAST(N'2024-07-31T20:55:20.3872270' AS DateTime2))
INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (6, 5, N'pepito', CAST(N'2024-07-31T22:16:54.2368413' AS DateTime2))
INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (7, 5, N'martin', CAST(N'2024-07-31T22:17:05.8093470' AS DateTime2))
INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (8, 9, N'pedro', CAST(N'2024-07-31T22:29:25.2265863' AS DateTime2))
INSERT [dbo].[ProductosDeseados] ([Id], [ProductId], [NombreUsuario], [FechaCreacion]) VALUES (9, 28, N'pedro', CAST(N'2024-07-31T22:57:53.0781766' AS DateTime2))
SET IDENTITY_INSERT [dbo].[ProductosDeseados] OFF
GO
