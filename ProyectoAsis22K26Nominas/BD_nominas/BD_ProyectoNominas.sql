drop database if exists BD_ProyectoNominasFin;

create database BD_ProyectoNominas;
use BD_ProyectoNominas;



-- 1. Desactivar temporalmente llaves foráneas
set foreign_key_checks = 0;

-- 2. Eliminación de las 22 tablas
drop table if exists tbl_Aplicaciones;
drop table if exists tbl_Asistencias;
drop table if exists tbl_Ausencias;
drop table if exists tbl_Bitacora;
drop table if exists tbl_Correos;
drop table if exists tbl_Deducciones;
drop table if exists tbl_Departamentos;
drop table if exists tbl_Detalle_Planilla;
drop table if exists tbl_Empleados;
drop table if exists tbl_Liquidaciones;
drop table if exists tbl_Movimientos_Planilla;
drop table if exists tbl_Pagos;
drop table if exists tbl_Permisos;
drop table if exists tbl_Planilla;
drop table if exists tbl_Puestos;
drop table if exists tbl_Roles;
drop table if exists tbl_Seguros;
drop table if exists tbl_Telefonos;
drop table if exists tbl_Tipo_Deduccion;
drop table if exists tbl_Tipo_Movimiento;
drop table if exists tbl_Usuarios;
drop table if exists tbl_Vacaciones;

-- 3. Reactivar llaves foráneas
set foreign_key_checks = 1;

-- TABLA DEPARTAMENTOS
create table tbl_Departamentos (
    cmp_id_departamento int auto_increment,
    cmp_nombre varchar(100) not null,	
    cmp_descripcion varchar(200),
    
    constraint pk_tbl_departamentos primary key (cmp_id_departamento)
);


-- TABLA PUESTOS
create table tbl_Puestos (
    cmp_id_puesto int auto_increment,
    cmp_nombre varchar(100) not null,
    cmp_descripcion varchar(200),
	cmp_salario_base decimal(10,2) not null,

    constraint pk_tbl_puestos primary key (cmp_id_puesto)
);


-- TABLA EMPLEADOS
create table tbl_Empleados (
    cmp_id_empleado int auto_increment,
    cmp_dpi varchar(13) not null,
    cmp_nit varchar(15),
    cmp_nombre varchar(50) not null,
    cmp_apellido varchar(50) not null,
    cmp_fecha_nacimiento date,
    cmp_direccion varchar(250),
    cmp_fecha_contratacion date not null,
    cmp_estado varchar(20) default 'activo',
    cmp_id_departamento int not null,
    cmp_id_puesto int not null,


    constraint pk_tbl_empleados primary key (cmp_id_empleado),
    constraint fk_tbl_empleados_tbl_departamentos foreign key (cmp_id_departamento) references tbl_Departamentos (cmp_id_departamento),
    constraint fk_tbl_empleados_tbl_puestos foreign key (cmp_id_puesto) references tbl_Puestos (cmp_id_puesto)

);


-- TABLA TELÉFONOS 
create table tbl_Telefonos (
    cmp_id_telefono int auto_increment,
    cmp_telefono varchar(20) not null,
    cmp_id_empleado int not null,

    constraint pk_tbl_telefonos primary key (cmp_id_telefono),
    constraint fk_tbl_telefonos_tbl_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado)
);


-- TABLA CORREOS 
create table tbl_Correos (
    cmp_id_correo int auto_increment,
    cmp_correo varchar(100) not null,
    cmp_id_empleado int not null,

    constraint pk_tbl_correos primary key (cmp_id_correo),
    constraint fk_tbl_correos_tbl_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado)
);


-- TABLA ROLES
create table tbl_Roles (
    cmp_id_rol int auto_increment,
    cmp_nombre varchar(50) not null,
    cmp_descripcion varchar(200),
    cmp_nivel int not null,
    cmp_estado boolean not null default true,

    constraint pk_tbl_roles primary key (cmp_id_rol),
    constraint uq_tbl_roles_nombre unique (cmp_nombre),
    constraint uq_tbl_roles_nivel unique (cmp_nivel)
);


-- TABLA APLICACIONES Y PERMISOS POR ROL
create table tbl_Aplicaciones (
    cmp_id_aplicacion int auto_increment,
    cmp_nombre varchar(100) not null,
    cmp_descripcion varchar(200),
    cmp_nombre_formulario varchar(100) not null,
    cmp_ver boolean not null default false,
    cmp_crear boolean not null default false,
    cmp_modificar boolean not null default false,
    cmp_eliminar boolean not null default false,
    cmp_id_rol int not null,

    constraint pk_tbl_aplicaciones primary key (cmp_id_aplicacion),
    constraint uq_tbl_aplicaciones_rol_formulario unique (cmp_id_rol, cmp_nombre_formulario),
    constraint fk_tbl_aplicaciones_tbl_roles foreign key (cmp_id_rol)
        references tbl_Roles (cmp_id_rol)
);


-- TABLA USUARIOS
create table tbl_Usuarios (
    cmp_id_usuario int auto_increment,
    cmp_nombre varchar(50) not null,
    cmp_contras varchar(255) not null,
    cmp_id_empleado int not null,
    cmp_id_rol int not null,
    cmp_estado boolean not null default true,
    cmp_fecha_creacion datetime not null default current_timestamp,

    constraint pk_tbl_usuarios primary key (cmp_id_usuario),
    constraint uq_tbl_usuarios_nombre unique (cmp_nombre),
    constraint uq_tbl_usuarios_empleado unique (cmp_id_empleado),
    constraint fk_tbl_usuarios_tbl_empleados foreign key (cmp_id_empleado)
        references tbl_Empleados (cmp_id_empleado),
    constraint fk_tbl_usuarios_tbl_roles foreign key (cmp_id_rol)
        references tbl_Roles (cmp_id_rol)
);


-- TABLA PLANILLA
create table tbl_Planilla (
    cmp_id_planilla int auto_increment,
    cmp_periodo_inicio date not null,
    cmp_periodo_fin date not null,
    cmp_fecha_generacion datetime default current_timestamp,
    cmp_estado varchar(20) default 'borrador',
    cmp_total_ingresos decimal(12,2) default 0,
    cmp_total_descuentos decimal(12,2) default 0,
    cmp_total_pagar decimal(12,2) default 0,
    cmp_observaciones varchar(250),
    cmp_id_usuario int not null,

    constraint pk_tbl_planilla primary key (cmp_id_planilla),
    constraint fk_tbl_planilla_tbl_usuarios foreign key (cmp_id_usuario) references tbl_Usuarios (cmp_id_usuario)
);


-- TABLA DETALLE PLANILLA
create table tbl_Detalle_Planilla (
    cmp_id_detalle_planilla int auto_increment,
    cmp_salario_base decimal(10,2) not null,
    cmp_total_sumativo decimal(10,2) default 0,
    cmp_total_restativo decimal(10,2) default 0,
    cmp_salario_bruto decimal(10,2) default 0,
    cmp_salario_neto decimal(10,2) default 0,
    cmp_observaciones varchar(250),
    cmp_id_planilla int not null,
    cmp_id_empleado int not null,

    constraint pk_tbl_detalle_planilla primary key (cmp_id_detalle_planilla),
    constraint fk_tbl_detalle_planilla_tbl_planilla foreign key (cmp_id_planilla) references tbl_Planilla (cmp_id_planilla),
    constraint fk_tbl_detalle_planilla_tbl_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado)
);


