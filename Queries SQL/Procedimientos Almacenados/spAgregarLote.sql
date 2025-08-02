create or alter procedure spAgregarLote @FincaID int,@productoID int,@TipoSuelo int,@tiporiego int,@fechaSiembra date,@FechCosecha date,@exs decimal(8,2)
as
begin
--se agregan los dats de el c#
insert into Pruebas.Lote(FincaID,ProductoID,TipoSueloID,TipoRiegoID,FechaSiembra,FechaCosecha,Extension)
values(@FincaID,@productoID,@TipoSuelo,@tiporiego,@fechaSiembra,@FechCosecha,@exs)

 -- Devolver el ID del producto insertado
    select SCOPE_IDENTITY() as ProductoID

end
go

