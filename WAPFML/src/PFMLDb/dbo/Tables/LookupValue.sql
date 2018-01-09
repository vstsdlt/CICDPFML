CREATE TABLE [dbo].[LookupValue] (
    [Name]           VARCHAR (50)  NOT NULL,
    [Code]           VARCHAR (20)  NOT NULL,
    [Property]       VARCHAR (50)  NOT NULL,
    [Value]          VARCHAR (100) NOT NULL,
    [Description]    VARCHAR (500) NULL,
    [CreateUserId]   VARCHAR (50)  NOT NULL,
    [CreateDateTime] DATETIME      NOT NULL,
    [UpdateUserId]   VARCHAR (50)  NOT NULL,
    [UpdateDateTime] DATETIME      NOT NULL,
    CONSTRAINT [PK_LookupData] PRIMARY KEY CLUSTERED ([Name] ASC, [Code] ASC, [Property] ASC),
    CONSTRAINT [FK_LookupData_LookupCode] FOREIGN KEY ([Name], [Code]) REFERENCES [dbo].[LookupCode] ([Name], [Code]),
    CONSTRAINT [FK_LookupData_LookupProperty] FOREIGN KEY ([Name], [Property]) REFERENCES [dbo].[LookupProperty] ([Name], [Property])
);

