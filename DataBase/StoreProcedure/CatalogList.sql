CREATE PROC CatalogList
	@type VARCHAR(50)
AS
	SELECT 
		id,
		name 
	FROM	
		[catalog] 
	WHERE 
		deleted = 0 
		AND [type] = @type
	ORDER BY 
		name ASC