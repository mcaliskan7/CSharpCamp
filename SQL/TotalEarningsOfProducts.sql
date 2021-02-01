--joins the tables 'Products', 'Orders' and 'Order Details'
--calculates how much money earned in total for each product
--sorts in reverse first by total earnings then by product name

select ProductName as [Product Name],
sum([Order Details].UnitPrice * [Order Details].Quantity) as [Total Earnings]
from [Order Details]
inner join Products on Products.ProductID = [Order Details].ProductID
inner join Orders on Orders.OrderID = [Order Details].OrderID
group by ProductName
order by [Total Earnings], [Product Name] desc