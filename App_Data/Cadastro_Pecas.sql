CREATE TABLE [dbo].[Cadastro_Pecas]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [tipo] NCHAR(20) NOT NULL, 
    [marca] NCHAR(20) NOT NULL, 
    [modelo] NCHAR(20) NOT NULL, 
    [peso] FLOAT NOT NULL, 
    [dimensao_largura] FLOAT NOT NULL, 
    [dimensao_altura] FLOAT NOT NULL, 
    [dimensao_profundidade] FLOAT NOT NULL, 
    [memoria] NCHAR(20) NOT NULL, 
    [ano_fabricacao] INT NOT NULL, 
    [diponibilidade_venda] BIT NOT NULL, 
    [diponibilidade_visual] BIT NOT NULL
)
