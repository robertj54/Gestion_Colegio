CREATE TABLE [dbo].[tblCurso_GradoSeccion]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdCurso] INT NOT NULL, 
    [IdGradoSeccion] INT NOT NULL,
    CONSTRAINT [FK_tblCurso_GradoSeccion_tblCurso] FOREIGN KEY([IdCurso]) REFERENCES [dbo].[tblCurso] ([Id]),
    CONSTRAINT [FK_tblCurso_GradoSeccion_tblGradoSeccion] FOREIGN KEY([IdGradoSeccion]) REFERENCES [dbo].[tblGradoSeccion] ([Id])
)