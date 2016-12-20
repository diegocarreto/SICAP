CREATE PROCEDURE HabitantUpdate
	@idUser INT,
	@id INT,
	@nombre VARCHAR(100),
	@paterno VARCHAR(50),
	@materno VARCHAR(50),
	@observations VARCHAR(2000) = NULL,
	@active BIT = NULL
AS
	DECLARE @previousValue VARCHAR(2000) = (SELECT 'Nombre: ' + nombre + ' Paterno: ' + paterno + ' Materno:' + materno + ' Observations:' + ISNULL(observations,'') + ' Active' + CONVERT(VARCHAR(10), ISNULL(active,'')) FROM [dbo].[habitant] WHERE id = @id)

	UPDATE 
		[dbo].[habitant]
	SET
		[nombre] = @nombre,
		[paterno] = @paterno,
		[materno] = @materno,
		[observations] = @observations,
		[active] = ISNULL(@active, [active]),
		[updateDate] = GETDATE()
	WHERE
		id = @id

	DECLARE @currentValue VARCHAR(2000) = (SELECT 'Nombre: ' + nombre + ' Paterno: ' + paterno + ' Materno:' + materno + ' Observations:' + ISNULL(observations,'') + ' Active' + CONVERT(VARCHAR(10), ISNULL(active,'')) FROM [dbo].[habitant] WHERE id = @id)
	
	EXEC BinnacleAdd @idUser,'Actualización habitante','Habitant', @id ,'Update', @previousValue, @currentValue
