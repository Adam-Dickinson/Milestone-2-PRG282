USE Milestone_2_PRG_282

GO

CREATE PROCEDURE spUpdateModule
(
	@ModuleCode VARCHAR(6),
	@ModuleName VARCHAR(50),
	@ModuleDescription VARCHAR(255),
	@Link VARCHAR (255)
)

AS

BEGIN

	UPDATE ModuleInfo
	SET ModuleCode = @ModuleCode, ModuleName = @ModuleName, ModuleDescription = @ModuleDescription, LinkToOnlineResource = @Link
	WHERE ModuleCode = @ModuleCode

END