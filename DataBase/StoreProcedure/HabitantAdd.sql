CREATE PROCEDURE [dbo].[HabitantAdd]
	@idUser INT,
	@nombre VARCHAR(100),
	@paterno VARCHAR(50),
	@materno VARCHAR(50),
	@observations VARCHAR(2000)
AS
	INSERT INTO [dbo].[habitant]
		([nombre]
		,[paterno]
		,[materno]
		,[observations])
	VALUES
		(@nombre,
		 @paterno,
		 @materno,
		 @observations)

	DECLARE @id INT= SCOPE_IDENTITY()
	DECLARE @name VARCHAR(2000) = @nombre + ' ' + @paterno + ' ' + @materno

	SELECT @id id

	EXEC BinnacleAdd @idUser,'Nuevo habitante','Habitant', @id ,'Insert', NULL, @name