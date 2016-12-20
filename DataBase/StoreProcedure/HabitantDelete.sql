CREATE PROCEDURE HabitantDelete
	@idUser INT,
	@id INT
AS
	UPDATE 
		[dbo].[habitant]
	SET
		[deleted] = 1,
		[removalDate] = GETDATE()
	WHERE
		id = @id
	
	EXEC BinnacleAdd @idUser,'Baja logica habitante','Payment', @id ,'Delete', NULL, NULL