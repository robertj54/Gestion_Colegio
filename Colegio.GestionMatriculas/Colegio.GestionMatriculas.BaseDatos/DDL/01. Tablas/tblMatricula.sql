CREATE TABLE [dbo].[tblMatricula]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Codigo] NCHAR(10) NULL, 
    [FechaMatricula] NCHAR(10) NULL DEFAULT GETDATE(), 
    [Periodo] NCHAR(10) NULL, 
    [IdAlumno] INT NOT NULL, 
    [IdGradoSeccion] INT NOT NULL,
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATE NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'USUSQL', 
    [FechaModificacion] DATE NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL,
    CONSTRAINT [FK_tblMatricula_tblAlumno] FOREIGN KEY([IdAlumno]) REFERENCES [dbo].[tblAlumno] ([Id]),
    CONSTRAINT [FK_tblMatricula_tblGradoSeccion] FOREIGN KEY([IdGradoSeccion]) REFERENCES [dbo].[tblGradoSeccion] ([Id])
)
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha creación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'FechaCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario creación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha modificación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'FechaModificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario modificación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioModificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Codigo de matricula',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'Codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de matricula',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'FechaMatricula'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Periodo de matricula',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'Periodo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id de alumno',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'IdAlumno'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id de grado seccion',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'IdGradoSeccion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id de matricula',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblMatricula',
    @level2type = N'COLUMN',
    @level2name = N'Id'