CREATE DATABASE Autos1
GO
 
USE Autos1
GO

CREATE TABLE Usuario(
	IdUsuario			INT IDENTITY PRIMARY KEY,
	NombreUsuario		VARCHAR(30) NOT NULL,
	ContraseniaUsuario	VARCHAR(30) NOT NULL,
)
 
CREATE TABLE Empleado(
	CodigoEmpleado			INT IDENTITY PRIMARY KEY,
	ApMaternoEmpleado		VARCHAR(30),
	ApPaternoEmpleado		VARCHAR(30),
	NombreEmpleado			VARCHAR(30),
	FechaIngresoEmpleado	DATETIME default(CURRENT_TIMESTAMP),
	IdUsuarioEmpleado		INT,
	CONSTRAINT fk_Usuario_Empleado
	FOREIGN KEY (IdUsuarioEmpleado) 
	REFERENCES Usuario (IdUsuario)
	)

CREATE TABLE Cliente(
	NumCuentaCliente	INT IDENTITY PRIMARY KEY,
	NombreCliente		VARCHAR(30) NOT NULL,
	ApMaternoCliente	VARCHAR(30) NOT NULL,
	ApPaternoCliente	VARCHAR(30) NOT NULL,
	EmailCliente		VARCHAR(120) NOT NULL,
	IdUsuarioCliente	INT,
	CONSTRAINT fk_Usuario_Cliente
	FOREIGN KEY (IdUsuarioCliente) 
	REFERENCES Usuario (IdUsuario)
 )

 CREATE TABLE Categoria(
	CodigoCat INT IDENTITY PRIMARY KEY,
	MarcaCat  VARCHAR(50) NOT NULL,
	ModeloCat VARCHAR(50) NOT NULL
)

CREATE TABLE Vehiculo(
	NumSerieVehiculo	VARCHAR(50) PRIMARY KEY,
	PrecioVehiculo		FLOAT NOT NULL,
	VersionVehiculo		VARCHAR(50) NOT NULL,
	ColorVehiculo		VARCHAR(30) NOT NULL,
	CodigoCatVehiculo INT,
	CONSTRAINT fk_Vehiculo_Categoria
	FOREIGN KEY (CodigoCatVehiculo) 
	REFERENCES Categoria (CodigoCat)
)

 CREATE TABLE Adquisicion(
	NumPedidoAdq INT IDENTITY PRIMARY KEY,
	FechaAdq DATETIME DEFAULT(CURRENT_TIMESTAMP),
	NumCuentaClienteAdq INT,
	NumSerieVehiculoAdq VARCHAR(50),
	CodigoEmpleadoAdq INT,

	CONSTRAINT fk_Adquisicion_Empleado
	FOREIGN KEY (CodigoEmpleadoAdq) 
	REFERENCES Empleado (CodigoEmpleado),

	CONSTRAINT fk_Adquisicon_Cliente
	FOREIGN KEY (NumCuentaClienteAdq) 
	REFERENCES Cliente (NumCuentaCliente),

	CONSTRAINT fk_Adquisicion_Vehiculo
	FOREIGN KEY (NumSerieVehiculoAdq) 
	REFERENCES Vehiculo(NumSerieVehiculo)

)

 INSERT INTO Usuario (NombreUsuario, ContraseniaUsuario)
 VALUES ('Perrosamigables','jaja12345')

 INSERT INTO Usuario (NombreUsuario, ContraseniaUsuario)
 VALUES ('Any832','GatosyPerros')

 INSERT INTO Usuario (NombreUsuario, ContraseniaUsuario)
 VALUES ('AmigosTodos9238','LaMaestraEsChida')

 INSERT INTO Usuario (NombreUsuario, ContraseniaUsuario)
 VALUES ('MiAbuelita','Asp2rre')

INSERT INTO Empleado (ApMaternoEmpleado, ApPaternoEmpleado, NombreEmpleado, IdUsuarioEmpleado)
VALUES ('Mojica','Padilla','Diego',1)

INSERT INTO Empleado (ApMaternoEmpleado, ApPaternoEmpleado, NombreEmpleado, IdUsuarioEmpleado)
VALUES ('Nova','Ordaz','Anahi', 2)

INSERT INTO Cliente (NombreCliente, ApMaternoCliente, ApPaternoCliente,EmailCliente, IdUsuarioCliente)
VALUES ('Alan','Mendoza','Cruz','alan11504@hotmail.com', 1)

INSERT INTO Cliente (NombreCliente, ApMaternoCliente, ApPaternoCliente,EmailCliente, IdUsuarioCliente)
VALUES ('Osvaldo','Hernandez','Martinez','ovaldohuelefeo123@hotmail.com', 2)

INSERT INTO Categoria (MarcaCat, ModeloCat)
VALUES ('Chevrolet','Cavalier')

INSERT INTO Categoria (MarcaCat, ModeloCat)
VALUES ('Honda','City')

INSERT INTO Vehiculo (NumSerieVehiculo,PrecioVehiculo, VersionVehiculo, ColorVehiculo, CodigoCatVehiculo)
VALUES ('HF92ND9DK128SND92',257000,2018,'Blanco', 1)

INSERT INTO Vehiculo (NumSerieVehiculo,PrecioVehiculo, VersionVehiculo, ColorVehiculo, CodigoCatVehiculo)
VALUES ('283HD9SJD0WJX8SK2',260000,2017,'Azul', 2)

INSERT INTO Adquisicion(NumCuentaClienteAdq, NumSerieVehiculoAdq, CodigoEmpleadoAdq)
VALUES (1, 'HF92ND9DK128SND92', 1)

INSERT INTO Adquisicion(NumCuentaClienteAdq, NumSerieVehiculoAdq, CodigoEmpleadoAdq)
VALUES (2, '283HD9SJD0WJX8SK2', 2)

SELECT * FROM Cliente
SELECT * FROM Usuario
SELECT * FROM Empleado
SELECT * FROM Categoria
SELECT * FROM Adquisicion
SELECT * FROM Vehiculo





	 