-- TABLA TIPO DEDUCCIÓN
create table tbl_Tipo_Deduccion (
    cmp_id_tipo_deduccion int auto_increment,
    cmp_nombre varchar(100) not null,
    cmp_descripcion varchar(200),
    cmp_tipo_operacion varchar(10) not null,
    cmp_aplica_limite boolean default true,

    constraint pk_tbl_tipo_deduccion primary key (cmp_id_tipo_deduccion)
);


-- TABLA DEDUCCIONES
create table tbl_Deducciones (
    cmp_id_detalle_planilla int not null,
    cmp_id_tipo_deduccion int not null,
    cmp_cantidad decimal(8,2),
    cmp_monto decimal(10,2) not null,
    cmp_descripcion varchar(200),

    constraint pk_tbl_deducciones primary key ( cmp_id_detalle_planilla, cmp_id_tipo_deduccion ),
    constraint fk_tbl_deducciones_tbl_detalle_planilla foreign key (cmp_id_detalle_planilla) references tbl_Detalle_Planilla (cmp_id_detalle_planilla),
    constraint fk_tbl_deducciones_tbl_tipo_deduccion foreign key (cmp_id_tipo_deduccion) references tbl_Tipo_Deduccion (cmp_id_tipo_deduccion)
);


-- tabla de solicitudes de vacaciones
create table tbl_Vacaciones (
    cmp_id_vacacion int auto_increment,
    cmp_id_empleado int not null,
    cmp_fecha_solicitud date not null,
    cmp_fecha_inicio date not null,
    cmp_fecha_fin date not null,
    cmp_dias_solicitados int not null,
    cmp_motivo varchar(255) not null,
    cmp_estado enum('Pendiente', 'Aprobada', 'Rechazada') not null default 'Pendiente',
    cmp_observaciones varchar(255),

    constraint pk_tbl_vacaciones primary key (cmp_id_vacacion),
    constraint fk_tbl_vacaciones_tbl_empleados foreign key (cmp_id_empleado)
        references tbl_Empleados (cmp_id_empleado)
);


-- TABLA PERMISOS
create table tbl_Permisos (
    cmp_id_permiso int auto_increment,
    cmp_fecha_solicitud date not null,
    cmp_fecha_inicio datetime not null,
    cmp_fecha_fin datetime not null,
    cmp_tipo_permiso varchar(50) not null,
    cmp_genera_descuento boolean default false,
    cmp_estado varchar(20) default 'pendiente',
    cmp_motivo varchar(250),
    cmp_observaciones varchar(250),
    cmp_id_empleado int not null,
    cmp_id_usuario_autoriza int,

    constraint pk_tbl_permisos primary key (cmp_id_permiso),
    constraint fk_tbl_permisos_tbl_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado),
    constraint fk_tbl_permisos_tbl_usuarios foreign key (cmp_id_usuario_autoriza) references tbl_Usuarios (cmp_id_usuario)
);


-- TABLA ASISTENCIAS
create table tbl_Asistencias (
    cmp_id_asistencia int auto_increment,
    cmp_fecha date not null,
    cmp_hora_entrada time,
    cmp_hora_salida time,
    cmp_minutos_tardanza int default 0,
    cmp_horas_trabajadas decimal(5,2) default 0,
    cmp_horas_extra decimal(5,2) default 0,
    cmp_observaciones varchar(250),
    cmp_id_empleado int not null,

    constraint pk_tbl_asistencias primary key (cmp_id_asistencia),
    constraint fk_tbl_asistencias_tbl_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado)
);


-- TABLA AUSENCIAS
create table tbl_Ausencias (
    cmp_id_ausencia int auto_increment,
    cmp_fecha_inicio date not null,
    cmp_fecha_fin date not null,
    cmp_cantidad_dias decimal(5,2) default 1,
    cmp_tipo_ausencia varchar(50) not null,
    cmp_justificada boolean default false,
    cmp_genera_descuento boolean default false,
    cmp_motivo varchar(250),
    cmp_observaciones varchar(250),
    cmp_id_empleado int not null,
    cmp_id_vacacion int,
    cmp_id_permiso int,

    constraint pk_tbl_ausencias primary key (cmp_id_ausencia),
    constraint fk_tbl_ausencias_tbl_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado),
    constraint fk_tbl_ausencias_tbl_vacaciones foreign key (cmp_id_vacacion) references tbl_Vacaciones (cmp_id_vacacion),
    constraint fk_tbl_ausencias_tbl_permisos foreign key (cmp_id_permiso) references tbl_Permisos (cmp_id_permiso)
);


-- TABLA SEGUROS
create table tbl_Seguros (
    cmp_id_seguro int auto_increment,
    cmp_nombre varchar(100) not null,
    cmp_aseguradora varchar(100),
    cmp_descripcion varchar(250),
    cmp_numero_poliza varchar(50),
    cmp_fecha_inicio date not null,
    cmp_fecha_fin date,
    cmp_monto_cobertura decimal(12,2) default 0,
    cmp_id_empleado int not null,

    constraint pk_tbl_seguros primary key (cmp_id_seguro),
    constraint fk_tbl_seguros_tbl_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado)
);


-- TABLA LIQUIDACIONES
create table tbl_Liquidaciones (
    cmp_id_liquidacion int auto_increment,
    cmp_fecha_calculo date not null,
    cmp_fecha_retiro date not null,
    cmp_motivo_retiro varchar(100) not null,
    cmp_salario_pendiente decimal(12,2) default 0,
    cmp_indemnizacion decimal(12,2) default 0,
    cmp_vacaciones_pendientes decimal(12,2) default 0,
    cmp_aguinaldo_pendiente decimal(12,2) default 0,
    cmp_bono_14_pendiente decimal(12,2) default 0,
    cmp_otros_ingresos decimal(12,2) default 0,
    cmp_total_descuentos decimal(12,2) default 0,
    cmp_total_liquidacion decimal(12,2) default 0,
    cmp_numero_recibo varchar(30),
    cmp_fecha_pago date,
    cmp_estado varchar(20) default 'pendiente',
    cmp_observaciones varchar(250),
    cmp_id_empleado int not null,
    cmp_id_usuario int not null,

    constraint pk_tbl_liquidaciones primary key (cmp_id_liquidacion),
    constraint fk_tbl_liquidaciones_tbl_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado),
    constraint fk_tbl_liquidaciones_tbl_usuarios foreign key (cmp_id_usuario) references tbl_Usuarios (cmp_id_usuario)
);


-- TABLA PAGOS
create table tbl_Pagos (
    cmp_id_pago int auto_increment,
    cmp_fecha_pago date not null,
    cmp_monto_pagado decimal(10,2) not null,
    cmp_forma_pago varchar(30) not null,
    cmp_numero_recibo varchar(30),
    cmp_observaciones varchar(250),
    cmp_id_detalle_planilla int not null,

    constraint pk_tbl_pagos primary key (cmp_id_pago),
    constraint fk_tbl_pagos_tbl_detalle_planilla foreign key (cmp_id_detalle_planilla) references tbl_Detalle_Planilla (cmp_id_detalle_planilla)
);

