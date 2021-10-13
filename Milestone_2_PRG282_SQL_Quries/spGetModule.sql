USE Milestone_2_PRG_282

GO

CREATE PROCEDURE spGetModule
(
	@ModuleCode VARCHAR (6)
)

AS
BEGIN
	SELECT * FROM ModuleInfo
END