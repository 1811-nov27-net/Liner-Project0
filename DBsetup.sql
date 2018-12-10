Create database PizzaStoreApp

create table StoreLocation
(
	LocationID int primary key not null,
);

create table OrderDetails
(
	OrderID int primary key not null,
	LocationID int not null,
	UserID int not null
);

create table Users
(
	UserID int primary key not null,
	FirstName nvarchar(100) not null,
	LastName nvarchar(100) not null
);