-- TABLA TIPO DE MOVIMIENTO
create table tbl_Tipo_Movimiento (
    cmp_id_tipo_movimiento int auto_increment,
    cmp_nombre varchar(100) not null,
    cmp_operacion varchar(10) not null,
    cmp_descripcion varchar(200),
    cmp_necesita_cantidad boolean default false,
    cmp_estado boolean default true,

    constraint pk_tbl_tipo_movimiento primary key (cmp_id_tipo_movimiento)
);

-- TABLA MOVIMIENTOS DE PLANILLA
create table tbl_Movimientos_Planilla (
    cmp_id_movimiento int auto_increment,
    cmp_fecha date not null,
    cmp_cantidad decimal(8,2),
    cmp_monto decimal(10,2) not null,
    cmp_descripcion varchar(250),
    cmp_estado varchar(20) default 'pendiente',
    cmp_fecha_registro datetime default current_timestamp,

    cmp_id_empleado int not null,
    cmp_id_tipo_movimiento int not null,
    cmp_id_planilla int,
    cmp_id_usuario int not null,

    constraint pk_tbl_movimientos_planilla primary key (cmp_id_movimiento),
    constraint fk_movimientos_empleados foreign key (cmp_id_empleado) references tbl_Empleados (cmp_id_empleado),
    constraint fk_movimientos_tipo foreign key (cmp_id_tipo_movimiento) references tbl_Tipo_Movimiento (cmp_id_tipo_movimiento),
    constraint fk_movimientos_planilla foreign key (cmp_id_planilla) references tbl_Planilla (cmp_id_planilla),
    constraint fk_movimientos_usuarios foreign key (cmp_id_usuario) references tbl_Usuarios (cmp_id_usuario)
);

-- TABLA BITÁCORA
create table tbl_Bitacora (
    cmp_id_bitacora bigint auto_increment,
    cmp_fecha datetime not null default current_timestamp,
    cmp_accion varchar(100) not null,
    cmp_descripcion varchar(500),
    cmp_nombre_formulario varchar(100),
    cmp_tabla_afectada varchar(100),
    cmp_id_registro varchar(50),
    cmp_id_usuario int not null,
    cmp_direccion_ip varchar(45) not null,
    cmp_nombre_equipo varchar(100),

    constraint pk_tbl_bitacora primary key (cmp_id_bitacora),
    constraint fk_tbl_bitacora_tbl_usuarios foreign key (cmp_id_usuario)
        references tbl_Usuarios (cmp_id_usuario)
);

create index ix_tbl_bitacora_fecha
on tbl_Bitacora (cmp_fecha);

create index ix_tbl_bitacora_usuario
on tbl_Bitacora (cmp_id_usuario);

-- Vista para mostrar el nombre del usuario en lugar de su ID
create view vw_Bitacora as
select
    b.cmp_id_bitacora,
    b.cmp_fecha,
    u.cmp_nombre as cmp_usuario,
    concat(e.cmp_nombre, ' ', e.cmp_apellido) as cmp_nombre_completo,
    r.cmp_nombre as cmp_rol,
    b.cmp_direccion_ip,
    b.cmp_nombre_equipo,
    b.cmp_accion,
    b.cmp_descripcion,
    b.cmp_nombre_formulario,
    b.cmp_tabla_afectada,
    b.cmp_id_registro
from tbl_Bitacora b
inner join tbl_Usuarios u
    on b.cmp_id_usuario = u.cmp_id_usuario
inner join tbl_Roles r
    on u.cmp_id_rol = r.cmp_id_rol
inner join tbl_Empleados e
    on u.cmp_id_empleado = e.cmp_id_empleado;



select * from tbl_Aplicaciones;
select * from tbl_Roles;
select * from tbl_Usuarios;
select * from tbl_Bitacora;

select
    a.cmp_id_rol,
    r.cmp_nombre as Rol,
    a.cmp_nombre_formulario as Formulario,
    a.cmp_ver as Ver,
    a.cmp_crear as Crear,
    a.cmp_modificar as Modificar,
    a.cmp_eliminar as Eliminar
from tbl_Aplicaciones a
inner join tbl_Roles r
    on a.cmp_id_rol = r.cmp_id_rol
order by a.cmp_id_rol, a.cmp_nombre_formulario;



-- CONSULTAS PARA VER TABLAS
select * from tbl_Departamentos;
select * from tbl_Puestos;
select * from tbl_Empleados;
select * from tbl_Telefonos;
select * from tbl_Correos;
select * from tbl_Roles;
select * from tbl_Aplicaciones;
select * from tbl_Usuarios;
select * from tbl_Planilla;
select * from tbl_Detalle_Planilla;
select * from tbl_Tipo_Deduccion;
select * from tbl_Deducciones;
select * from tbl_Vacaciones;
select * from tbl_Permisos;
select * from tbl_Asistencias;
select * from tbl_Ausencias;
select * from tbl_Seguros;
select * from tbl_Liquidaciones;
select * from tbl_Pagos;
select * from tbl_Bitacora;
select * from vw_Bitacora order by cmp_fecha desc;
select * from tbl_Movimientos_Planilla;
select * from tbl_Planilla;


-- =========================================================
-- SCRIPT DE INSERTS DE PRUEBA - SISTEMA DE PLANILLA
-- Orden pensado para respetar las llaves foráneas (FK)
-- 10 registros por tabla
-- =========================================================

-- =========================================================
-- NIVEL 1: TABLAS SIN DEPENDENCIAS (catálogos base)
-- =========================================================

-- 1. tbl_Departamentos
insert into tbl_Departamentos (cmp_nombre, cmp_descripcion) values
('Recursos Humanos', 'Gestión del personal de la empresa'),
('Contabilidad', 'Manejo de finanzas y contabilidad'),
('Ventas', 'Departamento comercial y de ventas'),
('Marketing', 'Publicidad y mercadeo'),
('Tecnología', 'Desarrollo y soporte de sistemas'),
('Producción', 'Área de manufactura y producción'),
('Logística', 'Distribución y transporte'),
('Legal', 'Asuntos jurídicos de la empresa'),
('Atención al Cliente', 'Soporte y servicio al cliente'),
('Gerencia General', 'Dirección general de la empresa');

-- 2. tbl_Puestos
insert into tbl_Puestos (cmp_nombre, cmp_descripcion, cmp_salario_base) values
('Gerente', 'Encargado de área', 12000.00),
('Analista', 'Analista de procesos', 6500.00),
('Asistente', 'Apoyo administrativo', 4000.00),
('Contador', 'Encargado de contabilidad', 7000.00),
('Vendedor', 'Ejecutivo de ventas', 4500.00),
('Desarrollador', 'Desarrollo de software', 8000.00),
('Supervisor', 'Supervisión de personal', 6000.00),
('Operario', 'Operario de producción', 3500.00),
('Recepcionista', 'Atención en recepción', 3200.00),
('Auxiliar', 'Auxiliar general', 3000.00);

