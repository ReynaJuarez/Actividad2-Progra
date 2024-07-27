CREATE TABLE [dbo].[Peliculas]
(
	[IdPeliculas] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Titulo] CHAR(100) NULL, 
    [Autor] CHAR(50) NULL, 
    [Sinopsis] CHAR(200) NULL, 
    [Duracion ] CHAR(30) NULL, 
    [Clasificacion] CHAR(40) NULL
)
