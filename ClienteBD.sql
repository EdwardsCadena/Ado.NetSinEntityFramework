Create database PruebaTecnica
use PruebaTecnica

Create table Cliente
(
IdCliente int identity Primary Key,
Nombres varchar (55) not null,
Apellidos varchar (55) not null,
Direccion varchar (55) not null
)
insert into cliente (Nombres,Apellidos,Direccion) values ('Edward','cadena','keera 2 b #12-12')


select * from Cliente

