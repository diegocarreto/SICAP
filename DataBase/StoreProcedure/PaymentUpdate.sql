CREATE PROCEDURE PaymentUpdate
	@idUser INT,
	@id INT,
	@year INT,
	@month INT,
	@amount MONEY,
	@observations VARCHAR(2000) = NULL
AS
	DECLARE @previousValue VARCHAR(4000) = (SELECT 'Año: ' + CONVERT(VARCHAR(4),[year]) + ' Mes: ' + CONVERT(VARCHAR(2),[month]) + ' Cantidad:' + CONVERT(VARCHAR(10),[amount]) + ' Observaciones:' + ISNULL([observations],'') FROM [dbo].[payment] WHERE id = @id)

	UPDATE 
		[dbo].[payment]
	SET
		[year] = @year,
		[month] = @month,
		[amount] = @amount,
		[observations] = @observations,
		[updateDate] = GETDATE()
	WHERE
		id = @id

	DECLARE @currentValue VARCHAR(4000) = (SELECT 'Año: ' + CONVERT(VARCHAR(4),[year]) + ' Mes: ' + CONVERT(VARCHAR(2),[month]) + ' Cantidad:' + CONVERT(VARCHAR(10),[amount]) + ' Observaciones:' + ISNULL([observations],'') FROM [dbo].[payment] WHERE id = @id)
	
	EXEC BinnacleAdd @idUser,'Actualización pago','Payment', @id ,'Update', @previousValue, @currentValue