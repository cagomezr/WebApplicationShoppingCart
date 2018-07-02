CREATE PROCEDURE [dbo].[spAddProductToCart]  
@CartId int = Null ,
@ProductID int = Null,
@quantity int =0
AS	
INSERT INTO [dbo].[CartContents]
           ([CartId]
           ,[ProductID]
           ,[HowMany])
     VALUES
           (@CartId
           ,@ProductID
           ,@quantity)
GO