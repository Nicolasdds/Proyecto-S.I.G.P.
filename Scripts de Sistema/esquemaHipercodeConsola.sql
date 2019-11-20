CONNECT TO 'hipercode@demo_on' USER 'root'  USING 'root';

DROP TABLE IF EXISTS empresa;
DROP TABLE IF EXISTS prevencionista;
DROP TABLE IF EXISTS trabajador;
DROP TABLE IF EXISTS relevamiento;
DROP TABLE IF EXISTS reporte;
DROP TABLE IF EXISTS cuestionario;
DROP TABLE IF EXISTS pregunta;
DROP TABLE IF EXISTS mapa;
DROP TABLE IF EXISTS icono;
DROP TABLE IF EXISTS calculo;
DROP TABLE IF EXISTS inventario;
DROP TABLE IF EXISTS plan;
DROP TABLE IF EXISTS inspeccion;
DROP TABLE IF EXISTS observacion;
DROP TABLE IF EXISTS contrata;
DROP TABLE IF EXISTS tiene;
DROP TABLE IF EXISTS hace;
DROP TABLE IF EXISTS a;
DROP TABLE IF EXISTS genera;
DROP TABLE IF EXISTS responde;
DROP TABLE IF EXISTS contiene;
DROP TABLE IF EXISTS realiza;
DROP TABLE IF EXISTS sobre;
DROP TABLE IF EXISTS roles;
DROP TABLE IF EXISTS usuario_rol;

grant dba to "root";



{ TABLE "root".empresa row size = 133 number of columns = 6 index size = 18 }

create table "root".empresa 
  (
    rut char(12),
    razon_social varchar(20),
    rubro varchar(15),
    telefono varchar(10),
    mail varchar(20),
    direccion varchar(50),
    primary key (rut) 
  );

revoke all on "root".empresa from "public" as "root";

{ TABLE "root".prevencionista row size = 104 number of columns = 5 index size = 15 }

create table "root".prevencionista 
  (
    ci_pr char(10),
    nom_pr varchar(15),
    ape_pr varchar(15),
    tel_pr varchar(10),
    dom_pr varchar(50),
    usr_pr varchar(30),
    primary key (ci_pr) 
  );

revoke all on "root".prevencionista from "public" as "root";

{ TABLE "root".trabajador row size = 112 number of columns = 6 index size = 15 }

create table "root".trabajador 
  (
    ci_tr char(10),
    nom_tr varchar(15),
    ape_tr varchar(15),
    capacitaciones varchar(255,0),
    primary key (ci_tr) 
  );

revoke all on "root".trabajador from "public" as "root";

{ TABLE "root".relevamiento row size = 12 number of columns = 3 index size = 9 }

create table "root".relevamiento 
  (
    id_relev serial not null ,
    fecha_inicio date not null,
    fecha_fin date,
    primary key (id_relev) 
  );

revoke all on "root".relevamiento from "public" as "root";

{ TABLE "root".reporte row size = 130 number of columns = 6 index size = 9 }

create table "root".reporte 
  (
    id_rep serial not null ,
    fecha_prev date,
    titulo varchar(15),
    acotaciones varchar(50),
    descripciones varchar(50),
    fecha_realizado date,
    tecnico varchar(25),
    primary key (id_rep) 
  );

revoke all on "root".reporte from "public" as "root";

{ TABLE "root".cuestionario row size = 57 number of columns = 7 index size = 22 }

create table "root".cuestionario 
  (
    id_cuestionario serial not null ,
    id_relev integer,
    nom_cuestionario varchar(25),
    area_trabajo varchar(20),
    pers_totales integer,
    pers_afec integer,
    res_subjetivo char(2),
    fecha_prox_cuest date,
    fecha_creado date,
    primary key (id_cuestionario,id_relev) 
  );

revoke all on "root".cuestionario from "public" as "root";

{ TABLE "root".pregunta row size = 124 number of columns = 9 index size = 42 }

create table "root".pregunta 
  (
    serie_preg serial not null,
    nro_preg integer not null,
    enunciado varchar(150),
    ponderacion integer,
    obs_respuesta varchar(150),
    id_cuestionario integer,
    id_relev integer,
    id_rep integer,
    primary key (serie_preg,nro_preg,id_cuestionario) 
  );

revoke all on "root".pregunta from "public" as "root";

{ TABLE "root".mapa row size = 63 number of columns = 4 index size = 22 }

create table "root".mapa 
  (
    id_mapa serial not null,
    titulo varchar(50),
    ruta varchar(150),
    fecha_creado date,
    id_relev integer,
    primary key (id_mapa,id_relev) 
  );

revoke all on "root".mapa from "public" as "root";