-- 3. tbl_Roles
insert into tbl_Roles
(cmp_nombre, cmp_descripcion, cmp_nivel, cmp_estado) values
('Gerente', 'Acceso completo a todos los módulos y operaciones del sistema', 4, true),
('RecursosHumanos', 'Gestión integral de empleados, asistencia, vacaciones, planilla y liquidaciones', 3, true),
('Supervisor', 'Supervisión de empleados, vacaciones y control de asistencia', 2, true),
('Secretaria', 'Consultas y registros administrativos básicos autorizados', 1, true);

-- 4. tbl_Tipo_Deduccion
insert into tbl_Tipo_Deduccion (cmp_nombre, cmp_descripcion, cmp_tipo_operacion, cmp_aplica_limite) values
('IGSS', 'Descuento de seguro social', 'resta', true),
('ISR', 'Impuesto sobre la renta', 'resta', true),
('Préstamo', 'Cuota de préstamo interno', 'resta', false),
('Anticipo', 'Descuento por anticipo de sueldo', 'resta', false),
('Seguro', 'Cuota de seguro privado', 'resta', true),
('Embargo', 'Descuento por embargo judicial', 'resta', false),
('Multa', 'Multa administrativa', 'resta', false),
('Ausencia Injustificada', 'Descuento por ausencia', 'resta', false),
('Cuota Sindical', 'Aporte al sindicato', 'resta', true),
('Otros Descuentos', 'Descuentos varios', 'resta', false);

-- 5. tbl_Tipo_Movimiento
insert into tbl_Tipo_Movimiento (cmp_nombre, cmp_operacion, cmp_descripcion, cmp_necesita_cantidad, cmp_estado) values
('Bono Productividad', 'suma', 'Bono por productividad', false, true),
('Horas Extra', 'suma', 'Pago de horas extra', true, true),
('Comisión', 'suma', 'Comisión por ventas', false, true),
('Aguinaldo', 'suma', 'Pago de aguinaldo', false, true),
('Bono 14', 'suma', 'Pago de bono 14', false, true),
('Descuento IGSS', 'resta', 'Descuento de IGSS', false, true),
('Descuento ISR', 'resta', 'Descuento de ISR', false, true),
('Préstamo', 'resta', 'Descuento de préstamo', false, true),
('Anticipo', 'resta', 'Descuento de anticipo', false, true),
('Otros', 'suma', 'Otros movimientos', false, true);

-- =========================================================
-- NIVEL 2: EMPLEADOS (depende de Departamentos y Puestos)
-- =========================================================

-- 6. tbl_Empleados
insert into tbl_Empleados (cmp_dpi, cmp_nit, cmp_nombre, cmp_apellido, cmp_fecha_nacimiento, cmp_direccion, cmp_fecha_contratacion, cmp_estado, cmp_id_departamento, cmp_id_puesto) values
('1000100010001', '1234567-8', 'Carlos', 'Pérez', '1990-05-10', 'Zona 1, Ciudad de Guatemala', '2020-01-15', 'activo', 1, 1),
('1000200020002', '2234567-8', 'María', 'López', '1992-08-22', 'Zona 5, Ciudad de Guatemala', '2019-03-01', 'activo', 2, 4),
('1000300030003', '3234567-8', 'José', 'Ramírez', '1988-12-01', 'Zona 10, Ciudad de Guatemala', '2018-07-10', 'activo', 3, 5),
('1000400040004', '4234567-8', 'Ana', 'Gómez', '1995-02-14', 'Zona 7, Mixco', '2021-05-20', 'activo', 4, 2),
('1000500050005', '5234567-8', 'Luis', 'Hernández', '1993-11-30', 'Zona 3, Ciudad de Guatemala', '2017-09-05', 'activo', 5, 6),
('1000600060006', '6234567-8', 'Sofía', 'Martínez', '1991-04-18', 'Zona 12, Ciudad de Guatemala', '2022-02-01', 'activo', 6, 8),
('1000700070007', '7234567-8', 'Diego', 'Castillo', '1989-09-09', 'Zona 6, Villa Nueva', '2016-06-15', 'activo', 7, 7),
('1000800080008', '8234567-8', 'Laura', 'Morales', '1994-07-25', 'Zona 4, Ciudad de Guatemala', '2020-10-10', 'activo', 8, 3),
('1000900090009', '9234567-8', 'Pedro', 'Sánchez', '1996-01-05', 'Zona 9, Ciudad de Guatemala', '2023-01-10', 'activo', 9, 9),
('1001000010010', '1034567-8', 'Gabriela', 'Vásquez', '1987-03-17', 'Zona 2, Ciudad de Guatemala', '2015-04-01', 'activo', 10, 1);

-- =========================================================
-- NIVEL 3: TABLAS QUE DEPENDEN SOLO DE EMPLEADOS
-- =========================================================

-- 7. tbl_Telefonos
insert into tbl_Telefonos (cmp_telefono, cmp_id_empleado) values
('50212345001', 1),
('50212345002', 2),
('50212345003', 3),
('50212345004', 4),
('50212345005', 5),
('50212345006', 6),
('50212345007', 7),
('50212345008', 8),
('50212345009', 9),
('50212345010', 10);

-- 8. tbl_Correos
insert into tbl_Correos (cmp_correo, cmp_id_empleado) values
('carlos.perez@empresa.com', 1),
('maria.lopez@empresa.com', 2),
('jose.ramirez@empresa.com', 3),
('ana.gomez@empresa.com', 4),
('luis.hernandez@empresa.com', 5),
('sofia.martinez@empresa.com', 6),
('diego.castillo@empresa.com', 7),
('laura.morales@empresa.com', 8),
('pedro.sanchez@empresa.com', 9),
('gabriela.vasquez@empresa.com', 10);

-- =========================================================
-- NIVEL 4: TABLAS QUE DEPENDEN DE ROLES
-- =========================================================

-- 9. tbl_Aplicaciones
-- Una fila por formulario y por rol. La restricción UNIQUE evita duplicados.
insert into tbl_Aplicaciones
(cmp_nombre, cmp_descripcion, cmp_nombre_formulario,
 cmp_ver, cmp_crear, cmp_modificar, cmp_eliminar, cmp_id_rol) values
