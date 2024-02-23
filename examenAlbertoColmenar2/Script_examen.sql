-- Crea la base de datos  
CREATE DATABASE EXAMEN  

-- Crea la tabla
CREATE TABLE [EXAMEN].[dbo].[calificaciones](
	[Apellidos] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Asistencia] [nvarchar](50) NOT NULL,
	[1er_trimestre_examen] [float] NOT NULL,
	[1er_trimestre_practicas] [tinyint] NOT NULL,
	[2do_trimestre_examen] [float] NOT NULL,
	[2do_trimestre_practicas] [float] NULL,
	[3er_trimestre_examen] [tinyint] NOT NULL,
	[3er_trimestre_practicas] [tinyint] NOT NULL
)  


-- Insertar datos en la tabla

INSERT INTO EXAMEN..calificaciones VALUES ('Anido Bonet','David','90%',5.5,6,2.75, NULL,2,0)
INSERT INTO EXAMEN..calificaciones VALUES ('Bueno Cerdeira','Patricia','95%',9.5,9,9,6.25,10,10)
INSERT INTO EXAMEN..calificaciones VALUES ('Casariego García','Raúl','98%',4.25,3,5.75,4,3,5)
INSERT INTO EXAMEN..calificaciones VALUES ('Curbelo Sánchez','Jorge','75%',6.75,0,4.25,NULL,6,4)
INSERT INTO EXAMEN..calificaciones VALUES ('Díaz Souto','Sofía','82%',7,10,6.5,9,10,5)
INSERT INTO EXAMEN..calificaciones VALUES ('García Perez','Yaiza','85%',10,9,8,75,5,0)
INSERT INTO EXAMEN..calificaciones VALUES ('Sánchez Jordán','María','92%',8.75,5,9,6.5,0,2)
INSERT INTO EXAMEN..calificaciones VALUES ('Lorenzo García','Jaime','100%',9.75,2,8.25,7.5,9,2)
INSERT INTO EXAMEN..calificaciones VALUES ('Martínez Lucas','Cecilia','86%',7,6,4,6.25,3,6)
INSERT INTO EXAMEN..calificaciones VALUES ('Mora Peñaloza','Sandra','70%',5.25,6,2,65,10,7)
INSERT INTO EXAMEN..calificaciones VALUES ('Morillo Escudero','Ana','100%',9.5,3,10,8.75,2,4)
INSERT INTO EXAMEN..calificaciones VALUES ('Muñoz Gómez','Carolina','94%',7.75,5,6.5,4,5,1)
INSERT INTO EXAMEN..calificaciones VALUES ('Ramirez de la Puente','Raquel','75%',0,8,1,2.25,6,4)
INSERT INTO EXAMEN..calificaciones VALUES ('Riego Pizarro','Carlos','75%',4,7,2.5,NULL,3,1)
INSERT INTO EXAMEN..calificaciones VALUES ('Rodríguez de Blas','Ignacio','80%',8.25,7,5.25,6.5,6,5)
INSERT INTO EXAMEN..calificaciones VALUES ('Moreno Angulo','Antonio','88%',9,6,6.75,5.25,8,2)
