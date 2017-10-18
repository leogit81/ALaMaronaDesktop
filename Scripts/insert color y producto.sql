USE [alamarona]
GO

INSERT INTO [dbo].[Color]
           ([colorHexa]
           ,[Descripcion])
     VALUES
           ('F00505'
           ,'Un rojito cualquiera que elegí en una página')
GO

USE [alamarona]
GO

INSERT INTO [dbo].[Producto]
           ([Codigo]
           ,[Descripcion]
           ,[Talle]
           ,[idColor])
     VALUES
           ('COD001'
           ,'Producto de prueba'
           ,666
           ,1)
GO


