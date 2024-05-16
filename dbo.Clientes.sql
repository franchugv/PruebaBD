CREATE TABLE [dbo].[Clientes] (
    [Nombre] VARCHAR(20) NOT NULL DEFAULT 'DESC', 
    [Apellidos] VARCHAR(50) NOT NULL DEFAULT 'DESC', 
    [Telefono] CHAR(9) NOT NULL DEFAULT '000000000', 
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Nombre], [Apellidos])
);

