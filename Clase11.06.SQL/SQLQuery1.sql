/****** Script para el comando SelectTopNRows de SSMS  ******/
/*SELECT TOP 1000 [id]
      ,[nombre]
      ,[apellido]
      ,[edad]
  FROM [Padron].[dbo].[Personas]*/
  SELECT id,nombre,apellido,edad
  FROM Padron.dbo.Personas
  WHERE id > 1 AND id <= 7
  ORDER BY edad DESC
  
  INSERT INTO Padron.dbo.Personas
  (nombre,apellido,edad)
  VALUES ('Juan','Perez',18)

  UPDATE Padron.dbo.Personas
  SET nombre = 'Juan',
	  edad = 68
  WHERE id = 7

  /*DELETE FROM Padron.dbo.Personas
  WHERE id = 6*/

  /*Fecha y string siempre entre comillas simples*/ 