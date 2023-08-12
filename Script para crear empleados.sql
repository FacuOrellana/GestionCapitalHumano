USE [CapitalHumano]
GO

INSERT INTO [dbo].[ObraSocial]
           ([Descripcion]
           ,[Aporte])
     VALUES
           ('ObraSocial A', 100),
           ('ObraSocial B', 150),
           ('ObraSocial C', 200)
GO

USE [CapitalHumano]
GO

INSERT INTO [dbo].[Contrato]
           ([FechaInicio]
           ,[FechaFin]
           ,[Sueldo]
           ,[Seniority]
           ,[IdEmpleado])
     VALUES
           ('2022-01-01', '2023-12-31', 50000, 'Junior', 1),
           ('2021-03-15', '2023-06-30', 70000, 'Senior', 2),
           ('2023-02-10', '2024-02-09', 60000, 'Intermedio', 3)
GO

USE [CapitalHumano]
GO

INSERT INTO [dbo].[Sindicato]
           ([Descripcion]
           ,[Aporte])
     VALUES
           ('Sindicato A', 50),
           ('Sindicato B', 75),
           ('Sindicato C', 100)
GO

USE [CapitalHumano]
GO

INSERT INTO [dbo].[PuestoTrabajo]
           ([Nombre]
           ,[Descripcion])
     VALUES
           ('Puesto A', 'Descripci�n Puesto A'),
           ('Puesto B', 'Descripci�n Puesto B'),
           ('Puesto C', 'Descripci�n Puesto C')
GO

USE [CapitalHumano]
GO

INSERT INTO [dbo].[EquipoTrabajo]
           ([Descripcion]
           ,[IdDepartamento])
     VALUES
           ('Equipo A', 1),
           ('Equipo B', 2),
           ('Equipo C', 3)
GO

USE [CapitalHumano]
GO

INSERT INTO [dbo].[Empleado]
           ([Nombre]
           ,[Apellido]
           ,[Legajo]
           ,[FechaNacimiento]
           ,[Direccion]
           ,[Ciudad]
           ,[ObraSocialIdObraSocial]
           ,[ContratoIdContrato]
           ,[SindicatoIdSindicato]
           ,[PuestoTrabajoIdPuestoTrabajo]
           ,[EquipoTrabajoIdEquipoTrabajo])
     VALUES
           ('Juan', 'Perez', 1001, '1990-05-15', 'Calle 123', 'Ciudad A', 1, 1, 1, 1, 1),
           ('Mar�a', 'Gonz�lez', 1002, '1988-11-10', 'Avenida 456', 'Ciudad B', 2, 1, 2, 2, 2),
           ('Carlos', 'L�pez', 1003, '1995-02-28', 'Calle 789', 'Ciudad A', 1, 2, 1, 1, 1),
           ('Ana', 'Mart�nez', 1004, '1992-07-20', 'Avenida 101', 'Ciudad C', 3, 2, 2, 3, 2),
           ('Luis', 'Rodr�guez', 1005, '1987-04-02', 'Calle 222', 'Ciudad B', 2, 3, 1, 2, 1),
           ('Laura', 'D�az', 1006, '1991-09-18', 'Avenida 333', 'Ciudad A', 1, 3, 2, 1, 2),
           ('Pedro', 'Sanchez', 1007, '1993-12-05', 'Calle 444', 'Ciudad C', 3, 1, 1, 3, 1),
           ('Marta', 'L�pez', 1008, '1989-03-25', 'Avenida 555', 'Ciudad B', 2, 2, 2, 2, 2),
           ('Jorge', 'Fern�ndez', 1009, '1994-08-12', 'Calle 666', 'Ciudad A', 1, 2, 1, 1, 1),
           ('Carolina', 'Ram�rez', 1010, '1990-06-30', 'Avenida 777', 'Ciudad C', 3, 3, 2, 3, 2)
GO


