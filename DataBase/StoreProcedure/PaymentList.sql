CREATE PROC PaymentList
	@nameHabitant VARCHAR(200) = NULL,
	@idWaterIntake INT = NULL,
	@month INT = NULL,
	@year  INT = NULL
AS
	SELECT 
		p.id,
		h.id idHabitant,
		h.nombre + ' ' + h.paterno + ' ' + h.paterno nombre,
		p.[year],
		p.amount,
		p.observations,
		ISNULL(p.updateDate, p.creationDate) [date],
		p.creationDate
	FROM 
		Payment p 
		INNER JOIN habitant h ON h.id = p.idWaterIntake  
	WHERE 
		p.deleted = 0
		AND h.deleted = 0
		AND h.active = 1
		AND (p.idWaterIntake  = @idWaterIntake 
		OR @idWaterIntake IS NULL)
		AND (p.[month] = @month 
		OR @month IS NULL)
		AND (p.[year] = @year 
		OR @year IS NULL)
		AND ((h.nombre + ' ' + h.paterno + ' ' + h.paterno) LIKE '' + @nameHabitant + '%'
		OR @nameHabitant IS NULL)
