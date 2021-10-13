USE Milestone_2_PRG_282
GO

CREATE PROCEDURE spDeleteModule
(
	@ModuleId VARCHAR (6)
)

AS
BEGIN

DELETE FROM ModuleInfo
WHERE ModuleCode = @ModuleId

END