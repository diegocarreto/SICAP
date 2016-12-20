CREATE PROCEDURE PaymentDelete
	@idUser INT,
	@id INT
AS
	UPDATE 
		[dbo].[payment]
	SET
		[deleted] = 1,
		[removalDate] = GETDATE()
	WHERE
		id = @id
		
	EXEC BinnacleAdd @idUser,'Baja logica pago','Payment', @id ,'Delete', NULL, NULL