IF EXISTS(SELECT 1
          FROM   INFORMATION_SCHEMA.COLUMNS
          WHERE  TABLE_NAME = 'fd'
                 AND COLUMN_NAME = 'ref') 
BEGIN
	alter table fd
	alter column ref Varchar(20)
END                 
GO
