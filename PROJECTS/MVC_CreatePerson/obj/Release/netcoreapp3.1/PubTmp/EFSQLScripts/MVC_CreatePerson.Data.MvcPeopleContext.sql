IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201008032650_InitialCreate')
BEGIN
    CREATE TABLE [Persons] (
        [Id] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [Gender] nvarchar(max) NULL,
        [Age] int NOT NULL,
        [ReleaseDate] datetime2 NOT NULL,
        CONSTRAINT [PK_Persons] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20201008032650_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20201008032650_InitialCreate', N'3.1.8');
END;

GO

