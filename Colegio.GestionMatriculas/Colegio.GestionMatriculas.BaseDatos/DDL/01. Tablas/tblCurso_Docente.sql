CREATE TABLE [dbo].[tblCurso_Docente]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdCurso] INT NULL  , 
    [IdDocente] INT NULL ,
    FOREIGN KEY([IdCurso]) REFERENCES [dbo].[tblCurso] ([Id]),
    FOREIGN KEY([IdDocente]) REFERENCES [dbo].[tblDocente] ([Id])
)