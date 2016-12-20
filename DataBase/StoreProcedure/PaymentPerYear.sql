CREATE PROC PaymentPerYear 
	@idWaterIntake INT,
	@year INT
AS

	DECLARE @m1  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 1  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m2  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 2  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m3  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 3  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m4  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 4  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m5  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 5  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m6  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 6  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m7  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 7  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m8  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 8  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m9  MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 9  AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m10 MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 10 AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m11 MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 11 AND [year] = @year AND idWaterIntake = @idWaterIntake)
	DECLARE @m12 MONEY = (SELECT amount FROM Payment WHERE deleted = 0 AND [month] = 12 AND [year] = @year AND idWaterIntake = @idWaterIntake)

	SELECT
		ISNULL(@m1, 0) Enero,
		ISNULL(@m2, 0) Febrero,
		ISNULL(@m3, 0) Marzo,
		ISNULL(@m4, 0) Abril,
		ISNULL(@m5, 0) Mayo,
		ISNULL(@m6, 0) Junio,
		ISNULL(@m7, 0) Julio,
		ISNULL(@m8, 0) Agosto,
		ISNULL(@m9, 0) Septiembre,
		ISNULL(@m10,0) Octubre,
		ISNULL(@m11,0) Noviembre,
		ISNULL(@m12,0) Diciembre
