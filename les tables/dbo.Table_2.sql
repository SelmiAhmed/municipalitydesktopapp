CREATE TABLE [dbo].[Adresse]
(
	[numero] INT NOT NULL PRIMARY KEY, 
    [rue] VARCHAR(50) NULL, 
    [zone] NCHAR(10) NULL, 
    [login_C] INT NULL, 
    CONSTRAINT [FK_Adresse_ToCitoyen] FOREIGN KEY ([login_C]) REFERENCES [dbo].[Citoyen]([login_C])
)
