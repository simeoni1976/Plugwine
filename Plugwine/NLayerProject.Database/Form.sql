CREATE TABLE [dbo].[Form]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FormTypeId] INT NOT NULL, 
    [FormName] NVARCHAR(50) NULL, 
    [Area] NUMERIC NULL
)
