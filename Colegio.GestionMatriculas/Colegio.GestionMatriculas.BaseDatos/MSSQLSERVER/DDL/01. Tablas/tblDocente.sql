CREATE TABLE [dbo].[tblDocente]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[DNI] CHAR(8) NOT NULL, 
    [Nombres] VARCHAR(150) NOT NULL, 
    [ApellidoPaterno] VARCHAR(100) NOT NULL, 
    [ApellidoMaterno] VARCHAR(100) NOT NULL, 
    [FechaNacimiento] DATE NOT NULL,
    [Genero] CHAR(1) NOT NULL,
    [Especialidad] VARCHAR(150) NOT NULL, 
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
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'FechaCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario creación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha modificación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'FechaModificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario modificación registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioModificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'nro de dni docente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'DNI'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'nombres del docente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'Nombres'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Apellido paterno del docente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'ApellidoPaterno'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Apellido materno del docente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'ApellidoMaterno'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de nacimiento del docente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'FechaNacimiento'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Genero del docente -F:Femenino / M:Masculino',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'Genero'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Especialidad del docente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'Especialidad'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Id del docente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'tblDocente',
    @level2type = N'COLUMN',
    @level2name = N'Id'