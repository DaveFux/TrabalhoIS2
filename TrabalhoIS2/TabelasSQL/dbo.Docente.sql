CREATE TABLE [dbo].[Docente] (
    [Id]                      INT           NOT NULL,
    [Nome]                    VARCHAR (100) NOT NULL,
    [Instituto]               VARCHAR (100) NOT NULL,
    [Categoria]               VARCHAR (100) NOT NULL,
    [Grau]                    VARCHAR (100) NOT NULL,
    [ExperienciaProfissional] VARCHAR (100) NOT NULL,
    [Email] VARCHAR(256) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Disciplina] FOREIGN KEY ([Id]) REFERENCES [dbo].[Disciplina] ([Id]),
    CONSTRAINT [FK_Registo] FOREIGN KEY ([Id]) REFERENCES [dbo].[Registo] ([Id]),
    CONSTRAINT [FK_Atividade] FOREIGN KEY ([Id]) REFERENCES [dbo].[Atividade] ([Id])
);

