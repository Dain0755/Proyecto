create table Rol_Usuario (
Rol int primary key, 
Nombre_Rol varchar (20) not null
);
create table Usuarios (
Id_Usuario int primary key,
Usuario varchar(12),
Cod_Rol int  not null, 
constraint fk_Rol foreign key (Cod_Rol) references Rol_Usuario (Rol)
);
create table Proveedores (
Nit bigint Primary key,
Nombre_Proveedor varchar (50) not null,
Telefono int not null,
Dirección varchar (20) not null,
Email varchar (40)
);
create table Productos (
Cod_Productos bigint primary key,
Nombre varchar (50),
Precio_Compra decimal (12,0),
Precio_Venta decimal (12,0)
);

create table Producto_Proveedor (
Id_Productos bigint,
Id_Proveedor bigint,
constraint fk_Cod_Productos foreign key (Id_Productos) references Productos (Cod_Productos),
constraint fk_Nit foreign key (Id_Proveedor) references Proveedores (Nit)
);

create table Cliente (
Cédula_Cliente int primary key,
Nombres_Cliente varchar (50),
Telefono int,
Email varchar (40) null,
Dirección varchar (50) null
);

create table Factura (
Numero_Factura bigint primary key,
Fecha datetime ,
Sub_Total decimal (12,0),
Total decimal (12,0),
Identificacion_cliente int,
Identificacion_Usuario int
constraint fk_Cliente foreign key (Identificacion_cliente) references Cliente (Cédula_Cliente),
constraint fk_Usuarios foreign key (Identificacion_Usuario) references Usuarios (Id_Usuario)
);

create table Detalle_factura(
Codigo_Prod bigint,
Num_factura bigint,
constraint fk_Productos foreign key (Codigo_Prod) references Productos (Cod_Productos),
constraint fk_Factira foreign key (Num_factura) references Factura (Numero_Factura),
Cantidad int,
valor_Unitario decimal (12,0)
);