{ TABLE "root".icono row size = 137 number of columns = 4 index size = 9 }

create table "root".icono 
  (
    id_icono serial not null ,
    tipo_icono varchar(15),
    nom_icono varchar(15),
    ruta varchar(100),
    primary key (id_icono) 
  );

revoke all on "root".icono from "public" as "root";

{ TABLE "root".calculo row size = 36 number of columns = 9 index size = 22 }

create table "root".calculo 
  (
    id_calculo serial not null ,
    id_relev integer,
    id_cuestionario integer,
    nivel_d integer,
    nivel_p integer,
    nivel_r integer,
    nivel_i varchar(5),
    nivel_e integer,
    nivel_c integer,
    nivel_rep integer,
    f_ponderacion integer,
    primary key (id_calculo,id_relev) 
  );

revoke all on "root".calculo from "public" as "root";

{ TABLE "root".inventario row size = 55 number of columns = 6 index size = 33 }

create table "root".inventario 
  (
    serie_objeto serial not null ,
    nom_obj varchar(10),
    tipo_obj varchar(15),
    cant_obj integer,
    estado varchar(25),
    id_relev integer,
    primary key (serie_objeto,nom_obj,id_relev) 
  );

revoke all on "root".inventario from "public" as "root";

{ TABLE "root".plan row size = 86 number of columns = 5 index size = 9 }

create table "root".plan 
  (
    id_plan serial not null ,
    fecha_redaccion date,
    resolucion varchar(255),
    completado char(1),
    nom_plan varchar(50),
    primary key (id_plan) 
  );

revoke all on "root".plan from "public" as "root";

{ TABLE "root".inspeccion row size = 46 number of columns = 3 index size = 30 }

create table "root".inspeccion 
  (
    unidad_inspectora varchar(30),
    fecha_visita date,
    tipo_unidad varchar(20),
    primary key (unidad_inspectora,fecha_visita) 
  );

revoke all on "root".inspeccion from "public" as "root";

{ TABLE "root".observacion row size = 79 number of columns = 5 index size = 9 }

create table "root".observacion 
  (
    id_obs serial not null ,
    tipo_obs varchar(15),
    narracion varchar(50),
    fecha_dictado date,
    fecha_resp date,
    primary key (id_obs) 
  );

revoke all on "root".observacion from "public" as "root";

{ TABLE "root".contrata row size = 31 number of columns = 4 index size = 33 }

create table "root".contrata 
  (
    rut char(12),
    ci_pr char(10) not null,
    fecha_contrato date,
    fecha_de_baja date,
    primary key (rut) 
  );

revoke all on "root".contrata from "public" as "root";

{ TABLE "root".tiene row size = 23 number of columns = 2 index size = 61 }

create table "root".tiene 
  (
    rut char(12),
    ci_tr char(10),
    turno char(1),
    sector varchar(12),
    primary key (rut,ci_tr) 
  );

revoke all on "root".tiene from "public" as "root";

{ TABLE "root".hace row size = 14 number of columns = 2 index size = 24 }

create table "root".hace 
  (
    id_relev integer,
    ci_pr char(10),
    primary key (id_relev) 
  );

revoke all on "root".hace from "public" as "root";

{ TABLE "root".a row size = 42 number of columns = 4 index size = 91 }

create table "root".a 
  (
    id_obs integer,
    unidad_inspectora varchar(30),
    fecha_visita date,
    rut char(12),
    primary key (id_obs,unidad_inspectora,fecha_visita) 
  );

revoke all on "root".a from "public" as "root";

{ TABLE "root".genera row size = 8 number of columns = 2 index size = 31 }

create table "root".genera 
  (
    id_relev integer,
    id_plan integer,
    primary key (id_relev,id_plan) 
  );

revoke all on "root".genera from "public" as "root";

{ TABLE "root".responde row size = 33 number of columns = 4 index size = 82 }

create table "root".responde 
  (
    id_obs integer,
    unidad_inspectora varchar(30),
    fecha_visita date,
    id_plan integer,
    primary key (id_obs,unidad_inspectora,fecha_visita) 
  );

revoke all on "root".responde from "public" as "root";

{ TABLE "root".contiene row size = 24 number of columns = 6 index size = 22 }

create table "root".contiene 
  (
    id_icono integer,
    id_mapa integer,
    id_relev integer,
    pos_x integer,
    pos_y integer,
    primary key (id_icono) 
  );

revoke all on "root".contiene from "public" as "root";

{ TABLE "root".realiza row size = 29 number of columns = 3 index size = 73 }

create table "root".realiza 
  (
    id_obs integer,
    unidad_inspectora varchar(30),
    fecha_visita date,
    primary key (id_obs,unidad_inspectora,fecha_visita) 
  );

