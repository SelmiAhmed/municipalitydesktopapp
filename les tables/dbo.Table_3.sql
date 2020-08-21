CREATE TABLE [dbo].[Reclamation]
(
	[code_R] INT NOT NULL PRIMARY KEY, 
    [details] VARCHAR(50) NULL, 
    [pieces jointes] VARCHAR(50) NULL, 
    [login_C] INT NULL, 
    CONSTRAINT [FK_Reclamation_ToCitoyen] FOREIGN KEY ([login_C]) REFERENCES [dbo].[Citoyen]([login_C])
)
