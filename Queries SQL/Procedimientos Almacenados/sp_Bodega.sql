create or alter procedure spBuscarBodega @cod nvarchar(50)
as
begin
    select * from vPantallaBodega b
    where b.CodigoBodega like '%' + @cod + '%' or b.Nombre like '%' + @cod + '%';
end
go