 use ProyectoW
  
select * from Candidatos
select * from Ordenes
select * from Empresas
select * from Referencias
select * from Asesores
select * from Nacionalidad
select * from Cuentas

insert into Cuentas(CreatedAT,Estatus,Usuario,Correo,Contrasenia)
values ('2020-07-01 00:00:00.0000000',1,'Nidia Avila','nidiax@gmail.com','12345')
insert into Cuentas(CreatedAT,Estatus,Usuario,Correo,Contrasenia)
values ('2020-07-01 00:00:00.0000000',1,'Roberto Chi','robx@gmail.com','123456')


 insert into asesores (CreatedAT,Estatus,Nombre,Correo,CuentaId)values ('2020-07-01 00:00:00.0000000',1,'Nidia Avila','nidiax@gmail.com',1)
  insert into asesores (CreatedAT,Estatus,Nombre,Correo,CuentaId)values ('2020-07-05 00:00:00.0000000',1,'Roberto Chi','robx@gmail.com',2)

insert into Nacionalidad (CreatedAT,Estatus,TipoNa) values('2020-07-23 00:00:00.0000000',1,'Braseliño')
insert into Nacionalidad (CreatedAT,Estatus,TipoNa) values('2020-08-12 00:00:00.0000000',1,'Español')
insert into Nacionalidad (CreatedAT,Estatus,TipoNa)	values('2020-08-1 00:00:00.0000000',1,'Canadiense')
insert into Nacionalidad (CreatedAT,Estatus,TipoNa)	values('2020-08-1 00:00:00.0000000',1,'Chileno')
insert into Nacionalidad (CreatedAT,Estatus,TipoNa)	values('2020-08-1 00:00:00.0000000',1,'Mexicano')