USE [CapitalHumano]
GO

-- Generar 30 empleados m�s con datos ficticios
INSERT INTO [dbo].[Empleado]
           ([Nombre]
           ,[Apellido]
           ,[Legajo]
           ,[FechaNacimiento]
           ,[Direccion]
           ,[Ciudad]
           ,[ObraSocialIdObraSocial]
           ,[ContratoIdContrato]
           ,[SindicatoIdSindicato]
           ,[PuestoTrabajoIdPuestoTrabajo]
           ,[EquipoTrabajoIdEquipoTrabajo])
     VALUES
           ('Julia', 'Mart�nez', 1021, '1994-02-15', 'Calle 21', 'Ciudad A', 1, 2, 3, 1, 2),
           ('Lucas', 'G�mez', 1022, '1993-09-10', 'Avenida 22', 'Ciudad B', 2, 1, 2, 2, 1),
           ('Camila', 'L�pez', 1023, '1995-11-25', 'Calle 23', 'Ciudad C', 3, 3, 1, 3, 3),
           ('Mateo', 'Rodr�guez', 1024, '1992-04-20', 'Calle 24', 'Ciudad A', 1, 1, 2, 1, 2),
           ('Valentina', 'P�rez', 1025, '1991-08-18', 'Avenida 25', 'Ciudad B', 2, 2, 1, 2, 1),
           ('Benjam�n', 'Fern�ndez', 1026, '1993-10-05', 'Calle 26', 'Ciudad C', 3, 3, 3, 3, 3),
           ('Sof�a', 'D�az', 1027, '1989-05-08', 'Calle 27', 'Ciudad A', 1, 2, 2, 1, 2),
           ('Daniel', 'S�nchez', 1028, '1990-06-12', 'Avenida 28', 'Ciudad B', 2, 1, 2, 2, 1),
           ('Isabella', 'Gonz�lez', 1029, '1987-07-30', 'Calle 29', 'Ciudad C', 3, 3, 1, 3, 3),
           ('Alejandro', 'Mart�n', 1030, '1994-01-25', 'Calle 30', 'Ciudad A', 1, 1, 2, 1, 2),
           ('M�a', 'Hern�ndez', 1031, '1993-09-28', 'Avenida 31', 'Ciudad B', 2, 2, 1, 2, 1),
           ('Luc�a', 'Ruiz', 1032, '1995-12-15', 'Calle 32', 'Ciudad C', 3, 3, 3, 3, 3),
           ('Liam', 'L�pez', 1033, '1990-03-08', 'Calle 33', 'Ciudad A', 1, 2, 2, 1, 2),
           ('Emma', 'P�rez', 1034, '1988-11-02', 'Avenida 34', 'Ciudad B', 2, 1, 2, 2, 1),
           ('Noah', 'Fern�ndez', 1035, '1992-07-10', 'Calle 35', 'Ciudad C', 3, 3, 1, 3, 3),
           ('Ava', 'S�nchez', 1036, '1991-06-28', 'Calle 36', 'Ciudad A', 1, 1, 2, 1, 2),
           ('Ethan', 'Garc�a', 1037, '1989-04-15', 'Avenida 37', 'Ciudad B', 2, 2, 1, 2, 1),
           ('Olivia', 'Hern�ndez', 1038, '1995-10-20', 'Calle 38', 'Ciudad C', 3, 3, 3, 3, 3),
           ('Aiden', 'Mart�nez', 1039, '1993-03-12', 'Calle 39', 'Ciudad A', 1, 2, 2, 1, 2),
           ('Sophia', 'L�pez', 1040, '1994-01-08', 'Avenida 40', 'Ciudad B', 2, 1, 2, 2, 1),
           ('Jackson', 'G�mez', 1041, '1990-08-18', 'Calle 41', 'Ciudad C', 3, 3, 1, 3, 3)
-- Agrega m�s empleados aqu�
GO

