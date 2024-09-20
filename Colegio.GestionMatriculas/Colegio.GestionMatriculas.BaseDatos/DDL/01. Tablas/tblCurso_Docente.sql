CREATE TABLE [dbo].[tblCurso_Docente]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdCurso] INT NULL  , 
    [IdDocente] INT NULL ,
    [Estado] BIT NOT NULL DEFAULT 1, 
    FOREIGN KEY([IdCurso]) REFERENCES [dbo].[tblCurso] ([Id]),
    FOREIGN KEY([IdDocente]) REFERENCES [dbo].[tblDocente] ([Id])
)
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id de curso',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblCurso_Docente',
    @level2type = N'COLUMN',
    @level2name = N'IdCurso'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id de docente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblCurso_Docente',
    @level2type = N'COLUMN',
    @level2name = N'IdDocente'