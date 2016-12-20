CREATE PROC PaymentTotalByPeriod 
	@type INT,
	@startDate DATE = NULL,
	@endDate DATE = NULL,
	@month INT = NULL,
	@year INT = NULL
AS
	
	IF @type = 1
	BEGIN
		SELECT 
			--SUM(amount) total 
			*
		FROM
			Payment 
		WHERE
			deleted = 0
			AND creationDate BETWEEN CONVERT(VARCHAR(10),@startDate) +  ' 00:00:00' 
			AND CONVERT(VARCHAR(10),@endDate) + ' 23:59:59'
	END 
	ELSE IF @type = 2
	BEGIN
		SELECT 
			--SUM(amount) total 
			*
		FROM
			Payment 
		WHERE
			deleted = 0
			AND [year] = @year
			AND [month] = @month
	END