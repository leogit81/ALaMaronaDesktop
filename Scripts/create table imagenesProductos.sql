USE [alamarona]
GO

/****** Object:  Table [dbo].[ImagenProducto]    Script Date: 26/11/2016 11:25:14 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ImagenProducto](
	[id] [bigint] NOT NULL,
	[idProducto] [bigint] NOT NULL,
	[imagen] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_ImagenProducto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [imagenesProductos]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[ImagenProducto]  WITH CHECK ADD  CONSTRAINT [FK_ImagenProducto_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([id])
GO

ALTER TABLE [dbo].[ImagenProducto] CHECK CONSTRAINT [FK_ImagenProducto_Producto]
GO


