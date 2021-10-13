USE Milestone_2_PRG_282

GO

CREATE PROCEDURE spSearchStudent
(
	@StudId INT
)

AS
BEGIN
	SELECT * FROM StudentInfo
	WHERE StudentNumber = @StudId
END