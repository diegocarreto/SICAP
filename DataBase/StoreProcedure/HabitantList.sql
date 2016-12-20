CREATE PROCEDURE [HabitantList] 
	@type INT = 2,
	@id INT = NULL,
	@find VARCHAR(100) = NULL
AS
	IF @type = 1 
	BEGIN

		SELECT 
			*,
			nombre name
		FROM
			[dbo].[habitant]
		WHERE
			id = COALESCE(@id,id) 
			AND deleted = 0
			AND [active] = 1 
		ORDER BY 
			id ASC

	END
	ELSE IF @type = 2
	BEGIN

		SELECT 
			id,
			nombre name,
			paterno,
			materno,
			COALESCE(observations,'N/A') observations,
			  CASE   
				 WHEN [active] = 1 THEN 'Si'  
				 ELSE 'No'  
			  END aux,
			CONVERT(VARCHAR(10),creationDate, 101) + ' ' + CONVERT(VARCHAR(8), creationDate, 108) aux2
		FROM
			[dbo].[habitant]
		WHERE
			id = COALESCE(@id,id) 
			AND deleted = 0
			AND [active] = 1 
			AND ((nombre LIKE @find + '%'
			OR @find IS NULL) 
			OR (paterno LIKE @find + '%'
			OR @find IS NULL) 
			OR (materno LIKE @find + '%'
			OR @find IS NULL) 
			OR (observations LIKE @find + '%'
			OR @find IS NULL))
		ORDER BY
			nombre

	END
	ELSE IF @type = 3
	BEGIN

		SELECT 
			id,
			nombre + ' ' + paterno + ' ' + materno name
		FROM
			[dbo].[habitant]
		WHERE
			id = COALESCE(@id,id) 
			AND deleted = 0
			AND [active] = 1 
		ORDER BY
			nombre + ' ' + paterno + ' ' + materno

	END
