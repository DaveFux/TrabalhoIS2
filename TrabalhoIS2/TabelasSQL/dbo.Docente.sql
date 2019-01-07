CREATE TABLE [dbo].[Docente]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Nome] VARCHAR(100) NOT NULL,
	[Instituto] VARCHAR(100) NOT NULL,
	[Categoria] VARCHAR(100) NOT NULL,
	[Grau] VARCHAR(100) NOT NULL,
	[ExperienciaProfissional] VARCHAR(100) NOT NULL,
	CONSTRAINT [FK_Disciplina] FOREIGN KEY ([Id]) REFERENCES [dbo].[Disciplina],
	CONSTRAINT [FK_Registo] FOREIGN KEY ([Id]) REFERENCES [dbo].[Registo],
	CONSTRAINT [FK_Atividade] FOREIGN KEY ([Id]) REFERENCES [dbo].[Atividade]

)