('Nuevo empleado', 'Registro de nuevos empleados', 'FormNuevoregistro', true, true, true, true, 1),
('Mantenimiento de empleados', 'Modificación, baja y reactivación de empleados', 'FormMantenimientoEmpleado', true, true, true, true, 1),
('Directorio de empleados', 'Consulta del directorio de empleados', 'FormDirectorioEmpleados', true, true, true, true, 1),
('Movimientos de planilla', 'Administración de movimientos de planilla', 'FormMovimientosPlanilla', true, true, true, true, 1),
('Generación de planilla', 'Generación y administración de planillas', 'FormGenerarPlanilla', true, true, true, true, 1),
('Historial de nómina', 'Consulta del historial de nómina', 'FormHistorialNomina', true, true, true, true, 1),
('Solicitud de vacaciones', 'Gestión de solicitudes de vacaciones', 'FormSolicitudVacaciones', true, true, true, true, 1),
('Control de saldos', 'Gestión de saldos de vacaciones', 'FormControlSaldos', true, true, true, true, 1),
('Historial de vacaciones', 'Consulta del historial de vacaciones', 'FormHistorialVacaciones', true, true, true, true, 1),
('Liquidaciones y recibos', 'Administración de liquidaciones y recibos', 'FormLiquidacionRecibo', true, true, true, true, 1),
('Historial de pagos', 'Consulta del historial de pagos', 'FormHistorialPagos', true, true, true, true, 1),
('Control de asistencia', 'Registro y control de asistencias', 'Formasistencia', true, true, true, true, 1),
('Bitácora del sistema', 'Consulta de acciones realizadas en el sistema', 'FormBitacora', true, true, true, true, 1),
('Centro de ayuda', 'Consulta de ayuda y manual del sistema', 'Formhelp', true, true, true, true, 1),
('Nuevo empleado', 'Registro de nuevos empleados', 'FormNuevoregistro', true, true, true, false, 2),
('Mantenimiento de empleados', 'Modificación, baja y reactivación de empleados', 'FormMantenimientoEmpleado', true, false, true, true, 2),
('Directorio de empleados', 'Consulta del directorio de empleados', 'FormDirectorioEmpleados', true, false, false, false, 2),
('Movimientos de planilla', 'Administración de movimientos de planilla', 'FormMovimientosPlanilla', true, true, true, false, 2),
('Generación de planilla', 'Generación y administración de planillas', 'FormGenerarPlanilla', true, true, true, false, 2),
('Historial de nómina', 'Consulta del historial de nómina', 'FormHistorialNomina', true, false, false, false, 2),
('Solicitud de vacaciones', 'Gestión de solicitudes de vacaciones', 'FormSolicitudVacaciones', true, true, true, false, 2),
('Control de saldos', 'Gestión de saldos de vacaciones', 'FormControlSaldos', true, true, true, false, 2),
('Historial de vacaciones', 'Consulta del historial de vacaciones', 'FormHistorialVacaciones', true, true, true, false, 2),
('Liquidaciones y recibos', 'Administración de liquidaciones y recibos', 'FormLiquidacionRecibo', true, true, true, false, 2),
('Historial de pagos', 'Consulta del historial de pagos', 'FormHistorialPagos', true, false, false, false, 2),
('Control de asistencia', 'Registro y control de asistencias', 'Formasistencia', true, true, true, false, 2),
('Bitácora del sistema', 'Consulta de acciones realizadas en el sistema', 'FormBitacora', true, false, false, false, 2),
('Centro de ayuda', 'Consulta de ayuda y manual del sistema', 'Formhelp', true, false, false, false, 2),
('Nuevo empleado', 'Registro de nuevos empleados', 'FormNuevoregistro', true, true, false, false, 3),
('Mantenimiento de empleados', 'Modificación, baja y reactivación de empleados', 'FormMantenimientoEmpleado', true, false, true, false, 3),
('Directorio de empleados', 'Consulta del directorio de empleados', 'FormDirectorioEmpleados', true, false, false, false, 3),
('Movimientos de planilla', 'Administración de movimientos de planilla', 'FormMovimientosPlanilla', false, false, false, false, 3),
('Generación de planilla', 'Generación y administración de planillas', 'FormGenerarPlanilla', false, false, false, false, 3),
('Historial de nómina', 'Consulta del historial de nómina', 'FormHistorialNomina', false, false, false, false, 3),
('Solicitud de vacaciones', 'Gestión de solicitudes de vacaciones', 'FormSolicitudVacaciones', true, true, true, false, 3),
('Control de saldos', 'Gestión de saldos de vacaciones', 'FormControlSaldos', true, false, false, false, 3),
('Historial de vacaciones', 'Consulta del historial de vacaciones', 'FormHistorialVacaciones', true, false, false, false, 3),
('Liquidaciones y recibos', 'Administración de liquidaciones y recibos', 'FormLiquidacionRecibo', false, false, false, false, 3),
('Historial de pagos', 'Consulta del historial de pagos', 'FormHistorialPagos', false, false, false, false, 3),
('Control de asistencia', 'Registro y control de asistencias', 'Formasistencia', true, true, true, false, 3),
('Bitácora del sistema', 'Consulta de acciones realizadas en el sistema', 'FormBitacora', false, false, false, false, 3),
('Centro de ayuda', 'Consulta de ayuda y manual del sistema', 'Formhelp', true, false, false, false, 3),
('Nuevo empleado', 'Registro de nuevos empleados', 'FormNuevoregistro', false, false, false, false, 4),
('Mantenimiento de empleados', 'Modificación, baja y reactivación de empleados', 'FormMantenimientoEmpleado', false, false, false, false, 4),
('Directorio de empleados', 'Consulta del directorio de empleados', 'FormDirectorioEmpleados', true, false, false, false, 4),
('Movimientos de planilla', 'Administración de movimientos de planilla', 'FormMovimientosPlanilla', false, false, false, false, 4),
('Generación de planilla', 'Generación y administración de planillas', 'FormGenerarPlanilla', false, false, false, false, 4),
('Historial de nómina', 'Consulta del historial de nómina', 'FormHistorialNomina', false, false, false, false, 4),
('Solicitud de vacaciones', 'Gestión de solicitudes de vacaciones', 'FormSolicitudVacaciones', true, true, false, false, 4),
('Control de saldos', 'Gestión de saldos de vacaciones', 'FormControlSaldos', false, false, false, false, 4),
('Historial de vacaciones', 'Consulta del historial de vacaciones', 'FormHistorialVacaciones', true, false, false, false, 4),
('Liquidaciones y recibos', 'Administración de liquidaciones y recibos', 'FormLiquidacionRecibo', false, false, false, false, 4),
('Historial de pagos', 'Consulta del historial de pagos', 'FormHistorialPagos', false, false, false, false, 4),
('Control de asistencia', 'Registro y control de asistencias', 'Formasistencia', true, false, false, false, 4),
('Bitácora del sistema', 'Consulta de acciones realizadas en el sistema', 'FormBitacora', false, false, false, false, 4),
('Centro de ayuda', 'Consulta de ayuda y manual del sistema', 'Formhelp', true, false, false, false, 4);

-- =========================================================
-- NIVEL 5: USUARIOS (depende de Empleados y Roles)
-- =========================================================

-- 10. tbl_Usuarios
-- Contraseñas de prueba. En la aplicación deben guardarse cifradas o con hash.
insert into tbl_Usuarios
(cmp_nombre, cmp_contras, cmp_id_empleado, cmp_id_rol, cmp_estado) values
('gerente1', '123', 10, 1, true),
('recursoshumanos2', '123', 1, 2, true),
('supervisor3', '123', 7, 3, true),
('secretaria4', '123', 8, 4, true);

-- =========================================================
-- NIVEL 6: PLANILLA (depende de Usuarios)
-- =========================================================

