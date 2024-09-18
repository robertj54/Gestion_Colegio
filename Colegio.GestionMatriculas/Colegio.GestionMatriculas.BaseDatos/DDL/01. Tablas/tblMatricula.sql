CREATE TABLE [dbo].[tblMatricula]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Codigo] NCHAR(10) NULL, 
    [FechaMatricula] NCHAR(10) NULL DEFAULT GETDATE(), 
    [Periodo] NCHAR(10) NULL, 
    [IdAlumno] INT NOT NULL CONSTRAINT [FK_tblMatricula_tblAlumno] FOREIGN KEY([IdAlumno]) REFERENCES [dbo].[tblAlumno] ([Id]), 
    [IdGradoSeccion] INT NOT NULL CONSTRAINT [FK_tblMatricula_tblGradoSeccion] FOREIGN KEY([IdGradoSeccion]) REFERENCES [dbo].[tblGradoSeccion] ([Id]),
    [FechaCreacion] DATE NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'USUSQL', 
    [FechaModificacion] DATE NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL
)