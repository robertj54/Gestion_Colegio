CREATE TABLE [dbo].[tblCurso]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] NCHAR(10) NULL, 
    [Descripcion] NCHAR(10) NULL, 
    [Vigente] BIT NULL,
    [FechaCreacion] DATE NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'USUSQL', 
    [FechaModificacion] DATE NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL
)
