Create PROCEDURE [dbo].[spGetCart]  @Cart int = NULL
AS
SELECT c.CartID, c.HowMany,  p.ProductName , p.UnitPrice
FROM Products p Join CartContents c on  c.productId = p.ProductID
WHERE c.CartID = @Cart
GO
