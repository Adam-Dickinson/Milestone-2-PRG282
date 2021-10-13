USE Milestone_2_PRG_282

GO

CREATE PROCEDURE spUpdateStudent
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
	UPDATE StudentInfo
	SET StudentNumber = @StudId, FirstName = @Name, Surname = @Surname, DOB = @DOB, Gender = @Gender, PhoneNumber = @Phone, StreetAddress = @StreetAddress, ModuleCode = @ModuleCode
	WHERE StudentNumber = @StudId
END