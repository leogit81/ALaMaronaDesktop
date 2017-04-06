CREATE TABLE [dbo].[Localidad]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] VARCHAR(150) NOT NULL, 
    [IdProvincia] INT NULL, 
    CONSTRAINT [FK_Localidad_Provincia] FOREIGN KEY ([IdProvincia]) REFERENCES [Provincia]([Id])
)
