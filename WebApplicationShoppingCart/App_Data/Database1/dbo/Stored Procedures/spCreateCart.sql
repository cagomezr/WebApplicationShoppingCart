CREATE PROCEDURE [dbo].[spCreateCart]  @UserId int = '0'
AS
INSERT INTO [dbo].[Cart]
           ([UserID])
     VALUES
           (@UserId)
GO