-- 11. tbl_Planilla
insert into tbl_Planilla (cmp_periodo_inicio, cmp_periodo_fin, cmp_estado, cmp_total_ingresos, cmp_total_descuentos, cmp_total_pagar, cmp_observaciones, cmp_id_usuario) values
('2026-01-01', '2026-01-15', 'pagada', 45000.00, 5000.00, 40000.00, 'Planilla quincenal enero P1', 2),
('2026-01-16', '2026-01-31', 'pagada', 46000.00, 5200.00, 40800.00, 'Planilla quincenal enero P2', 2),
('2026-02-01', '2026-02-15', 'pagada', 45500.00, 5100.00, 40400.00, 'Planilla quincenal febrero P1', 2),
('2026-02-16', '2026-02-28', 'pagada', 45800.00, 5150.00, 40650.00, 'Planilla quincenal febrero P2', 2),
('2026-03-01', '2026-03-15', 'pagada', 46200.00, 5250.00, 40950.00, 'Planilla quincenal marzo P1', 2),
('2026-03-16', '2026-03-31', 'pagada', 46500.00, 5300.00, 41200.00, 'Planilla quincenal marzo P2', 2),
('2026-04-01', '2026-04-15', 'aprobada', 46800.00, 5350.00, 41450.00, 'Planilla quincenal abril P1', 2),
('2026-04-16', '2026-04-30', 'revisada', 47000.00, 5400.00, 41600.00, 'Planilla quincenal abril P2', 2),
('2026-05-01', '2026-05-15', 'borrador', 47200.00, 5450.00, 41750.00, 'Planilla quincenal mayo P1', 2),
('2026-05-16', '2026-05-31', 'borrador', 47500.00, 5500.00, 42000.00, 'Planilla quincenal mayo P2', 2);

-- =========================================================
-- NIVEL 7: DETALLE_PLANILLA (depende de Planilla y Empleados)
-- =========================================================

-- 12. tbl_Detalle_Planilla
insert into tbl_Detalle_Planilla (cmp_salario_base, cmp_total_sumativo, cmp_total_restativo, cmp_salario_bruto, cmp_salario_neto, cmp_observaciones, cmp_id_planilla, cmp_id_empleado) values
(12000.00, 500.00, 700.00, 12500.00, 11800.00, 'Detalle enero P1 - Carlos', 1, 1),
(7000.00, 300.00, 450.00, 7300.00, 6850.00, 'Detalle enero P1 - María', 1, 2),
(4500.00, 400.00, 300.00, 4900.00, 4600.00, 'Detalle enero P1 - José', 1, 3),
(6500.00, 200.00, 350.00, 6700.00, 6350.00, 'Detalle enero P2 - Ana', 2, 4),
(8000.00, 350.00, 500.00, 8350.00, 7850.00, 'Detalle enero P2 - Luis', 2, 5),
(3500.00, 150.00, 200.00, 3650.00, 3450.00, 'Detalle febrero P1 - Sofía', 3, 6),
(6000.00, 250.00, 300.00, 6250.00, 5950.00, 'Detalle febrero P1 - Diego', 3, 7),
(4000.00, 180.00, 220.00, 4180.00, 3960.00, 'Detalle febrero P2 - Laura', 4, 8),
(3200.00, 120.00, 180.00, 3320.00, 3140.00, 'Detalle febrero P2 - Pedro', 4, 9),
(12000.00, 500.00, 700.00, 12500.00, 11800.00, 'Detalle marzo P1 - Gabriela', 5, 10);

-- =========================================================
-- NIVEL 8: DEDUCCIONES (depende de Detalle_Planilla y Tipo_Deduccion)
-- =========================================================

-- 13. tbl_Deducciones (llave primaria compuesta: id_detalle_planilla + id_tipo_deduccion)
insert into tbl_Deducciones (cmp_id_detalle_planilla, cmp_id_tipo_deduccion, cmp_cantidad, cmp_monto, cmp_descripcion) values
(1, 1, 1, 480.00, 'Descuento IGSS Carlos'),
(2, 1, 1, 280.00, 'Descuento IGSS María'),
(3, 1, 1, 180.00, 'Descuento IGSS José'),
(4, 2, 1, 220.00, 'Descuento ISR Ana'),
(5, 1, 1, 320.00, 'Descuento IGSS Luis'),
(6, 1, 1, 140.00, 'Descuento IGSS Sofía'),
(7, 3, 1, 150.00, 'Cuota préstamo Diego'),
(8, 1, 1, 160.00, 'Descuento IGSS Laura'),
(9, 4, 1, 100.00, 'Anticipo Pedro'),
(10, 1, 1, 480.00, 'Descuento IGSS Gabriela');

-- =========================================================
-- NIVEL 9: VACACIONES (depende de Empleados y Usuarios)
-- =========================================================

-- 14. tbl_Vacaciones
insert into tbl_Vacaciones
(cmp_id_empleado, cmp_fecha_solicitud, cmp_fecha_inicio, cmp_fecha_fin, cmp_dias_solicitados, cmp_motivo, cmp_estado, cmp_observaciones) values
(1, '2026-01-05', '2026-01-20', '2026-01-25', 5, 'Descanso anual', 'Aprobada', 'Sin observaciones'),
(2, '2026-01-10', '2026-02-01', '2026-02-05', 5, 'Viaje familiar', 'Aprobada', 'Sin observaciones'),
(3, '2026-02-01', '2026-02-15', '2026-02-18', 3, 'Descanso', 'Pendiente', null),
(4, '2026-02-10', '2026-03-01', '2026-03-06', 5, 'Vacaciones anuales', 'Aprobada', 'Aprobado por gerencia'),
(5, '2026-03-01', '2026-03-15', '2026-03-19', 4, 'Viaje', 'Rechazada', 'Cruza con cierre contable'),
(6, '2026-03-05', '2026-04-01', '2026-04-05', 5, 'Descanso', 'Aprobada', 'Sin observaciones'),
(7, '2026-04-01', '2026-04-10', '2026-04-13', 3, 'Asuntos personales', 'Pendiente', null),
(8, '2026-04-05', '2026-05-01', '2026-05-05', 5, 'Vacaciones', 'Aprobada', 'Sin observaciones'),
(9, '2026-05-01', '2026-05-15', '2026-05-18', 3, 'Descanso', 'Pendiente', null),
(10, '2026-05-10', '2026-06-01', '2026-06-05', 5, 'Vacaciones anuales', 'Aprobada', 'Sin observaciones');

-- =========================================================
-- NIVEL 10: PERMISOS (depende de Empleados y Usuarios)
-- =========================================================

-- 15. tbl_Permisos
insert into tbl_Permisos (cmp_fecha_solicitud, cmp_fecha_inicio, cmp_fecha_fin, cmp_tipo_permiso, cmp_genera_descuento, cmp_estado, cmp_motivo, cmp_observaciones, cmp_id_empleado, cmp_id_usuario_autoriza) values
('2026-01-08', '2026-01-09 08:00:00', '2026-01-09 12:00:00', 'Personal', false, 'aprobado', 'Cita médica', 'Sin observaciones', 1, 2),
('2026-01-12', '2026-01-13 08:00:00', '2026-01-13 17:00:00', 'Enfermedad', true, 'aprobado', 'Reposo médico', 'Con constancia médica', 2, 2),
('2026-02-02', '2026-02-03 08:00:00', '2026-02-03 12:00:00', 'Estudio', false, 'pendiente', 'Examen universitario', null, 3, null),
('2026-02-11', '2026-02-12 08:00:00', '2026-02-12 17:00:00', 'Personal', true, 'aprobado', 'Trámite legal', 'Sin observaciones', 4, 2),
('2026-03-02', '2026-03-03 08:00:00', '2026-03-03 12:00:00', 'Enfermedad', true, 'rechazado', 'Consulta médica', 'Sin constancia', 5, 2),
('2026-03-06', '2026-03-07 08:00:00', '2026-03-07 17:00:00', 'Personal', false, 'aprobado', 'Asuntos familiares', 'Sin observaciones', 6, 2),
('2026-04-02', '2026-04-03 08:00:00', '2026-04-03 12:00:00', 'Estudio', false, 'pendiente', 'Curso de capacitación', null, 7, null),
('2026-04-06', '2026-04-07 08:00:00', '2026-04-07 17:00:00', 'Enfermedad', true, 'aprobado', 'Reposo médico', 'Con constancia médica', 8, 2),
('2026-05-02', '2026-05-03 08:00:00', '2026-05-03 12:00:00', 'Personal', false, 'pendiente', 'Trámite bancario', null, 9, null),
('2026-05-11', '2026-05-12 08:00:00', '2026-05-12 17:00:00', 'Personal', true, 'aprobado', 'Mudanza', 'Sin observaciones', 10, 2);

