CONNECT TO 'hipercode@demo_on' USER 'root'  USING 'root';

create table roles(
id smallint not null,
rol varchar(50,1) not null,
primary key(id)
);

create table usuario_rol(
usuario varchar(50,1) not null,
rol smallint not null,
primary key(usuario),
foreign key(rol) references roles(id)
);

grant resource to ndiaz;
grant resource to pbettinelli;
grant resource to nschol;
grant resource to gmachado;
grant resource to hipercode_administrador;
grant resource to hipercode_tecnico;
grant resource to hipercode_asistente;
grant resource to hipercode_guest;
grant all on trabajador to ndiaz

insert into roles values(1,'Administrador');
insert into roles values(2,'Tecnico');
insert into roles values(3,'Asistente');
insert into roles values(4,'Guest');
insert into usuario_rol values('pbettinelli',1);
insert into usuario_rol values('ndiaz',2);
insert into usuario_rol values('gmachado',3);
insert into usuario_rol values('nschol',4);
insert into usuario_rol values('hipercode_administrador',1);
insert into usuario_rol values('hipercode_tecnico',2);
insert into usuario_rol values('hipercode_asistente',3);
insert into usuario_rol values('hipercode_guest',4);