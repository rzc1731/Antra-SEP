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
Select Distinct e.City
From Employees e
Where e.City In (Select Distinct c.City From Customers c)

--Question 15a
Select Distinct c.City
From Customers c
Where c.City Not In (Select Distinct e.City From Employees e)

--Question 15b
Select Distinct c.City
From Customers c
Except
Select Distinct e.City
From Employees e

--Question 16
Select p.ProductName, SUM(od.Quantity) As [Total Order Quantities]
From Products p join [Order Details] od on p.ProductID = od.ProductID
Group By p.ProductName

--Question 17a
Select c.City
From Customers c
Except
(Select c.City
From Customers c
Group By c.City
Having COUNT(c.CustomerID) = 0
Union
Select c.City
From Customers c
Group By c.City
Having COUNT(c.CustomerID) = 1)

--Question 17b
Select City
From (Select c.City, COUNT(c.City) As [Customer Count]
From Customers c
Group By c.City
Having COUNT(c.City) >= 2) cc

Select c.City
From Customers c
Group By c.City
Having COUNT(c.City) >= 2

--Question 18
With CityProductPair
As (
Select Distinct c.City As [CityName], od.ProductID As [PID]
From Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID = od.OrderID)
Select cpp.CityName
From CityProductPair cpp
Group By cpp.CityName
Having COUNT(cpp.PID) >= 2

--Question 19
Select Top 5 p.ProductId, Avg(p.UnitPrice) [AvgUnitPrice], Sum(Quantity) [SoldTotal]
From Products p Join [Order Details] od On p.ProductID = od.ProductID
Group By p.ProductID
Order By [SoldTotal] Desc

--Question 20
Select MostSoldCity.ShipCity As [Win Win City]
From
(Select Top 1 o.ShipCity
From Orders o
Group By o.ShipCity
Order By COUNT(o.OrderID) DESC) MostOrderCity
join
(Select Top 1 o.ShipCity
From Orders o join [Order Details] od on o.OrderID = od.OrderID
Group By o.ShipCity
Order By SUM(od.Quantity) DESC) MostSoldCity on MostOrderCity.ShipCity = MostSoldCity.ShipCity

--Question 21
--WITH CTE AS(
--   SELECT [col1], [col2], [col3], ... ,
--       RN = ROW_NUMBER()OVER(PARTITION BY col1 ORDER BY col1)
--   FROM Table
--)
--DELETE FROM CTE WHERE RN > 1
