CREATE TABLE [dbo].[Disciplina]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[UnidadeCurricular] VARCHAR(100) NOT NULL,
	[CicloEstudos] VARCHAR(100) NOT NULL,
	[Tipo] VARCHAR(100) NOT NULL,
	[TotalHoras] INT NOT NULL,
	[AnoLetivo] VARCHAR(100) NOT NULL,
	[Semestre] INT NOT NULL
)
