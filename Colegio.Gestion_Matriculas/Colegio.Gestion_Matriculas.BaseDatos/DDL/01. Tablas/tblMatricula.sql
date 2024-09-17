CREATE TABLE [dbo].[tblMatricula]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Codigo] NCHAR(10) NULL, 
    [FechaMatricula] NCHAR(10) NULL DEFAULT GETDATE(), 
    [Periodo] NCHAR(10) NULL, 
    [IdAlumno] NCHAR(10) NOT NULL, 
    [IdGradoSeccion] NCHAR(10) NOT NULL,
    [FechaCreacion] DATE NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'USUSQL', 
    [FechaModificacion] DATE NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL
)
