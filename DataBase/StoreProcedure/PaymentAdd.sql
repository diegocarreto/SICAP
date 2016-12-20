CREATE PROCEDURE PaymentAdd 
	@idUser INT,
	@idWaterIntake INT,
	@year INT,
	@month INT,
	@amount MONEY,
	@observations VARCHAR(2000)

AS

	INSERT INTO [dbo].[payment]
			   ([idWaterIntake]
			   ,[month]
			   ,[year]
			   ,[amount]
			   ,[observations])
		 VALUES
			   (@idWaterIntake
			   ,@month
			   ,@year
			   ,@amount
			   ,@observations)

	DECLARE @id INT= SCOPE_IDENTITY()

	SELECT @id id

	EXEC BinnacleAdd @idUser,'Pago','Payment', @id ,'Insert', NULL, @amount