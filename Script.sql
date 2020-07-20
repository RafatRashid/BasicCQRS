IF DB_ID('PracticalCQRS') IS NULL BEGIN CREATE DATABASE PracticalCQRS
END
GO
  USE [PracticalCQRS] IF NOT EXISTS (
    SELECT
      *
    FROM
      sys.objects
    WHERE
      object_id = OBJECT_ID(N'dbo.[employee]')
      AND type in (N'U')
  ) BEGIN CREATE TABLE [dbo].[Employee] (
    [Id] [INT] IDENTITY(1, 1) NOT NULL,
    [FirstName] [NVARCHAR] (255) NOT NULL,
    [LastName] [NVARCHAR] (255) NOT NULL,
    [DateOfBirth] [Date] NOT NULL,
    CONSTRAINT PK_User PRIMARY KEY (Id)
  )
END
GO