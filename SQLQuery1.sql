use [MileStone database];
Go
Create procedure [AddStudent]
@StudentNum integer,
@Name varchar(50),
@Surname varchar(50),
@DOB date,
@Gender varchar(2),
@Phone varchar(50),
@StreetAddress varchar(50),
@ModuleCode varchar(6)
as
Insert INTO StudentInfo (StudentNum, Name, Surname, DOB, Gender, Phone, StreetAddress, ModuleCode) Values
(@StudentNum, @Name, @Surname, @DOB, @Gender, @Phone, @StreetAddress, @ModuleCode);
Select * From StudentInfo;
Go


Go
Create procedure [Display]
as


Select * From StudentInfo;


Go

Go
Create procedure [DeleteStudent]
@StudentNum integer,

as

Delete (StudentNum, Name, Surname, StudentImage, DOB, Gender, Phone, StreetAddress, ModuleCode) From [StudentInfo] Where StudentNum = @StudentNum;
Select * From StudentInfo;

Go

Go
Create Procedure [UpdateStudent]
@StudentNum integer,
@Name varchar(50),
@Surname varchar(50),
@image image,
@DOB date,
@Gender varchar(2),
@Phone varchar(50),
@StreetAddress varchar(50),
@ModuleCode varchar(6)
as
Update [StudentInfo] set StudentNum = @StudentNum, Name = @Name, Surname = @Surname, StudentImage = @image, DOB = @DOB, Gender = @Gender, Phone = @Phone, StreetAddress = @StreetAddress, ModuleCode = @ModuleCode
Where StudentNum = @StudentNum;
Select * From [StudentInfo];

Go

Go
Create procedure [SearchStudent]
@StudentNum integer
as
Select * From StudentInfo Where StudentNum = @StudentNum;
Go

Go
Create procedure [FilterStudents]
@ModuleCode varchar(6)
as
Select * from StudentInfo Where ModuleCode = @ModuleCode Order By DESC;
Go

Go
Create procedure [GroupStudents]
as
Select Count(StudentNum), ModuleCode From StudentInfo Group By [ModuleCode];
Go