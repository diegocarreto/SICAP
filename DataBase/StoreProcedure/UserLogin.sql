CREATE PROC [dbo].[UserLogin]
	@alias VARCHAR(20),
	@password VARCHAR(12)
AS
	DECLARE @idUser INT
	DECLARE @userName VARCHAR(100)
	DECLARE @ali VARCHAR(20)
	DECLARE @pas VARCHAR(12)
	DECLARE @log VARCHAR(100) = 'Login. User:' + @alias + ' Password:' + @password;

	SELECT 
		@idUser = [id],
		@userName = [name],
		@ali = [alias],
		@pas = [password]
	FROM
		[dbo].[user3]
	WHERE
		[active] = 1
		AND [deleted] = 0
		AND [alias] = @alias
		AND [password] = @password

	SELECT 
			@idUser id,
			@userName name,
			@ali alias,
			@pas [password]

	IF @idUser IS NOT NULL AND @userName IS NOT NULL
	BEGIN
		 EXEC BinnacleAdd @IdUser,@log,'User',@IdUser,'Login', NULL, 'OK'
	END
	ELSE
	BEGIN
		 EXEC BinnacleAdd 0,@log,'User',0,'Login', NULL, 'Error'
	END