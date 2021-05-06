CREATE TABLE [dbo].[Rentals] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [CarId]      INT           NOT NULL,
    [CustomerId] INT           NOT NULL,
    [RentDate]   DATETIME2 (7) NOT NULL,
    [ReturnDate] DATETIME2 (7) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Rentals_Cars] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Cars] ([CarId]),
    CONSTRAINT [FK_Rentals_Customers] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([UserId])
);

