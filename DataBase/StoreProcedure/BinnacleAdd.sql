CREATE PROCEDURE BinnacleAdd
	@idUser INT,
	@name	VARCHAR(100) = NULL,
	@tableName VARCHAR(30) = NULL,
	@idRowPk INT = NULL,
	@type VARCHAR(50) = NULL,	 
	@previousValue VARCHAR(4000) = NULL,
	@currentValue VARCHAR(4000) = NULL
AS

	INSERT INTO [dbo].[binnacle]
           ([idUser]
           ,[name]
           ,[tableName]
           ,[idRowPk]
           ,[type]
           ,[previousValue]
           ,[currentValue])
     VALUES
           (@idUser
           ,@name
           ,@tableName
           ,@idRowPk
           ,@type
           ,@previousValue
           ,@currentValue)