-- =========================================================
-- NIVEL 11: ASISTENCIAS (depende de Empleados)
-- =========================================================

-- 16. tbl_Asistencias
insert into tbl_Asistencias (cmp_fecha, cmp_hora_entrada, cmp_hora_salida, cmp_minutos_tardanza, cmp_horas_trabajadas, cmp_horas_extra, cmp_observaciones, cmp_id_empleado) values
('2026-06-01', '08:00:00', '17:00:00', 0, 8.00, 0.00, 'Puntual', 1),
('2026-06-01', '08:10:00', '17:00:00', 10, 7.83, 0.00, 'Tardanza leve', 2),
('2026-06-01', '08:00:00', '18:00:00', 0, 8.00, 1.00, 'Hora extra', 3),
('2026-06-01', '08:05:00', '17:00:00', 5, 7.92, 0.00, 'Tardanza leve', 4),
('2026-06-01', '08:00:00', '17:00:00', 0, 8.00, 0.00, 'Puntual', 5),
('2026-06-02', '08:00:00', '17:00:00', 0, 8.00, 0.00, 'Puntual', 6),
('2026-06-02', '08:15:00', '17:00:00', 15, 7.75, 0.00, 'Tardanza', 7),
('2026-06-02', '08:00:00', '19:00:00', 0, 8.00, 2.00, 'Dos horas extra', 8),
('2026-06-02', '08:00:00', '17:00:00', 0, 8.00, 0.00, 'Puntual', 9),
('2026-06-02', '08:00:00', '17:00:00', 0, 8.00, 0.00, 'Puntual', 10);

-- =========================================================
-- NIVEL 12: AUSENCIAS (depende de Empleados, Vacaciones y Permisos)
-- =========================================================

-- 17. tbl_Ausencias
insert into tbl_Ausencias (cmp_fecha_inicio, cmp_fecha_fin, cmp_cantidad_dias, cmp_tipo_ausencia, cmp_justificada, cmp_genera_descuento, cmp_motivo, cmp_observaciones, cmp_id_empleado, cmp_id_vacacion, cmp_id_permiso) values
('2026-01-20', '2026-01-25', 5, 'Vacaciones', true, false, 'Descanso anual', 'Vinculada a vacaciones', 1, 1, null),
('2026-01-09', '2026-01-09', 1, 'Permiso', true, false, 'Cita médica', 'Vinculada a permiso', 1, null, 1),
('2026-02-01', '2026-02-05', 5, 'Vacaciones', true, false, 'Viaje familiar', 'Vinculada a vacaciones', 2, 2, null),
('2026-01-13', '2026-01-13', 1, 'Permiso', true, true, 'Reposo médico', 'Vinculada a permiso', 2, null, 2),
('2026-03-01', '2026-03-06', 5, 'Vacaciones', true, false, 'Vacaciones anuales', 'Vinculada a vacaciones', 4, 4, null),
('2026-02-12', '2026-02-12', 1, 'Permiso', true, true, 'Trámite legal', 'Vinculada a permiso', 4, null, 4),
('2026-04-01', '2026-04-05', 5, 'Vacaciones', true, false, 'Descanso', 'Vinculada a vacaciones', 6, 6, null),
('2026-04-07', '2026-04-07', 1, 'Permiso', true, true, 'Reposo médico', 'Vinculada a permiso', 8, null, 8),
('2026-05-01', '2026-05-05', 5, 'Vacaciones', true, false, 'Vacaciones', 'Vinculada a vacaciones', 8, 8, null),
('2026-06-10', '2026-06-10', 1, 'Injustificada', false, true, 'No se presentó', 'Sin justificación', 9, null, null);

-- =========================================================
-- NIVEL 13: SEGUROS (depende de Empleados)
-- =========================================================

-- 18. tbl_Seguros
insert into tbl_Seguros (cmp_nombre, cmp_aseguradora, cmp_descripcion, cmp_numero_poliza, cmp_fecha_inicio, cmp_fecha_fin, cmp_monto_cobertura, cmp_id_empleado) values
('Seguro de Vida', 'Seguros G&T', 'Cobertura de vida colectivo', 'POL-0001', '2020-01-15', '2030-01-15', 50000.00, 1),
('Seguro Médico', 'Seguros El Roble', 'Cobertura médica hospitalaria', 'POL-0002', '2019-03-01', '2029-03-01', 30000.00, 2),
('Seguro de Vida', 'Seguros G&T', 'Cobertura de vida colectivo', 'POL-0003', '2018-07-10', '2028-07-10', 50000.00, 3),
('Seguro Médico', 'Seguros El Roble', 'Cobertura médica hospitalaria', 'POL-0004', '2021-05-20', '2031-05-20', 30000.00, 4),
('Seguro de Vida', 'Seguros G&T', 'Cobertura de vida colectivo', 'POL-0005', '2017-09-05', '2027-09-05', 50000.00, 5),
('Seguro Médico', 'Seguros El Roble', 'Cobertura médica hospitalaria', 'POL-0006', '2022-02-01', '2032-02-01', 30000.00, 6),
('Seguro de Vida', 'Seguros G&T', 'Cobertura de vida colectivo', 'POL-0007', '2016-06-15', '2026-06-15', 50000.00, 7),
('Seguro Médico', 'Seguros El Roble', 'Cobertura médica hospitalaria', 'POL-0008', '2020-10-10', '2030-10-10', 30000.00, 8),
('Seguro de Vida', 'Seguros G&T', 'Cobertura de vida colectivo', 'POL-0009', '2023-01-10', '2033-01-10', 50000.00, 9),
('Seguro Médico', 'Seguros El Roble', 'Cobertura médica hospitalaria', 'POL-0010', '2015-04-01', '2025-04-01', 30000.00, 10);

-- =========================================================
-- NIVEL 14: LIQUIDACIONES (depende de Empleados y Usuarios)
-- =========================================================

