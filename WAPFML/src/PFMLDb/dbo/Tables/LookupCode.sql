CREATE TABLE [dbo].[LookupCode] (
    [Name]           VARCHAR (50)  NOT NULL,
    [Code]           VARCHAR (20)  NOT NULL,
    [Display]        VARCHAR (50)  NOT NULL,
    [Description]    VARCHAR (500) NULL,
    [CreateUserId]   VARCHAR (50)  NOT NULL,
    [CreateDateTime] DATETIME      NOT NULL,
    [UpdateUserId]   VARCHAR (50)  NOT NULL,
    [UpdateDateTime] DATETIME      NOT NULL,
    CONSTRAINT [PK_LookupCode] PRIMARY KEY CLUSTERED ([Name] ASC, [Code] ASC),
    CONSTRAINT [FK_Lookup_LookupCode] FOREIGN KEY ([Name]) REFERENCES [dbo].[LookupName] ([Name])
);

