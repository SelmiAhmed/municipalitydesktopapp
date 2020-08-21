CREATE TABLE [dbo].[AdminCitoyen]
(
	[login_A] INT NOT NULL , 
    [login_C] INT NOT NULL, 
    [date] DATETIME NULL, 
    PRIMARY KEY ([login_A], [login_C]), 
    CONSTRAINT [FK_AdminCitoyen_ToAdministrateur] FOREIGN KEY ([login_A]) REFERENCES [dbo].[Administrateur]([login_A]), 
    CONSTRAINT [FK_AdminCitoyen_ToCitoyen] FOREIGN KEY ([login_C]) REFERENCES [dbo].[Citoyen]([login_C])
)
