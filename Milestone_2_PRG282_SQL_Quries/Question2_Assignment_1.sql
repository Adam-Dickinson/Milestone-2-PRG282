SET NOCOUNT ON;

DECLARE @pro_Num nvarchar (15), @Pro_Name varchar (30), @message varchar(80),@product varchar (30) ;

DECLARE pro_cursor CURSOR FOR
SELECT ProductNumber, Name
FROM Production.Product
WHERE ProductNumber = 'HL-U509-R'

OPEN pro_cursor

FETCH NEXT FROM pro_cursor
INTO @pro_Num, @Pro_Name

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT ''
	SELECT @message = 'Product Number: ' + @pro_num

	PRINT @message
	
	SELECT @message = 'Product  Name: '+ @Pro_Name

	PRINT @message

	PRINT 'Special Offers:'
	PRINT 'No Discount'
	PRINT 'Volume Discount 11 to 14'
	PRINT 'Volume Discount 15 to 24'
	PRINT 'Sport Helmet Discount-2002'
	PRINT 'Sport Helmet Discount-2003'

END