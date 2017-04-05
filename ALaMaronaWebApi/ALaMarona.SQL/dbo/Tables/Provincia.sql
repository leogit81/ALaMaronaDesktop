CREATE TABLE [dbo].[Provincia]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] VARCHAR(150) NOT NULL, 
    [IdPais] INT NOT NULL, 
    CONSTRAINT [FK_Provincia_Pais] FOREIGN KEY ([IdPais]) REFERENCES [Pais]([Id])
)
