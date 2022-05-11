Use AdventureWorks2019
GO

--Question 1
Select ProductID, Name, Color, ListPrice
From Production.Product

--Question 2
Select ProductID, Name, Color, ListPrice
From Production.Product
Where ListPrice <> 0

--Question 3
Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color Is Not Null

--Question 4
Select ProductID, Name, Color, ListPrice
From Production.Product
Where Color Is Not Null And ListPrice > 0

--Question 5
Select Name + ' ' + Color As "Name Color"
From Production.Product
Where Color Is Not Null

--Question 6
Select 'NAME: ' + Name + ' -- COLOR: ' + Color AS Result
From Production.Product
Where Name In ('LL Crankarm', 'ML Crankarm', 'HL Crankarm', 'Chainring Bolts', 'Chainring Nut', 'Chainring')
And Color In ('Black', 'Silver')

--Question 7
Select ProductID, Name
From Production.Product
Where ProductID Between 400 And 500

--Question 8
Select ProductID, Name, Color
From Production.Product
Where Color In ('black', 'blue')

--Question 9
Select Name AS Result
From Production.Product
Where Name Like 'S%'

--Question 10
Select Name, ListPrice
From Production.Product
Where Name Like '[AS]%'
Order By Name ASC

--Question 11
Select *
From Production.Product
Where Name Like 'SPO[^K]%'
Order By Name

--Question 12
Select Distinct IsNull(ProductSubcategoryID, 0) As ProductSubcategoryID, IsNull(Color, 'N/A') As Color
From Production.Product
