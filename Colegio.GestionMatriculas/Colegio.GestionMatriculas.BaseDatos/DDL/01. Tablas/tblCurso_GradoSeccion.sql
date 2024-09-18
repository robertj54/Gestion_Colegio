CREATE TABLE [dbo].[tblCurso_GradoSeccion]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdCurso] INT NOT NULL, 
    [IdGradoSeccion] INT NOT NULL,
    CONSTRAINT [FK_tblCurso_GradoSeccion_tblCurso] FOREIGN KEY([IdCurso]) REFERENCES [dbo].[tblCurso] ([Id]),
    CONSTRAINT [FK_tblCurso_GradoSeccion_tblGradoSeccion] FOREIGN KEY([IdGradoSeccion]) REFERENCES [dbo].[tblGradoSeccion] ([Id])
)
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id de curso',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblCurso_GradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'IdCurso'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id de grado seccion',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblCurso_GradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'IdGradoSeccion'