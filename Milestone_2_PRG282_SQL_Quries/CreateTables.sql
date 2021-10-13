USE Milestone_2_PRG_282

GO

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