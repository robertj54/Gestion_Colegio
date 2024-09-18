CREATE TABLE [dbo].[tblCurso]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] VARCHAR(100) NOT NULL, 
    [Descripcion] VARCHAR(200) NULL, 
    [Nivel] VARCHAR(50) NOT NULL, 
    [Vigente] BIT NULL DEFAULT 1,
    [FechaCreacion] DATE NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'USUSQL', 
    [FechaModificacion] DATE NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL
)
