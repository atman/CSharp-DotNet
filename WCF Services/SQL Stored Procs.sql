---------------------insertData Stored Proc---------------

USE [Training2014]
GO
/****** Object:  StoredProcedure [dbo].[InsertData]    Script Date: 07/25/2014 19:36:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[InsertData] 
@empId int,
@empName varchar(35),
@departmentNo int,
@age int
OUTPUT 
AS 
BEGIN 
	INSERT INTO atman50 VALUES(@empId, @empName, @departmentNo, @age) 
END

select * from atman50;

-------------------deleteRecord Stored Proc------------------

USE [Training2014]
GO
/****** Object:  StoredProcedure [dbo].[deleteRecord]    Script Date: 07/25/2014 19:39:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 ALTER PROCEDURE [dbo].[deleteRecord]
    @empId int
    AS
 DELETE FROM atman50
 WHERE empId=@empId
 
-------------------updateData Stored Proc-----------------------

USE [Training2014]
GO
/****** Object:  StoredProcedure [dbo].[updateData]    Script Date: 07/25/2014 19:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[updateData]
    @empId int,
    @empName varchar(40),
    @departmentNo int,
    @age int
    AS
UPDATE atman50
   SET  empName = @empName,
        departmentNo = @departmentNo,
        age = @age
 WHERE empId=@empId
 
 select * from atman50;

 