create or alter procedure spBuscarLotes @cod varchar(100)
as
begin
select * from vMostrarLotes m where m.CodigoLote=@cod or m.CodigoFinca=@cod
end 
go
