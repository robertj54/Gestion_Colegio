CREATE TABLE [dbo].[tblDocente]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[DNI] CHAR(8) NOT NULL, 
    [Nombres] VARCHAR(150) NOT NULL, 
    [ApellidoPaterno] VARCHAR(100) NOT NULL, 
    [ApellidoMaterno] VARCHAR(100) NOT NULL, 
    [FechaNacimiento] DATE NOT NULL, 
    [Especialidad] VARCHAR(150) NOT NULL, 
    [FechaCreacion] DATE NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'USUSQL', 
    [FechaModificacion] DATE NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL
)
