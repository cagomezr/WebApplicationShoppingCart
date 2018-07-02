CREATE PROCEDURE [dbo].[spPaidCart]  
@CartId int = Null 

AS	
UPDATE  [dbo].[Cart]
SET  Paid = 1
WHERE CartID = @CartId
           
GO
