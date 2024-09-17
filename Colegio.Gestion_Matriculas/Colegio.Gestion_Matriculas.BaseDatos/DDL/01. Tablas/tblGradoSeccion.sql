CREATE TABLE [dbo].[tblGradoSeccion]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Grado] VARCHAR(25) NOT NULL, 
    [Nivel] VARCHAR(50) NOT NULL, 
    [Seccion] CHAR(2) NOT NULL,
    [FechaCreacion] DATE NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'USUSQL', 
    [FechaModificacion] DATE NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL
)
