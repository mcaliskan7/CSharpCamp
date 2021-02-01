--SQL Structured Query Language
--a standard language for accessing and manipulating databases
--ANSI/ISO Standard
--RDBMS Relational Database Management System
--case insensitive (select = Select = SELECT)

--select (all) statement
select * from Customers

--tables -> entities (fields, columns)
--records = rows (horizontal entity)
--fields = columns (vertical entity)

--select specified data
select ContactName, Phone from Customers

--select distinct statement
select distinct City from Customers

--select count statement
select count(distinct City) from Customers

--where statement (condition)
select * from Customers where City = 'London'
select * from Customers where CustomerID = 'ALFKI'

--special where operators
--between -> between a certain range
--like -> search for a pattern
--in -> to specify multiple possible values for a column

--and syntax
select *from Customers where Country = 'France' and City = 'Paris'

--or syntax
select * from Customers where City = 'Paris' or City = 'Berlin'

--not syntax
select * from Customers where not Country = 'UK'

--combining and, or, not
select * from Customers
where Country = 'Germany' and (City = 'Berlin' or City = 'München')

select * from Customers
where not Country = 'Germany' and not Country = 'USA'

--order by keyword
select * from Customers order by ContactName

--order by desc
select * from Customers order by Country desc --asc

select * from Customers
order by Country asc, ContactName desc

--insert into statement
insert into Customers
(CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)
values ('MC','Kodlama.io','Merve Çalışkan', 'Student', 'Eyupsultan', 'Istanbul', NULL, '3400', 'Turkey', '+90 5xxxxxxxxx', NULL)

select count(*) from Customers

--insert into specified column
insert into Customers
(CustomerID, ContactName, City, Country)
values ('ED', 'Engin Demirog','Ankara','Turkey')

--is null syntax
select CustomerID, ContactName, Address from Customers
where Address is null

--is not null syntax
select CustomerID, ContactName, Address from Customers
where Address is not null

--update statement
update Customers set ContactName = 'Nikola Tesla', Country = 'Crotia'
where CustomerID = 'ALFKI'

--updateing multiple records
update Customers set ContactName = 'Juan'
where Country = 'Mexico'

--when where clause is omitted, all records will be updated!
update Customers
set ContactName = 'Juan'

--delete statement
delete from Customers where ContactName = 'Merve Çalışkan'

--deleting all records
delete from Customers

--select top clause
select top 3 * from Customers

--top percent
select top 50 percent * from Customers

--using top clause with where clause
select top 5 * from Customers where Country = 'UK'

--min() syntax
select min(UnitPrice) as SmallestPrice from Products

--max() syntax
select max(UnitPrice) as LargestPrice from Products

--count() syntax
select count(ProductID) from Products --null values are not counted

--avg() syntax
select avg(UnitPrice) from Products

--sum() syntax
select sum(Quantity) from [Order Details]

--like operator
--starting with 'a'
select * from Customers where ContactName like 'a%'

--ending with 'a'
select * from Customers where ContactName like '%a'

--having 'or' in any position
select * from Customers where ContactName like '%or%'

--having 'r' in the second position
select * from Customers where ContactName like '_r%'

--starting with 'a' and at least 3 characters
select * from Customers where ContactName like 'a__%'

--starting with 'a' and ending with 'o'
select * from Customers where ContactName like 'a%o'

--not starting with 'a'
select * from Customers where ContactName not like 'a%'

--wildcard characters
-- % -> zero or more characters
-- _ -> a single character
-- [] -> any single character within the brackets
-- ^ -> any character not in the brackets
-- - -> a range of characters

--starting with 'n', 'l' or 'z'
select * from Customers where ContactName like '[nlz]%'

--starting with 'n', 'o', ... or 'z'
select * from Customers where ContactName like '[n-z]%'

--not starting with 'n', 'l' or 'z'
select * from Customers where ContactName like '[!nlz]%'
select * from Customers where ContactName not like '[nlz]%'

--in operator
select * from Customers where Country in ('Germany', 'UK', 'France')

--not in operator
select * from Customers where Country not in ('Germany', 'UK', 'France')

--all customers from same countries as the suppliers
select * from Customers
where Country in (select Country From Suppliers)

--between operator
select * from Products where UnitPrice between 15 and 25

--not between operator
select * from Products where UnitPrice not between 15 and 25

--between with in
select * from Products
where UnitPrice between 15 and 25 and CategoryID not in (1,2,3)

--using between operator with texts
select * from Products
where ProductName between 'Carnarvon Tigers' and 'Mozzarella di Gioavanni'
order by ProductName

--using not between operator with texts
select * from Products
where ProductName not between 'Carnarvon Tigers' and 'Mozzarella di Gioavanni'
order by ProductName

--using between operator with dates
select * from Orders
where OrderDate between '1996-07-04' and '31/07/1996'

--alias for columns
select CustomerID as ID, ContactName as Customer from Customers

--requires square brackets or double quotation if the alias name contains spaces
select CompanyName as Company, ContactName as [Contact Person] from Customers

--creating an alias combining four columns
select ContactName, Address + ', ' + PostalCode + ' ' + City + ', ' + Country as Address
from Customers

--alias for tables
select o.OrderID, o.OrderDate, c.CompanyName
from Customers as c, Orders as  o
where c.CompanyName = 'Around the Horn' and c.CustomerID = o.CustomerID

--same process without aliases
select Orders.OrderID, Orders.OrderDate,Customers.CompanyName
from Customers, Orders
where Customers.CompanyName = 'Around the Horn' and Customers.CustomerID = Orders.CustomerID

--why aliases?
-- more than one table involved in a query
-- functions used in the query
-- column names are big or not readable
-- two or more columns combined together

