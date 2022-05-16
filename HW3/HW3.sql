Use Northwind

Go

--Question 1
Create View view_product_order_Ren as
(
Select p.ProductID, SUM(od.Quantity) [total ordered quantity]
From Products p join [Order Details] od on p.ProductID = od.ProductID
Group By p.ProductID
)

--Question 2
Go
Create Proc sp_product_order_quantity_Ren
@id int
As
Begin
	Select SUM(od.Quantity) [total quantities of order]
	From Products p join [Order Details] od on p.ProductID = od.ProductID
	Where p.ProductID = @id
End
Go

Exec sp_product_order_quantity_Ren 23

--Question 3
Go
Create Proc sp_product_order_city_Ren (@Pname nvarchar(40))
As
Begin
	Declare @id int
	Set @id = (Select p.ProductId From Products p Where p.ProductName = @Pname)
	Select TOP 5 o.ShipCity, SUM(od.Quantity) [total quantity in this city]
	From [Order Details] od join Orders o on od.OrderID = o.OrderID
	Where od.ProductID = @id
	Group By o.ShipCity
	Order By SUM(od.Quantity) DESC
End
Go

Exec sp_product_order_city_Ren 'Chai'

--Question 4
Go
Create Table city_Ren(
Id int,
City varchar(30))
Insert city_Ren values
(1, 'Seattle'),
(2, 'Green Bay')

Create Table people_Ren(
id int,
Name varchar(30),
City int)
Insert people_Ren values
(1, 'Aaron Rodgers', 2),
(2, 'Russell Wilson', 1),
(3, 'Hody Nelson', 2)

Update city_Ren
SET City = 'Madison'
Where City = 'Seattle'

Go

Create View Packers_Ren as
(
Select p.Name
From city_Ren c join people_Ren p on c.Id = p.City
Where c.City = 'Green Bay'
)

Go

Select * From dbo.Packers_Ren

Drop Table people_Ren
Drop Table city_Ren
Drop View Packers_Ren

--Question 5
Go
Create Proc sp_birthday_employees_Ren
As
Begin
	Create Table birthday_employees_Ren(
	Name varchar(30))
	Insert birthday_employees_Ren Select FirstName + ' ' + LastName [Name] 
	From Employees e Where Month(BirthDate) = 2
End
Go

Exec sp_birthday_employees_Ren
Select * From birthday_employees_Ren

Drop Table birthday_employees_Ren

--Question 6
--Use Except to check if two tables have the same data
--(TABLE a EXCEPT TABLE b)
--UNION ALL
--(TABLE b EXCEPT TABLE a)
--If there are no rows returned by the query, then the two tables have the same data.