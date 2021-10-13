USE Milestone_2_PRG_282

GO

CREATE PROCEDURE spDeleteStudent
(
	@StudId INT
)

AS

BEGIN
	DELETE FROM StudentInfo
	WHERE StudentNumber = @StudId
END