-- 19. tbl_Liquidaciones
insert into tbl_Liquidaciones (cmp_fecha_calculo, cmp_fecha_retiro, cmp_motivo_retiro, cmp_salario_pendiente, cmp_indemnizacion, cmp_vacaciones_pendientes, cmp_aguinaldo_pendiente, cmp_bono_14_pendiente, cmp_otros_ingresos, cmp_total_descuentos, cmp_total_liquidacion, cmp_numero_recibo, cmp_fecha_pago, cmp_estado, cmp_observaciones, cmp_id_empleado, cmp_id_usuario) values
('2026-06-01', '2026-06-05', 'Renuncia', 1200.00, 5000.00, 800.00, 400.00, 400.00, 0.00, 300.00, 7500.00, 'REC-0001', '2026-06-10', 'pagada', 'Liquidación por renuncia', 1, 2),
('2026-06-02', '2026-06-06', 'Despido justificado', 1300.00, 5200.00, 850.00, 420.00, 420.00, 0.00, 320.00, 7870.00, 'REC-0002', '2026-06-11', 'pagada', 'Liquidación por despido', 2, 2),
('2026-06-03', '2026-06-07', 'Renuncia', 1100.00, 4800.00, 780.00, 380.00, 380.00, 0.00, 280.00, 7160.00, 'REC-0003', null, 'pendiente', 'En proceso de pago', 3, 2),
('2026-06-04', '2026-06-08', 'Mutuo acuerdo', 1250.00, 5100.00, 810.00, 410.00, 410.00, 0.00, 310.00, 7670.00, 'REC-0004', '2026-06-12', 'pagada', 'Liquidación por mutuo acuerdo', 4, 2),
('2026-06-05', '2026-06-09', 'Renuncia', 1150.00, 4900.00, 790.00, 390.00, 390.00, 0.00, 290.00, 7330.00, 'REC-0005', null, 'pendiente', 'En proceso de pago', 5, 2),
('2026-06-06', '2026-06-10', 'Despido justificado', 1350.00, 5300.00, 860.00, 430.00, 430.00, 0.00, 330.00, 8040.00, 'REC-0006', '2026-06-14', 'pagada', 'Liquidación por despido', 6, 2),
('2026-06-07', '2026-06-11', 'Renuncia', 1180.00, 4950.00, 800.00, 400.00, 400.00, 0.00, 300.00, 7430.00, 'REC-0007', null, 'pendiente', 'En proceso de pago', 7, 2),
('2026-06-08', '2026-06-12', 'Mutuo acuerdo', 1220.00, 5050.00, 820.00, 405.00, 405.00, 0.00, 305.00, 7595.00, 'REC-0008', '2026-06-16', 'pagada', 'Liquidación por mutuo acuerdo', 8, 2),
('2026-06-09', '2026-06-13', 'Renuncia', 1160.00, 4870.00, 770.00, 385.00, 385.00, 0.00, 285.00, 7275.00, 'REC-0009', null, 'pendiente', 'En proceso de pago', 9, 2),
('2026-06-10', '2026-06-14', 'Despido justificado', 1400.00, 5500.00, 900.00, 450.00, 450.00, 0.00, 350.00, 8350.00, 'REC-0010', '2026-06-18', 'pagada', 'Liquidación por despido', 10, 2);

-- =========================================================
-- NIVEL 15: PAGOS (depende de Detalle_Planilla)
-- =========================================================

-- 20. tbl_Pagos
insert into tbl_Pagos (cmp_fecha_pago, cmp_monto_pagado, cmp_forma_pago, cmp_numero_recibo, cmp_observaciones, cmp_id_detalle_planilla) values
('2026-01-16', 11800.00, 'Depósito', 'PAG-0001', 'Pago quincenal Carlos', 1),
('2026-01-16', 6850.00, 'Depósito', 'PAG-0002', 'Pago quincenal María', 2),
('2026-01-16', 4600.00, 'Depósito', 'PAG-0003', 'Pago quincenal José', 3),
('2026-02-01', 6350.00, 'Depósito', 'PAG-0004', 'Pago quincenal Ana', 4),
('2026-02-01', 7850.00, 'Depósito', 'PAG-0005', 'Pago quincenal Luis', 5),
('2026-02-16', 3450.00, 'Depósito', 'PAG-0006', 'Pago quincenal Sofía', 6),
('2026-02-16', 5950.00, 'Depósito', 'PAG-0007', 'Pago quincenal Diego', 7),
('2026-03-01', 3960.00, 'Efectivo', 'PAG-0008', 'Pago quincenal Laura', 8),
('2026-03-01', 3140.00, 'Efectivo', 'PAG-0009', 'Pago quincenal Pedro', 9),
('2026-03-16', 11800.00, 'Depósito', 'PAG-0010', 'Pago quincenal Gabriela', 10);

-- =========================================================
-- NIVEL 16: MOVIMIENTOS_PLANILLA (depende de Empleados, Tipo_Movimiento, Planilla, Usuarios)
-- =========================================================

-- 21. tbl_Movimientos_Planilla
insert into tbl_Movimientos_Planilla (cmp_fecha, cmp_cantidad, cmp_monto, cmp_descripcion, cmp_estado, cmp_id_empleado, cmp_id_tipo_movimiento, cmp_id_planilla, cmp_id_usuario) values
('2026-01-10', null, 500.00, 'Bono de productividad Carlos', 'aplicado', 1, 1, 1, 2),
('2026-01-10', 2, 300.00, 'Horas extra María', 'aplicado', 2, 2, 1, 2),
('2026-01-25', null, 400.00, 'Comisión de ventas José', 'aplicado', 3, 3, 2, 2),
('2026-02-05', null, 200.00, 'Bono de productividad Ana', 'aplicado', 4, 1, 2, 2),
('2026-02-10', 3, 350.00, 'Horas extra Luis', 'aplicado', 5, 2, 3, 2),
('2026-02-20', null, 150.00, 'Otros ingresos Sofía', 'aplicado', 6, 10, 3, 2),
('2026-03-05', null, 250.00, 'Comisión de ventas Diego', 'aplicado', 7, 3, 4, 2),
('2026-03-15', null, 180.00, 'Bono de productividad Laura', 'aplicado', 8, 1, 4, 2),
('2026-04-01', null, 120.00, 'Otros ingresos Pedro', 'pendiente', 9, 10, null, 2),
('2026-04-10', null, 500.00, 'Bono de productividad Gabriela', 'pendiente', 10, 1, null, 2);

alter table tbl_Bitacora
modify column cmp_direccion_ip varchar(45)
not null default 'No disponible';

ALTER TABLE tbl_Bitacora
DROP COLUMN cmp_nombre_equipo;

select
    u.cmp_id_usuario,
    u.cmp_nombre as Usuario,
    u.cmp_id_rol,
    r.cmp_nombre as Rol
from tbl_Usuarios u
inner join tbl_Roles r
    on u.cmp_id_rol = r.cmp_id_rol;
    
select
    a.cmp_id_rol,
    r.cmp_nombre as Rol,
    a.cmp_nombre_formulario as Formulario,
    a.cmp_ver as Ver,
    a.cmp_crear as Crear,
    a.cmp_modificar as Modificar,
    a.cmp_eliminar as Eliminar
from tbl_Aplicaciones a
inner join tbl_Roles r
    on a.cmp_id_rol = r.cmp_id_rol
order by a.cmp_id_rol, a.cmp_nombre_formulario;

update tbl_Aplicaciones
set cmp_eliminar = 0
where cmp_nombre_formulario =
      'FormMantenimientoEmpleado'
and cmp_id_rol in (2, 3, 4);

update tbl_Aplicaciones
set cmp_eliminar = 1
where cmp_nombre_formulario =
      'FormMantenimientoEmpleado'
and cmp_id_rol = 1;
