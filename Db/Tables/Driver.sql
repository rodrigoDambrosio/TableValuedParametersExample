﻿CREATE TABLE [dbo].[Driver]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [FirstName] NVARCHAR(50) NOT NULL,
    [LastName] NVARCHAR(50) NOT NULL,
    [Number] int NOT NULL,
    [PhotoPath] NVARCHAR(260) NOT NULL,
    [Wins] int NOT NULL
)
