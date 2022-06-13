
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/13/2022 20:16:47
-- Generated from EDMX file: C:\Users\Agustin\source\repos\venta\Modelo\Contexto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Ventas];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UsuarioSet'
CREATE TABLE [dbo].[UsuarioSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Dni] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- Creating table 'PerfilSet'
CREATE TABLE [dbo].[PerfilSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FormulariosSet'
CREATE TABLE [dbo].[FormulariosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PermisoSet'
CREATE TABLE [dbo].[PermisoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'FormulariosPerfil'
CREATE TABLE [dbo].[FormulariosPerfil] (
    [Formularios_Id] int  NOT NULL,
    [Perfil_Id] int  NOT NULL
);
GO

-- Creating table 'FormulariosPermiso'
CREATE TABLE [dbo].[FormulariosPermiso] (
    [Formularios_Id] int  NOT NULL,
    [Permiso_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [PK_UsuarioSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PerfilSet'
ALTER TABLE [dbo].[PerfilSet]
ADD CONSTRAINT [PK_PerfilSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FormulariosSet'
ALTER TABLE [dbo].[FormulariosSet]
ADD CONSTRAINT [PK_FormulariosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PermisoSet'
ALTER TABLE [dbo].[PermisoSet]
ADD CONSTRAINT [PK_PermisoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Formularios_Id], [Perfil_Id] in table 'FormulariosPerfil'
ALTER TABLE [dbo].[FormulariosPerfil]
ADD CONSTRAINT [PK_FormulariosPerfil]
    PRIMARY KEY CLUSTERED ([Formularios_Id], [Perfil_Id] ASC);
GO

-- Creating primary key on [Formularios_Id], [Permiso_Id] in table 'FormulariosPermiso'
ALTER TABLE [dbo].[FormulariosPermiso]
ADD CONSTRAINT [PK_FormulariosPermiso]
    PRIMARY KEY CLUSTERED ([Formularios_Id], [Permiso_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Perfil_Id] in table 'UsuarioSet'
ALTER TABLE [dbo].[UsuarioSet]
ADD CONSTRAINT [FK_UsuarioPerfil]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[PerfilSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuarioPerfil'
CREATE INDEX [IX_FK_UsuarioPerfil]
ON [dbo].[UsuarioSet]
    ([Perfil_Id]);
GO

-- Creating foreign key on [Formularios_Id] in table 'FormulariosPerfil'
ALTER TABLE [dbo].[FormulariosPerfil]
ADD CONSTRAINT [FK_FormulariosPerfil_Formularios]
    FOREIGN KEY ([Formularios_Id])
    REFERENCES [dbo].[FormulariosSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Perfil_Id] in table 'FormulariosPerfil'
ALTER TABLE [dbo].[FormulariosPerfil]
ADD CONSTRAINT [FK_FormulariosPerfil_Perfil]
    FOREIGN KEY ([Perfil_Id])
    REFERENCES [dbo].[PerfilSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormulariosPerfil_Perfil'
CREATE INDEX [IX_FK_FormulariosPerfil_Perfil]
ON [dbo].[FormulariosPerfil]
    ([Perfil_Id]);
GO

-- Creating foreign key on [Formularios_Id] in table 'FormulariosPermiso'
ALTER TABLE [dbo].[FormulariosPermiso]
ADD CONSTRAINT [FK_FormulariosPermiso_Formularios]
    FOREIGN KEY ([Formularios_Id])
    REFERENCES [dbo].[FormulariosSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Permiso_Id] in table 'FormulariosPermiso'
ALTER TABLE [dbo].[FormulariosPermiso]
ADD CONSTRAINT [FK_FormulariosPermiso_Permiso]
    FOREIGN KEY ([Permiso_Id])
    REFERENCES [dbo].[PermisoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormulariosPermiso_Permiso'
CREATE INDEX [IX_FK_FormulariosPermiso_Permiso]
ON [dbo].[FormulariosPermiso]
    ([Permiso_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------