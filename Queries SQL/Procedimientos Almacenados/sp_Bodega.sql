CREATE OR ALTER PROCEDURE spBuscarBodega @cod NVARCHAR(50)
AS
BEGIN
    SELECT 
    FROM 
        Pruebas.Bodega
    WHERE 
        CodigoBodega LIKE '%' + @cod + '%'
        OR Nombre LIKE '%' + @cod + '%';
END
