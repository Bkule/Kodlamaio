/*
	(Türkçe)
	Her bir üründen toplamda ne kadar para kazandığımızı bulunuz.
	İpucu : Group by kullanılacak.
	İpucu : Products, Orders, Order Details tabloları join edilecek.
	İpucu : Sum kullanılacak.
	Sonuç aşağıdaki formatta olmalıdır.
		Ürün Adı, Kazanılan Toplam Miktar

	Not : Kazanılan tutar toplamı Order Details tablosunda unitPrice ve quantity alanlarının çarpımından beslenecek.


	(English)
	Find out how much money we earn in total from each product.
	Hint : GROUP BY statement will be used. JOIN clause will be used for Products, Orders and Order Details tables. Sum function will be used.
	The result should be in following format:
		Product Name, Total Amount
	
	Note : The total amount will be calculated by UnitPrice and Quantity fields in Order Details table.
*/



--In this project, the well-known Northwind sample database for Microsoft SQL Server is used.

SELECT p.ProductName AS [Product Name], SUM(od.UnitPrice*ISNULL(od.Quantity,0)*(1-od.Discount)) AS [Total Amount]
FROM [Order Details] AS od
INNER JOIN Orders AS o ON od.OrderID = o.OrderID
INNER JOIN Products AS p ON od.ProductID = p.ProductID
GROUP BY p.ProductName
ORDER BY ProductName