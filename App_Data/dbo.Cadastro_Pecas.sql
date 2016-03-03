CREATE TABLE [dbo].[Cadastro_Pecas] (
    [id]                    INT        IDENTITY (1, 1) NOT NULL,
    [tipo]                  NCHAR (20) NOT NULL,
    [marca]                 NCHAR (20) NOT NULL,
    [modelo]                NCHAR (20) NOT NULL,
    [peso]                  FLOAT (53) NOT NULL,
    [dimensao_largura]      FLOAT (53) NOT NULL,
    [dimensao_altura]       FLOAT (53) NOT NULL,
    [dimensao_profundidade] FLOAT (53) NOT NULL,
    [memoria]               NCHAR (20) NOT NULL,
    [ano_fabricacao]        INT        NOT NULL,
    [diponibilidade_venda]  BIT        NOT NULL,
    [diponibilidade_visual] BIT        NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

