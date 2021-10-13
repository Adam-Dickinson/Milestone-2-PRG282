USE Milestone_2_PRG_282

GO

CREATE PROCEDURE spAddModule
(
	@ModuleCode VARCHAR(6),
	@ModuleName VARCHAR(50),
	@ModuleDescription VARCHAR(255),
	@Link VARCHAR (255)
)

AS

BEGIN
INSERT INTO ModuleInfo
VALUES (@ModuleCode, @ModuleName, @ModuleDescription, @Link)
END