CREATE PROCEDURE [dbo].[spGetUser]  @UserName nvarchar(50) = ''
AS
SELECT [username]
      ,[Password]
  FROM [dbo].[Users]
  where username=@UserName
GO