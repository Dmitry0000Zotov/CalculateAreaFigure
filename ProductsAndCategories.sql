
SELECT Products.Name AS ProductName, COALESCE(Categories.Name, 'Without category') AS CategoryName
FROM Products
LEFT JOIN ProductCategory ON Products.ProductID = ProductCategory.ProductID
LEFT JOIN Categories ON ProductCategory.CategoryID = Categories.CategoryID;
