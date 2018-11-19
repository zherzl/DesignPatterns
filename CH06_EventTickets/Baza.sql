SET xact_abort on
begin tran

CREATE TABLE [Events]
(
	ID UNIQUEIDENTIFIER PRIMARY KEY,
	[Name] nvarchar(50),
	Allocation INT 
)

CREATE TABLE PurchasedTickets
(
	ID UNIQUEIDENTIFIER Primary Key,
	TicketQuantity Int,
	EventID Uniqueidentifier 
)

CREATE TABLE ReservedTickets
(
	ID Uniqueidentifier Primary Key,
	ExpiryTime Datetime,
	TicketQuantity INT,
	EventID UNIQUEIDENTIFIER,
	HasBeenRedeemed Bit 
)

INSERT INTO EVENTS
(Id, Name, Allocation)
VALUES 
(NEWID(), 'Portsmouth v Southampton', 50)

commit
SET xact_abort off