CREATE TABLE [dbo].[Certificat]
(
	[QR_Code] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [type] NCHAR(10) NULL, 
    [login_C] INT NULL, 
    CONSTRAINT [FK_Certificat_ToCitoyen] FOREIGN KEY ([login_C]) REFERENCES [dbo].[Citoyen]([login_C])
)