revoke all on "root".realiza from "public" as "root";

{ TABLE "root".sobre row size = 17 number of columns = 2 index size = 27 }

create table "root".sobre 
  (
    id_relev integer,
    rut char(12),
    visitas integer,
    primary key (id_relev) 
  );

revoke all on "root".sobre from "public" as "root";

grant select on "root".empresa to "public" as "root";
grant update on "root".empresa to "public" as "root";
grant insert on "root".empresa to "public" as "root";
grant delete on "root".empresa to "public" as "root";
grant index on "root".empresa to "public" as "root";
grant select on "root".prevencionista to "public" as "root";
grant update on "root".prevencionista to "public" as "root";
grant insert on "root".prevencionista to "public" as "root";
grant delete on "root".prevencionista to "public" as "root";
grant index on "root".prevencionista to "public" as "root";
grant select on "root".trabajador to "public" as "root";
grant update on "root".trabajador to "public" as "root";
grant insert on "root".trabajador to "public" as "root";
grant delete on "root".trabajador to "public" as "root";
grant index on "root".trabajador to "public" as "root";
grant select on "root".relevamiento to "public" as "root";
grant update on "root".relevamiento to "public" as "root";
grant insert on "root".relevamiento to "public" as "root";
grant delete on "root".relevamiento to "public" as "root";
grant index on "root".relevamiento to "public" as "root";
grant select on "root".reporte to "public" as "root";
grant update on "root".reporte to "public" as "root";
grant insert on "root".reporte to "public" as "root";
grant delete on "root".reporte to "public" as "root";
grant index on "root".reporte to "public" as "root";
grant select on "root".cuestionario to "public" as "root";
grant update on "root".cuestionario to "public" as "root";
grant insert on "root".cuestionario to "public" as "root";
grant delete on "root".cuestionario to "public" as "root";
grant index on "root".cuestionario to "public" as "root";
grant select on "root".pregunta to "public" as "root";
grant update on "root".pregunta to "public" as "root";
grant insert on "root".pregunta to "public" as "root";
grant delete on "root".pregunta to "public" as "root";
grant index on "root".pregunta to "public" as "root";
grant select on "root".mapa to "public" as "root";
grant update on "root".mapa to "public" as "root";
grant insert on "root".mapa to "public" as "root";
grant delete on "root".mapa to "public" as "root";
grant index on "root".mapa to "public" as "root";
grant select on "root".icono to "public" as "root";
grant update on "root".icono to "public" as "root";
grant insert on "root".icono to "public" as "root";
grant delete on "root".icono to "public" as "root";
grant index on "root".icono to "public" as "root";
grant select on "root".calculo to "public" as "root";
grant update on "root".calculo to "public" as "root";
grant insert on "root".calculo to "public" as "root";
grant delete on "root".calculo to "public" as "root";
grant index on "root".calculo to "public" as "root";
grant select on "root".inventario to "public" as "root";
grant update on "root".inventario to "public" as "root";
grant insert on "root".inventario to "public" as "root";
grant delete on "root".inventario to "public" as "root";
grant index on "root".inventario to "public" as "root";
grant select on "root".plan to "public" as "root";
grant update on "root".plan to "public" as "root";
grant insert on "root".plan to "public" as "root";
grant delete on "root".plan to "public" as "root";
grant index on "root".plan to "public" as "root";
grant select on "root".inspeccion to "public" as "root";
grant update on "root".inspeccion to "public" as "root";
grant insert on "root".inspeccion to "public" as "root";
grant delete on "root".inspeccion to "public" as "root";
grant index on "root".inspeccion to "public" as "root";
grant select on "root".observacion to "public" as "root";
grant update on "root".observacion to "public" as "root";
grant insert on "root".observacion to "public" as "root";
grant delete on "root".observacion to "public" as "root";
grant index on "root".observacion to "public" as "root";
grant select on "root".contrata to "public" as "root";
grant update on "root".contrata to "public" as "root";
grant insert on "root".contrata to "public" as "root";
grant delete on "root".contrata to "public" as "root";
grant index on "root".contrata to "public" as "root";
grant select on "root".tiene to "public" as "root";
grant update on "root".tiene to "public" as "root";
grant insert on "root".tiene to "public" as "root";
grant delete on "root".tiene to "public" as "root";
grant index on "root".tiene to "public" as "root";
grant select on "root".hace to "public" as "root";
grant update on "root".hace to "public" as "root";
grant insert on "root".hace to "public" as "root";
grant delete on "root".hace to "public" as "root";
grant index on "root".hace to "public" as "root";
grant select on "root".a to "public" as "root";
grant update on "root".a to "public" as "root";
grant insert on "root".a to "public" as "root";
grant delete on "root".a to "public" as "root";
grant index on "root".a to "public" as "root";
grant select on "root".genera to "public" as "root";
grant update on "root".genera to "public" as "root";
grant insert on "root".genera to "public" as "root";
grant delete on "root".genera to "public" as "root";
grant index on "root".genera to "public" as "root";
grant select on "root".responde to "public" as "root";
grant update on "root".responde to "public" as "root";
grant insert on "root".responde to "public" as "root";
grant delete on "root".responde to "public" as "root";
grant index on "root".responde to "public" as "root";
grant select on "root".contiene to "public" as "root";
grant update on "root".contiene to "public" as "root";
grant insert on "root".contiene to "public" as "root";
grant delete on "root".contiene to "public" as "root";
grant index on "root".contiene to "public" as "root";
grant select on "root".realiza to "public" as "root";
grant update on "root".realiza to "public" as "root";
grant insert on "root".realiza to "public" as "root";
grant delete on "root".realiza to "public" as "root";
grant index on "root".realiza to "public" as "root";
grant select on "root".sobre to "public" as "root";
grant update on "root".sobre to "public" as "root";
grant insert on "root".sobre to "public" as "root";
grant delete on "root".sobre to "public" as "root";
grant index on "root".sobre to "public" as "root";

