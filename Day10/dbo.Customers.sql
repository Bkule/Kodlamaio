CREATE TABLE [dbo].[Customers] (
    [UserId]      INT            NOT NULL,
    [CompanyName] NVARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Customers_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([Id])
);

