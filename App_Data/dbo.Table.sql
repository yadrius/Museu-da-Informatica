CREATE TABLE [dbo].[Cadastro_ADM]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nome] NCHAR(50) NOT NULL, 
    [email] NCHAR(50) NOT NULL, 
    [usuario] NCHAR(20) NOT NULL, 
    [senha] CHAR(20) NOT NULL
)
