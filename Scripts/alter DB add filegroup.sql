alter database alamarona
add filegroup imagenesProductos;
go
alter database alamarona
add file(
 name = 'imagenesProductos',
 filename='C:\Users\Administrator\imagenesProductosALaMarona.mdf'
) to filegroup imagenesProductos;