USE [CapitalHumano]
GO

-- Generar 20 empleados m�s con datos ficticios
INSERT INTO [dbo].[Empleado]
           ([Nombre]
           ,[Apellido]
           ,[Legajo]
           ,[FechaNacimiento]
           ,[Direccion]
           ,[Ciudad]
           ,[ObraSocialIdObraSocial]
           ,[ContratoIdContrato]
           ,[SindicatoIdSindicato]
           ,[PuestoTrabajoIdPuestoTrabajo]
           ,[EquipoTrabajoIdEquipoTrabajo])
     VALUES
           ('Gabriel', 'Hern�ndez', 1042, '1992-05-15', 'Calle 42', 'Ciudad A', 1, 2, 3, 1, 2),
           ('Emily', 'Mart�nez', 1043, '1991-11-10', 'Avenida 43', 'Ciudad B', 2, 1, 2, 2, 1),
           ('David', 'G�mez', 1044, '1993-02-28', 'Calle 44', 'Ciudad A', 1, 2, 1, 1, 1),
           ('Luna', 'Rodr�guez', 1045, '1990-07-20', 'Avenida 45', 'Ciudad C', 3, 2, 2, 3, 2),
           ('Mat�as', 'P�rez', 1046, '1989-04-02', 'Calle 46', 'Ciudad B', 2, 3, 1, 2, 1),
           ('Amelia', 'L�pez', 1047, '1991-09-18', 'Avenida 47', 'Ciudad A', 1, 3, 2, 1, 2),
           ('Sebasti�n', 'Garc�a', 1048, '1993-12-05', 'Calle 48', 'Ciudad C', 3, 1, 1, 3, 1),
           ('Aria', 'Fern�ndez', 1049, '1988-03-25', 'Avenida 49', 'Ciudad B', 2, 2, 2, 2, 2),
           ('Elijah', 'S�nchez', 1050, '1994-08-12', 'Calle 50', 'Ciudad A', 1, 2, 1, 1, 1),
           ('Victoria', 'Hern�ndez', 1051, '1990-06-30', 'Avenida 51', 'Ciudad C', 3, 3, 2, 3, 2),
           ('Daniel', 'Mart�nez', 1052, '1992-09-15', 'Calle 52', 'Ciudad A', 1, 1, 2, 1, 2),
           ('Zoe', 'G�mez', 1053, '1993-07-28', 'Avenida 53', 'Ciudad B', 2, 2, 1, 2, 1),
           ('Ethan', 'Rodr�guez', 1054, '1995-11-05', 'Calle 54', 'Ciudad C', 3, 3, 3, 3, 3),
           ('Isabella', 'L�pez', 1055, '1989-04-08', 'Calle 55', 'Ciudad A', 1, 2, 2, 1, 2),
           ('Oliver', 'P�rez', 1056, '1990-06-12', 'Avenida 56', 'Ciudad B', 2, 1, 2, 2, 1),
           ('Sophia', 'Fern�ndez', 1057, '1987-07-30', 'Calle 57', 'Ciudad C', 3, 3, 1, 3, 3),
           ('Alexander', 'S�nchez', 1058, '1994-01-25', 'Calle 58', 'Ciudad A', 1, 1, 2, 1, 2),
           ('Emma', 'Hern�ndez', 1059, '1993-09-28', 'Avenida 59', 'Ciudad B', 2, 2, 1, 2, 1),
           ('Mason', 'Mart�nez', 1060, '1995-12-15', 'Calle 60', 'Ciudad C', 3, 3, 3, 3, 3),
           ('Mia', 'L�pez', 1061, '1990-03-08', 'Calle 61', 'Ciudad A', 1, 2, 2, 1, 2),
           ('Liam', 'P�rez', 1062, '1988-11-02', 'Avenida 62', 'Ciudad B', 2, 1, 2, 2, 1)
-- Agrega m�s empleados aqu�
GO
