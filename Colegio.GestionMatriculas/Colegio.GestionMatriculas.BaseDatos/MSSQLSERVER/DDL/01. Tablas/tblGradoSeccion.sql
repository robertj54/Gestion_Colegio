CREATE TABLE [dbo].[tblGradoSeccion]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Grado] VARCHAR(25) NOT NULL, 
    [Nivel] VARCHAR(50) NOT NULL, 
    [Seccion] CHAR(2) NOT NULL,
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATE NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'USUSQL', 
    [FechaModificacion] DATE NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL
)
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha creación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblGradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'FechaCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario creación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblGradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha modificación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblGradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'FechaModificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario modificación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblGradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioModificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Grado de estudio',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblGradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'Grado'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nivel de instruccion',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblGradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'Nivel'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Seccion del grado',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblGradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'Seccion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id del grado seccion',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblGradoSeccion',
    @level2type = N'COLUMN',
    @level2name = N'Id'