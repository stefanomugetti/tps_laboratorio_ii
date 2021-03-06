USE [Tp4Stefano]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 19/11/2021 12:47:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[Nombre] [nvarchar](50) NOT NULL,
	[Valor] [float] NOT NULL,
	[AñoCreacion] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugadores]    Script Date: 19/11/2021 12:47:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugadores](
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Altura] [float] NOT NULL,
	[Peso] [float] NOT NULL,
	[Nacionalidad] [nvarchar](50) NOT NULL,
	[PieHabil] [nvarchar](50) NOT NULL,
	[Club] [nvarchar](50) NOT NULL,
	[Valor] [float] NOT NULL,
	[Posicion] [nvarchar](50) NOT NULL,
	[Dni] [int] NOT NULL,
 CONSTRAINT [PK_Jugadores] PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Equipos] ([Nombre], [Valor], [AñoCreacion]) VALUES (N'Boca', 650050000, 1988)
INSERT [dbo].[Equipos] ([Nombre], [Valor], [AñoCreacion]) VALUES (N'Huracan', 95000000, 2008)
INSERT [dbo].[Equipos] ([Nombre], [Valor], [AñoCreacion]) VALUES (N'Racing', 650000000, 1918)
INSERT [dbo].[Equipos] ([Nombre], [Valor], [AñoCreacion]) VALUES (N'River', 600000000, 1958)
INSERT [dbo].[Equipos] ([Nombre], [Valor], [AñoCreacion]) VALUES (N'Rivadavia', 500000000, 1920)
INSERT [dbo].[Equipos] ([Nombre], [Valor], [AñoCreacion]) VALUES (N'Independiente', 111111111, 1975)
GO
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Patricio', N'Espinoza', 35, 1.79, 80.6, N'Argentina', N'Derecho', N'Rivadavia', 80000000, N'Mediocampista', 18754689)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Sebastia', N'Escobar', 38, 1.61, 85.9, N'Argentina', N'Derecho', N'Racing', 34005000, N'Defensa', 20245042)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Simon', N'Cinicola', 32, 1.61, 85.9, N'Argentina', N'Izquierdo', N'Racing', 32005000, N'Mediocampista', 20840042)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Fernando', N'Maidana', 19, 1.73, 62.1, N'Argentina', N'Derecho', N'Rivadavia', 292929292, N'Mediocampista', 22333110)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Gonzalo', N'Silveira', 17, 1.61, 85.9, N'Argentina', N'Derecho', N'Racing', 1005000, N'Defensa', 24230042)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Carlos', N'Agostino', 30, 1.61, 85.9, N'Chile', N'Derecho', N'Racing', 6005000, N'Defensa', 24245642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Esteban', N'Ronaldo', 24, 1.87, 72.2, N'Colombia', N'Derecho', N'River', 3005000, N'Defensa', 24853045)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Felipe', N'Lescano', 25, 1.61, 85.9, N'Argentina', N'Derecho', N'Racing', 4505000, N'Defensa', 26445642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Ezequiel', N'Fabra', 17, 1.64, 64.8, N'Ecuador', N'Derecho', N'River', 204655000, N'Delantero', 27653640)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Cristian', N'Riquelme', 37, 1.92, 65.9, N'Argelia', N'Izquierdo', N'River', 30005000, N'Mediocampista', 28233645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Lucio', N'Corral', 27, 1.61, 85.9, N'Argentina', N'Izquierdo', N'Racing', 4005000, N'Delantero', 28240642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Antonio', N'Valencia', 29, 1.74, 65.4, N'Argentina', N'Derecho', N'River', 2000500, N'Delantero', 28253000)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Frank', N'Messi', 26, 1.76, 69.3, N'Argentina', N'Izquierdo', N'River', 20225000, N'Delantero', 28343605)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Alejandro', N'Trojavcich', 32, 1.9, 73.4, N'Argentina', N'Derecho', N'River', 900005000, N'Defensa', 28452645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Mauricio', N'Zarate', 18, 1.72, 73.9, N'Argentina', N'Derecho', N'River', 2000500, N'Mediocampista', 28600645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Mauro', N'Klan', 19, 1.72, 67.9, N'Argentina', N'Derecho', N'River', 20005000, N'Defensa', 28653645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Roberto', N'Ortiz', 22, 1.61, 85.9, N'Argentina', N'Izquierdo', N'Racing', 540050000, N'Mediocampista', 28900108)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Luciano', N'Severino', 20, 1.61, 85.9, N'Chile', N'Derecho', N'Racing', 705000, N'Delantero', 29245640)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Roman', N'Cairo', 35, 1.87, 69, N'Argentina', N'Izquierdo', N'River', 50005000, N'Defensa', 29460045)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Joaquin', N'Altamirano', 21, 1.61, 85.9, N'Argentina', N'Derecho', N'Racing', 5005000, N'Mediocampista', 29908108)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Enrique', N'Ramires', 29, 1.6, 70, N'Argentina', N'Izquierdo', N'boca', 6005001, N'Arquero', 30321341)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Juan', N'Peña', 27, 1.92, 71.7, N'Argentina', N'Izquierdo', N'Huracan', 82005000, N'Mediocampista', 30323642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Valentino', N'Kovak', 40, 1.61, 85.9, N'Paraguay', N'Derecho', N'Racing', 405000, N'Arquero', 30465242)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Nahuel', N'Acuña', 32, 1.61, 85.9, N'Argentina', N'Derecho', N'Racing', 1505000, N'Defensa', 30785642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Tomas', N'Loleo', 20, 1.82, 72.6, N'Colombia', N'Derecho', N'River', 64005000, N'Defensa', 32003205)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Luis', N'Landaberry', 29, 1.61, 85.9, N'Chile', N'Izquierdo', N'Racing', 305000, N'Mediocampista', 32021342)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Gonzalo', N'Blanes', 23, 1.62, 76.3, N'Argentina', N'Derecho', N'River', 30005000, N'Defensa', 32073005)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Willian', N'Gomez', 39, 1.61, 85.9, N'Paraguay', N'Derecho', N'Racing', 20005000, N'Delantero', 32240242)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Felipe', N'Ortiz', 21, 1.61, 85.9, N'Argentina', N'Derecho', N'Huracan', 54005000, N'Delantero', 32245642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Oscar', N'Boscovich', 18, 1.61, 85.9, N'Argentina', N'Derecho', N'Racing', 84505000, N'Delantero', 32279842)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Lucas', N'Ibarra', 27, 1.61, 85.9, N'Argentina', N'Derecho', N'Racing', 1005000, N'Mediocampista', 32655042)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Oscar', N'Romero', 22, 1.64, 80.7, N'Bolivia', N'Derecho', N'Huracan', 23005000, N'Delantero', 34320642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Oscar', N'Serna', 29, 1.62, 87.9, N'Argentina', N'Derecho', N'River', 20097800, N'Mediocampista', 34516645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Carlos', N'Alvarez', 27, 1.92, 67.1, N'Argentina', N'Derecho', N'River', 40005000, N'Defensa', 34623635)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Mariano', N'Mugetti', 19, 1.82, 62.9, N'Argentina', N'Derecho', N'River', 7895000, N'Mediocampista', 34653645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Felipe', N'Ortiz', 35, 1.79, 77.6, N'Argentina', N'Derecho', N'Huracan', 62005000, N'Mediocampista', 35134942)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Heber', N'Martinez', 21, 1.92, 71.3, N'Argentina', N'Derecho', N'river', 700000, N'Delantero', 35420154)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Thomas', N'Folmer', 20, 1.73, 73.3, N'Argentina', N'Izquierdo', N'Boca', 60500000, N'Defensa', 36546918)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Douglas', N'Rodriguez', 26, 1.69, 73.5, N'Bolivia', N'Derecho', N'Huracan', 72005000, N'Mediocampista', 37933642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Stefano', N'Romero', 30, 1.67, 75.3, N'Ecuador', N'Derecho', N'Huracan', 54005000, N'Delantero', 38304642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Julio', N'Mendez', 26, 1.65, 78.8, N'Argentina', N'Derecho', N'Boca', 1600000, N'Mediocampista', 38945762)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Ramiro', N'McQueen', 30, 1.92, 70.2, N'Italia', N'Derecho', N'River', 20005000, N'Defensa', 40000000)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Martin', N'Stanley', 34, 1.75, 82.1, N'España', N'Derecho', N'River', 29705000, N'Mediocampista', 40070645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Luis', N'Zapata', 18, 1.63, 67.2, N'Argentina', N'Derecho', N'Boca', 100000, N'Arquero', 40213649)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Enrique', N'Ortiz', 25, 1.69, 70.3, N'Bolivia', N'Derecho', N'River', 92005000, N'Arquero', 40323642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Lionel', N'Boscovich', 27, 1.65, 81.8, N'Colombia', N'Derecho', N'River', 64505000, N'Mediocampista', 40873045)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Marcos', N'Abreu', 35, 1.84, 80.3, N'Bolivia', N'Derecho', N'Huracan', 920050000, N'Defensa', 41323642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Oscar', N'Medina', 30, 1.88, 77.4, N'Chile', N'Derecho', N'River', 11325000, N'Mediocampista', 42000009)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Alberto', N'Severino', 34, 1.78, 79.7, N'España', N'Derecho', N'River', 98705000, N'Delantero', 42015645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Juan', N'Bleit', 29, 1.75, 75.6, N'Argentina', N'Derecho', N'Boca', 6000000, N'Delantero', 42322332)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Pablo', N'Aguilar', 19, 1.92, 70.6, N'Argentina', N'Derecho', N'Huracan', 950050000, N'Defensa', 42324316)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Fernando', N'Maidana', 34, 1.82, 70.3, N'Argentina', N'Derecho', N'Boca', 16005000, N'Mediocampista', 42873645)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Felipe', N'Zarate', 32, 1.8, 76.3, N'Colombia', N'Derecho', N'River', 17895000, N'Arquero', 42874319)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Roberto', N'Fornari', 24, 1.83, 69.5, N'Ecuador', N'Derecho', N'River', 35405000, N'Delantero', 42876735)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Patricio', N'Espinoza', 26, 1.84, 80.9, N'Argentina', N'Izquierdo', N'Boca', 9850000, N'Mediocampista', 43002052)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Ignacio', N'Straneo', 24, 1.8, 75.2, N'Bolivia', N'Derecho', N'Huracan', 92325000, N'Defensa', 43323642)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Agustin', N'Rossi', 18, 1.73, 72.3, N'Argentina', N'Derecho', N'River', 14565000, N'Mediocampista', 43812345)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Stefano', N'Mugetti', 20, 1.82, 67.5, N'Argentina', N'Derecho', N'Rivadavia', 99999999, N'Defensa', 44320339)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Nicolas', N'Guridi', 20, 1.86, 90.3, N'Ecuador', N'Derecho', N'Huracan', 9200500, N'Defensa', 44431672)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Gabriel', N'Lopez', 27, 1.93, 77.3, N'Argentina', N'Derecho', N'Boca', 4900500, N'Defensa', 45221730)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Genaro', N'Rios', 19, 1.91, 68.9, N'Argentina', N'Derecho', N'Boca', 65200000, N'Defensa', 46578203)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Leandro', N'Leguizamon', 19, 1.74, 66.7, N'Argentina', N'Derecho', N'Boca', 9800000, N'Mediocampista', 46792587)
INSERT [dbo].[Jugadores] ([Nombre], [Apellido], [Edad], [Altura], [Peso], [Nacionalidad], [PieHabil], [Club], [Valor], [Posicion], [Dni]) VALUES (N'Pepe', N'Peposo', 20, 1.92, 71.6, N'Holanda', N'Izquierdo', N'Rivadavia', 2222222, N'Defensa', 78954126)
GO
