Use AdventureWorks2019

Go

--Question 1
Select c.Name As Country, s.Name As Province
From Person.CountryRegion c join Person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode

--Question 2
Select c.Name As Country, s.Name As Province
From Person.CountryRegion c join Person.StateProvince s on c.CountryRegionCode = s.CountryRegionCode
Where c.Name In ('Germany', 'Canada')


Use Northwind

Go

--Question 3
Select distinct p.ProductName
From Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID
Where o.OrderDate > DATEADD(year, -25, '2022/05/11')

Select pp.ProductName
From Products pp
Where pp.ProductName in (Select p.ProductName
From Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID
Where o.OrderDate > DATEADD(year, -25, '2022/05/11'))

--Question 4
Select Top 5 ShipPostalCode, COUNT(o.OrderID) [Num of Orders]
From Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID
Where o.OrderDate > DATEADD(year, -25, '2022/05/11')
Group By ShipPostalCode
Order By [Num of Orders] DESC

--Question 5
Select c.City, COUNT(c.CustomerID)
From Customers c
Group By c.City

--Question 6
Select c.City, COUNT(c.CustomerID)
From Customers c
Group By c.City
Having COUNT(c.CustomerID) > 2

--Question 7
Select c.ContactName, SUM(od.Quantity) [Count of products]
From Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID
Group By c.ContactName
Order By c.ContactName

--Question 8
Select c.CustomerID, SUM(od.Quantity) [Count of products]
From Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID
Group By c.CustomerID
Having SUM(od.Quantity) > 100

--Question 9
Select Distinct su.CompanyName, sh.CompanyName
From Suppliers su join Products p on su.SupplierID = p.SupplierID join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID join Shippers sh on o.ShipVia = sh.ShipperID
Order By su.CompanyName

--Question 10
Select o.OrderDate, p.ProductName
From Products p join [Order Details] od on p.ProductID = od.ProductID join Orders o on od.OrderID = o.OrderID
Order By o.OrderDate

--Question 11
Select e1.FirstName + ' ' + e1.LastName As [Employee Name 1], e2.FirstName + ' ' + e2.LastName [Employee Name 2]
From Employees e1 join Employees e2 on e1.Title = e2.title
Where e1.FirstName + ' ' + e1.LastName < e2.FirstName + ' ' + e2.LastName
Order By e1.FirstName + ' ' + e1.LastName

-- Question 12
With [Busy Managers] As
(Select m.FirstName + ' ' + m.LastName As [FullName], COUNT(m.FirstName + ' ' + m.LastName) As [Reporters]
From Employees m join Employees e on m.EmployeeID = e.ReportsTo
Group By m.FirstName + ' ' + m.LastName
Having COUNT(m.EmployeeID) > 2)
Select bm.FullName
From [Busy Managers] bm

--Question 13
Select c.City, c.CompanyName, c.ContactName, 'Customer' As Type
From Customers c
Union
Select s.City, s.CompanyName, s.ContactName, 'Supplier'
From Suppliers s

--Question 14