--join clauses
--inner join
select Orders.OrderID, Customers.CompanyName, Orders.OrderDate
from Orders
inner join Customers on Orders.CustomerID = Customers.CustomerID

--joining three tables
select Orders.OrderID, Customers.CompanyName, Shippers.CompanyName
from ((Orders
inner join Customers on Orders.CustomerID = Customers.CustomerID)
inner join Shippers on Orders.ShipVia = Shippers.ShipperID)

--left join
--returns all records from the left table even if there are no matches in the right table
select Customers.CompanyName, Orders.OrderID
from Customers
left join orders on Customers.CustomerID = Orders.CustomerID
order by Customers.CompanyName

--right join
--returns all records from the right table even if there are no matches in the left table
select Orders.OrderID, Employees.LastName, Employees.FirstName
from Orders
right join Employees on Orders.EmployeeID = Employees.EmployeeID
order by Orders.OrderID

--full outer join (full join)
--returns all matching records from both tables
select Customers.CompanyName, Orders.OrderID
from Customers
full outer join Orders on Customers.CustomerID = Orders.CustomerID
order by Customers.CompanyName

--self join
--the table is joined with itself
select A.CompanyName as CompanyName1, B.CompanyName as CompanyName2, A.City
from Customers A, Customers B
where A.CustomerID <> B.CustomerID
and A.City = B.City
order by A.City

--union operator
--to combine the result-set of two or more select statements
select City from Customers
union
select City from Suppliers
order by City

--union all operator
--contains duplicate values
select City from Customers
union all
select City from Suppliers
order by City

--union operator with where clause
select City, Country from Customers where Country = 'Germany'
union
select City, Country from Suppliers where Country = 'Germany'
order by City

--union all operator with where clause
select City, Country from Customers where Country = 'Germany'
union all
select City, Country from Suppliers where Country = 'Germany'
order by City

--lists all customers and suppliers
select 'Customer' as Type, ContactName, City, Country from Customers
union
select 'Supplier' as Type, ContactName, City, Country from Suppliers

--group by statement
select count(CustomerID) as [Number of Customers], Country from Customers
group by Country order by [Number of Customers] desc

--group by with join
select Shippers.CompanyName, count(Orders.OrderID) as [Number of Orders]
from Orders
left join Shippers on Orders.ShipVia = Shippers.ShipperID
group by CompanyName

--having clause
select count(CustomerID) as [Number of Customers], Country from Customers
group by Country
having count(CustomerID) > 5
order by [Number of Customers] desc

--a more complex having clause
select Employees.LastName, count(Orders.OrderID) as [Number of Orders]
from Orders
inner join Employees on Orders.EmployeeID = Employees.EmployeeID
where LastName = 'Davolio' or LastName = 'Fuller'
group by LastName
having count(Orders.OrderID) > 25
order by [Number of Orders] desc

--exists operator
select CompanyName from Suppliers
where exists
(select ProductName from Products
where Products.SupplierID = Suppliers.SupplierID and UnitPrice < 20)

--any operator
select ProductName from Products
where ProductID = any (select ProductID from [Order Details] where Quantity > 99)

--all operator
select ProductName from Products
where ProductID = all (select ProductID from [Order Details] where Quantity = 10)

--select into statement
--copies the table
select * into CustomersBackup2017 from Customers

--copies only a few columns
select CompanyName, ContactName into CustomersBackup2017 from Customers

--copies only the specified data
select * into [Customers from Germany] from Customers
where Country = 'Germany'

--copies data from more than one table into a new one
select Customers.CompanyName, Orders.OrderID into CustomersOrderBackup2017
from Customers
left join Orders on Customers.CustomerID = Orders.CustomerID

--creating a new empty table with select into
select * into [Empty Table] from Customers where 1 = 0

--insert into select statement
--copies 'Suppliers' into 'Customers'
insert into Customers (CompanyName, ContactName, Address, City, PostalCode, Country)
select CompanyName, ContactName, Address, City, PostalCode, Country from Suppliers

--copies German Suppliers into 'Customers'
insert into Customers (CompanyName, City, Country)
select CompanyName, City, Country from Suppliers
where Country='Germany'

--case statement
select OrderID, Quantity,
case
	when Quantity > 30 then 'The quantity is greater than 30.'
	when Quantity = 30 then 'The quantity is 30.'
	else 'The quantity is under 30.'
end as QuantityText
from [Order Details]

--case with ordering
select CompanyName, City, Country from Customers
order by
(case
	when City is null then Country
	else City
end)

/*
--stored procedure
--a prepared SQL code that can be saved so it can be reused over and over again

create procedure SelectAllCustomers
as select * from Customers go
--create procedure must be the onlt statemnt in the batch

--calling a stored procedure
exec SelectAllCustomers

--stored procedure with one parameter
create procedure SelectAllCustomers @City nvarchar(30)
as select * from Customers where City = @City

--calling a stored procedure with one parameter
exec SelectAllCustomers @City = 'London'

--stored procedure with multiple parameters
create procedure SelectAllCustomers @City nvarchar(30), @PostalCode nvarchar(10)
as select * from Customers where City = @City and PostalCode = @PostalCode go

--calling a stored procedure with multiple parameters
exec SelectAllCustomers @City = 'London', @PostalCode = 'WA1 1DP'
*/

--multi-line comments
/*This is a
multi-line comment*/

--ignoring part of a line
select CompanyName, City, Country, /*PostalCode,*/ CustomerID from Customers

--ignoring part of a statement
select * from Customers where CompanyName like 'l%'
or CompanyName like 'r%' /*or CompanyName like 's%'
or CompanyName like 't%'*/ or CompanyName like 'w%'
and Country = 'USA'
order by CompanyName