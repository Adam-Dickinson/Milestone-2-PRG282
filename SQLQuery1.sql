CREATE DATABASE Milestone_2_PRG_282

Create Table StudentInfo(
StudentNum INT,
FirstName VARCHAR(50),
Surname VARCHAR(50),
DOB DATE,
Gender VARCHAR(2),
Phone VARCHAR(10),
StreetAddress VARCHAR(50),
ModuleCode VARCHAR(6)
)

Create Table ModuleInfo(
ModuleCode VARCHAR(6),
ModuleName VARCHAR(50),
ModuleDescription VARCHAR(255),
LinkToOnlineResource VARCHAR(255)
)

// All Student Procedures

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

CREATE PROCEDURE spDeleteStudent
(
	@StudId INT
)

AS

BEGIN
	DELETE FROM StudentInfo
	WHERE StudentNumber = @StudId
END

CREATE PROCEDURE spGetStudents

AS
BEGIN
	SELECT * FROM StudentInfo
END

CREATE PROCEDURE spSearchStudent
(
	@StudId INT
)

AS
BEGIN
	SELECT * FROM StudentInfo
	WHERE StudentNumber = @StudId
END

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

//All Module Procedures

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

CREATE PROCEDURE spDeleteModule
(
	@ModuleId VARCHAR (6)
)

AS
BEGIN

DELETE FROM ModuleInfo
WHERE ModuleCode = @ModuleId

END

CREATE PROCEDURE spGetModule
(
	@ModuleCode VARCHAR (6)
)

AS
BEGIN
	SELECT * FROM ModuleInfo
END

CREATE PROCEDURE spSerachModule
(
	@ModuleCode VARCHAR (6)
)

AS

BEGIN
	SELECT * FROM ModuleInfo
	WHERE ModuleCode = @ModuleCode
END

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