revoke usage on language SPL from public ;

grant usage on language SPL to public ;




alter table "root".cuestionario add constraint (foreign key (id_relev) 
    references "root".relevamiento );
alter table "root".pregunta add constraint (foreign key (id_cuestionario,
    id_relev) references "root".cuestionario );
alter table "root".pregunta add constraint (foreign key (id_rep) 
    references "root".reporte );
alter table "root".mapa add constraint (foreign key (id_relev) 
    references "root".relevamiento );
alter table "root".calculo add constraint (foreign key (id_relev) 
    references "root".relevamiento );
alter table "root".inventario add constraint (foreign key (id_relev) 
    references "root".relevamiento );
alter table "root".contrata add constraint (foreign key (rut) 
    references "root".empresa );
alter table "root".contrata add constraint (foreign key (ci_pr) 
    references "root".prevencionista );
alter table "root".tiene add constraint (foreign key (rut) references 
    "root".empresa );
alter table "root".tiene add constraint (foreign key (ci_tr) 
    references "root".trabajador );
alter table "root".hace add constraint (foreign key (id_relev) 
    references "root".relevamiento );
alter table "root".hace add constraint (foreign key (ci_pr) references 
    "root".prevencionista );
alter table "root".a add constraint (foreign key (id_obs) references 
    "root".observacion );
alter table "root".a add constraint (foreign key (unidad_inspectora,
    fecha_visita) references "root".inspeccion );
alter table "root".a add constraint (foreign key (rut) references 
    "root".empresa );
alter table "root".genera add constraint (foreign key (id_relev) 
    references "root".relevamiento );
alter table "root".genera add constraint (foreign key (id_plan) 
    references "root".plan );
alter table "root".responde add constraint (foreign key (id_obs) 
    references "root".observacion );
alter table "root".responde add constraint (foreign key (unidad_inspectora,
    fecha_visita) references "root".inspeccion );
alter table "root".responde add constraint (foreign key (id_plan) 
    references "root".plan );
alter table "root".contiene add constraint (foreign key (id_icono) 
    references "root".icono );
alter table "root".contiene add constraint (foreign key (id_mapa,
    id_relev) references "root".mapa );
alter table "root".realiza add constraint (foreign key (id_obs) 
    references "root".observacion );
alter table "root".realiza add constraint (foreign key (unidad_inspectora,
    fecha_visita) references "root".inspeccion );
alter table "root".sobre add constraint (foreign key (id_relev) 
    references "root".relevamiento );
alter table "root".sobre add constraint (foreign key (rut) references 
    "root".empresa );

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
grant resource to ebettinelli;
grant resource to nschol;
grant resource to gmachado;
grant resource to hipercode_administrador;
grant resource to hipercode_tecnico;
grant resource to hipercode_asistente;
grant resource to hipercode_guest;

insert into roles values(1,'Administrador');
insert into roles values(2,'Tecnico');
insert into roles values(3,'Asistente');
insert into roles values(4,'Guest');
insert into usuario_rol values('root',1);
insert into usuario_rol values('ebettinelli',1);
insert into usuario_rol values('hipercode_administrador',1);
insert into usuario_rol values('ndiaz',2);
insert into usuario_rol values('hipercode_tecnico',2);
insert into usuario_rol values('gmachado',3);
insert into usuario_rol values('hipercode_asistente',3);
insert into usuario_rol values('nschol',4);
insert into usuario_rol values('hipercode_guest',4);
grant all on trabajador to ndiaz;
