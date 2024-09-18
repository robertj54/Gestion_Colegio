CREATE TABLE [dbo].[tblCurso_Docente]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdCurso] INT NULL  FOREIGN KEY([IdCurso]) REFERENCES [dbo].[tblCurso] ([Id]), 
    [IdDocente] INT NULL FOREIGN KEY([IdDocente]) REFERENCES [dbo].[tblDocente] ([Id])
)