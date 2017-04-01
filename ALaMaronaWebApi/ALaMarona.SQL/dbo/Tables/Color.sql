CREATE TABLE [dbo].[Color] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [colorHexa]   NCHAR (6)     NULL,
    [Descripcion] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED ([id] ASC)
);

