EXEC sys.sp_addextendedproperty @name=N'AutoDeployed', @value=N'yes' , @level0type=N'ASSEMBLY',@level0name=N'SqlClassLibrary'
GO
EXEC sys.sp_addextendedproperty @name=N'SqlAssemblyProjectRoot', @value=N'C:\Users\Joan-zhao\Desktop\test\JoanHomeWork\JoanWebAppDb' , @level0type=N'ASSEMBLY',@level0name=N'SqlClassLibrary'