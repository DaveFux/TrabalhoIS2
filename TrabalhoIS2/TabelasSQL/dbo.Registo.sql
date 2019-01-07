CREATE TABLE [dbo].[Registo]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[CentroInvestigacao] VARCHAR(100) NOT NULL,
	[UnidadeInvestigacao] VARCHAR(100) NOT NULL,
	[Classificacao] VARCHAR(100) NOT NULL,
	[Instituicao] VARCHAR(100) NOT NULL,
	[PercTempo] DECIMAL NOT NULL,
	[Observacoes] VARCHAR(100) NOT NULL,
	[DataInicio] VARCHAR(100) NOT NULL,
	[DataFim] VARCHAR(100) NOT NULL
)
