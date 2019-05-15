
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2019 07:25:44
-- Generated from EDMX file: C:\Users\Alejandro Narvaez\source\repos\Biblioteca\Biblioteca\Modelo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [biblio];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsuarioReserva]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservas] DROP CONSTRAINT [FK_UsuarioReserva];
GO
IF OBJECT_ID(N'[dbo].[FK_UsuarioPrestamo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Prestamos] DROP CONSTRAINT [FK_UsuarioPrestamo];
GO
IF OBJECT_ID(N'[dbo].[FK_PrestamoDetalle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Detalles] DROP CONSTRAINT [FK_PrestamoDetalle];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentoReserva]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservas] DROP CONSTRAINT [FK_DocumentoReserva];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentoEjemplar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Ejemplares] DROP CONSTRAINT [FK_DocumentoEjemplar];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaDocumento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Documentos] DROP CONSTRAINT [FK_CategoriaDocumento];
GO
IF OBJECT_ID(N'[dbo].[FK_DocumentoAutoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autorias] DROP CONSTRAINT [FK_DocumentoAutoria];
GO
IF OBJECT_ID(N'[dbo].[FK_AutorAutoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Autorias] DROP CONSTRAINT [FK_AutorAutoria];
GO
IF OBJECT_ID(N'[dbo].[FK_EjemplarDetalle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Detalles] DROP CONSTRAINT [FK_EjemplarDetalle];
GO
IF OBJECT_ID(N'[dbo].[FK_MultaDetalle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Multas] DROP CONSTRAINT [FK_MultaDetalle];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO
IF OBJECT_ID(N'[dbo].[Reservas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservas];
GO
IF OBJECT_ID(N'[dbo].[Documentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Documentos];
GO
IF OBJECT_ID(N'[dbo].[Ejemplares]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ejemplares];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[Detalles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Detalles];
GO
IF OBJECT_ID(N'[dbo].[Prestamos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prestamos];
GO
IF OBJECT_ID(N'[dbo].[Multas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Multas];
GO
IF OBJECT_ID(N'[dbo].[Autores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autores];
GO
IF OBJECT_ID(N'[dbo].[Autorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autorias];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int  NOT NULL,
    [Plan] nvarchar(40)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'Reservas'
CREATE TABLE [dbo].[Reservas] (
    [UsuarioId] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Posicion] int  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [DocumentoIndex] int  NOT NULL
);
GO

-- Creating table 'Documentos'
CREATE TABLE [dbo].[Documentos] (
    [Index] int  NOT NULL,
    [Titulo] nvarchar(40)  NOT NULL,
    [Tipo] nvarchar(40)  NOT NULL,
    [CategoriaId] int  NOT NULL
);
GO

-- Creating table 'Ejemplares'
CREATE TABLE [dbo].[Ejemplares] (
    [CodBarras] int  NOT NULL,
    [Numero] int  NOT NULL,
    [Estado] nvarchar(max)  NOT NULL,
    [DocumentoIndex] int  NOT NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [Id] int  NOT NULL,
    [Nombre] nvarchar(30)  NOT NULL,
    [DiasPrestamo] int  NOT NULL,
    [MultaDia] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Detalles'
CREATE TABLE [dbo].[Detalles] (
    [FechaDev] datetime  NULL,
    [PrestamoId] int  NOT NULL,
    [EjemplarCodBarras] int  NOT NULL
);
GO

-- Creating table 'Prestamos'
CREATE TABLE [dbo].[Prestamos] (
    [Id] int  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [UsuarioId] int  NOT NULL
);
GO

-- Creating table 'Multas'
CREATE TABLE [dbo].[Multas] (
    [Id] int  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [FechaCanc] datetime  NULL,
    [Detalle_PrestamoId] int  NOT NULL,
    [Detalle_EjemplarCodBarras] int  NOT NULL
);
GO

-- Creating table 'Autores'
CREATE TABLE [dbo].[Autores] (
    [Id] int  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Autorias'
CREATE TABLE [dbo].[Autorias] (
    [Rol] nvarchar(max)  NOT NULL,
    [DocumentoIndex] int  NOT NULL,
    [AutorId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UsuarioId], [Fecha], [DocumentoIndex] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [PK_Reservas]
    PRIMARY KEY CLUSTERED ([UsuarioId], [Fecha], [DocumentoIndex] ASC);
GO

-- Creating primary key on [Index] in table 'Documentos'
ALTER TABLE [dbo].[Documentos]
ADD CONSTRAINT [PK_Documentos]
    PRIMARY KEY CLUSTERED ([Index] ASC);
GO

-- Creating primary key on [CodBarras] in table 'Ejemplares'
ALTER TABLE [dbo].[Ejemplares]
ADD CONSTRAINT [PK_Ejemplares]
    PRIMARY KEY CLUSTERED ([CodBarras] ASC);
GO

-- Creating primary key on [Id] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [PrestamoId], [EjemplarCodBarras] in table 'Detalles'
ALTER TABLE [dbo].[Detalles]
ADD CONSTRAINT [PK_Detalles]
    PRIMARY KEY CLUSTERED ([PrestamoId], [EjemplarCodBarras] ASC);
GO

-- Creating primary key on [Id] in table 'Prestamos'
ALTER TABLE [dbo].[Prestamos]
ADD CONSTRAINT [PK_Prestamos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Multas'
ALTER TABLE [dbo].[Multas]
ADD CONSTRAINT [PK_Multas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Autores'
ALTER TABLE [dbo].[Autores]
ADD CONSTRAINT [PK_Autores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [AutorId], [DocumentoIndex] in table 'Autorias'
ALTER TABLE [dbo].[Autorias]
ADD CONSTRAINT [PK_Autorias]
    PRIMARY KEY CLUSTERED ([AutorId], [DocumentoIndex] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UsuarioId] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [FK_UsuarioReserva]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [UsuarioId] in table 'Prestamos'
ALTER TABLE [dbo].[Prestamos]
ADD CONSTRAINT [FK_UsuarioPrestamo]
    FOREIGN KEY ([UsuarioId])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPrestamo'
CREATE INDEX [IX_FK_UsuarioPrestamo]
ON [dbo].[Prestamos]
    ([UsuarioId]);
GO

-- Creating foreign key on [PrestamoId] in table 'Detalles'
ALTER TABLE [dbo].[Detalles]
ADD CONSTRAINT [FK_PrestamoDetalle]
    FOREIGN KEY ([PrestamoId])
    REFERENCES [dbo].[Prestamos]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DocumentoIndex] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [FK_DocumentoReserva]
    FOREIGN KEY ([DocumentoIndex])
    REFERENCES [dbo].[Documentos]
        ([Index])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentoReserva'
CREATE INDEX [IX_FK_DocumentoReserva]
ON [dbo].[Reservas]
    ([DocumentoIndex]);
GO

-- Creating foreign key on [DocumentoIndex] in table 'Ejemplares'
ALTER TABLE [dbo].[Ejemplares]
ADD CONSTRAINT [FK_DocumentoEjemplar]
    FOREIGN KEY ([DocumentoIndex])
    REFERENCES [dbo].[Documentos]
        ([Index])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentoEjemplar'
CREATE INDEX [IX_FK_DocumentoEjemplar]
ON [dbo].[Ejemplares]
    ([DocumentoIndex]);
GO

-- Creating foreign key on [CategoriaId] in table 'Documentos'
ALTER TABLE [dbo].[Documentos]
ADD CONSTRAINT [FK_CategoriaDocumento]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categorias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaDocumento'
CREATE INDEX [IX_FK_CategoriaDocumento]
ON [dbo].[Documentos]
    ([CategoriaId]);
GO

-- Creating foreign key on [DocumentoIndex] in table 'Autorias'
ALTER TABLE [dbo].[Autorias]
ADD CONSTRAINT [FK_DocumentoAutoria]
    FOREIGN KEY ([DocumentoIndex])
    REFERENCES [dbo].[Documentos]
        ([Index])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DocumentoAutoria'
CREATE INDEX [IX_FK_DocumentoAutoria]
ON [dbo].[Autorias]
    ([DocumentoIndex]);
GO

-- Creating foreign key on [AutorId] in table 'Autorias'
ALTER TABLE [dbo].[Autorias]
ADD CONSTRAINT [FK_AutorAutoria]
    FOREIGN KEY ([AutorId])
    REFERENCES [dbo].[Autores]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [EjemplarCodBarras] in table 'Detalles'
ALTER TABLE [dbo].[Detalles]
ADD CONSTRAINT [FK_EjemplarDetalle]
    FOREIGN KEY ([EjemplarCodBarras])
    REFERENCES [dbo].[Ejemplares]
        ([CodBarras])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EjemplarDetalle'
CREATE INDEX [IX_FK_EjemplarDetalle]
ON [dbo].[Detalles]
    ([EjemplarCodBarras]);
GO

-- Creating foreign key on [Detalle_PrestamoId], [Detalle_EjemplarCodBarras] in table 'Multas'
ALTER TABLE [dbo].[Multas]
ADD CONSTRAINT [FK_MultaDetalle]
    FOREIGN KEY ([Detalle_PrestamoId], [Detalle_EjemplarCodBarras])
    REFERENCES [dbo].[Detalles]
        ([PrestamoId], [EjemplarCodBarras])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MultaDetalle'
CREATE INDEX [IX_FK_MultaDetalle]
ON [dbo].[Multas]
    ([Detalle_PrestamoId], [Detalle_EjemplarCodBarras]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------