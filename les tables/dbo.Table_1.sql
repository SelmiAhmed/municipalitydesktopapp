CREATE TABLE [dbo].[Citoyen]
(
	[login_C] INT NOT NULL PRIMARY KEY, 
    [password_C] VARCHAR(50) NULL, 
    [code] INT NULL, 
    [nom] VARCHAR(50) NULL, 
    [prenom] VARCHAR(50) NULL, 
    [date de naissance] DATETIME NULL, 
    [adresse email] VARCHAR(50) NULL, 
    [photo_C] VARCHAR(50) NULL
)
