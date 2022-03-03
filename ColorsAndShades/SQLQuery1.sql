SELECT Primarycolor.PrimaryColorName, Shades.Colorname FROM Shades
JOIN Primarycolor ON Primarycolor.Id = Shades.TypeId
WHERE Primarycolor.PrimaryColorName LIKE 'blue'