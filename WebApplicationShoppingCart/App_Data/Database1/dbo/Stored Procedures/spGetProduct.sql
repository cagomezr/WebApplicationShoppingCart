CREATE PROCEDURE [dbo].[spGetProduct] 

AS
BEGIN

	SET NOCOUNT ON;
	Select * from Products where Discontinued = 0 order by ProductName ASC
END