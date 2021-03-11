Create database userm
go

use userm
GO

create table Usuarios(
id int identity(1,1)primary key,
nombre varchar(50) not null,
correo varchar(50) not null, 
telefono varchar(20) not null

)
go


insert Usuarios(nombre,correo,telefono) values ('Kattia','krm@gmail.com','70619944')

Select * from Usuarios

update Usuarios set correo ='mbr@gmail.com' 