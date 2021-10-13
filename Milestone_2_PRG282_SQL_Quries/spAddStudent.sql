USE Milestone_2_PRG_282

GO

CREATE PROCEDURE spAddStudent
(
	@StudId INT,
	@Name VARCHAR(50),
	@Surname VARCHAR(50),
	@DOB DATE,
	@Gender VARCHAR(2),
	@Phone VARCHAR(50),
	@StreetAddress VARCHAR(50),
	@ModuleCode VARCHAR(6)
)

AS

BEGIN

INSERT INTO StudentInfo
VALUES(@StudId, @Name, @Surname, @DOB, @Gender, @Phone, @StreetAddress, @ModuleCode)

END

