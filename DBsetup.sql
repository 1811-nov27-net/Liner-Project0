Create database PizzaStoreApp

--drop table Store
create table Store
(
	LocationID int primary key not null,
	Stock int not null
);

--drop table OrderDetails
create table OrderDetails
(
	OrderID int primary key identity not null,
	Pizzas int not null,
	LocationID int not null,
	UserID int not null,
	Price decimal(8,2) not null,
	DatePlaced datetime not null,
	foreign key (LocationID) references Store(LocationID),
	foreign key (UserID) references Users(UserID)
);

--drop table Users
create table Users
(
	UserID int primary key not null,
	FirstName nvarchar(100) not null,
	LastName nvarchar(100) not null,
	DefaultLocation int not null
);
