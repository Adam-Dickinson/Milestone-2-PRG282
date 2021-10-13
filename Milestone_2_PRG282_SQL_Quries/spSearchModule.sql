USE Milestone_2_PRG_282

GO

CREATE PROCEDURE spSerachModule
(
	@ModuleCode VARCHAR (6)
)

AS

BEGIN
	SELECT * FROM ModuleInfo
	WHERE ModuleCode = @ModuleCode
END