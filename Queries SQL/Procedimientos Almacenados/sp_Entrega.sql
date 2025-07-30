use AgroLinkDB


go


-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Busqueda por Codigo >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE OR ALTER PROCEDURE spBuscarEntrega @cod varchar(10)
as
	BEGIN 
		SELECT * FROM vTraeEntrega WHERE CodigoEntrega LIKE '%' + @cod + '%' or Socio like '%' + @cod + '%'
	END

go

exec spBuscarEntrega 'col'
go





-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Entrega Filtrada >>>>>>>>>>>>>>>>>>>>>>>>>>>>
CREATE OR ALTER PROCEDURE spTraeEntregaFiltrada @entrID int, @salID int
as
	begin
		IF @entrID = 0
			begin
				SELECT  '' [CodigoEntrega], GETDATE() [Fecha], SP.SocioID, SP.SalidaID, 0 [DireccionID], 0 [Repartidor],
				M.DepartamentoID, D.MunicipioID , D.Colonia, D.Detalle
				FROM Pruebas.SalidaProducto SP 
				INNER JOIN Pruebas.Socio S ON SP.SocioID = S.SocioID
				INNER JOIN Pruebas.Direccion D ON S.DireccionID = D.DireccionID
				INNER JOIN Pruebas.Municipio M ON D.MunicipioID = M.MunicipioID
				WHERE  SP.SalidaID = @salID

			end
		ELSE
			SELECT * FROM vTraeEntregaDir WHERE EntregaID = @entrID


	end
go

exec  spTraeEntregaFiltrada 1 , 

select * from PRUEBAS.entrega
select * from PRUEBAS.EntregaDetalle
select * from PRUEBAS.salidaproducto

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Trae Entrega Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spTraeEntregaDetalle @entrID int , @salID int
as
	begin
		
		declare @ventaDetalle as table(VentaID int, CodigoProducto varchar(50), ProductoID int, BodegaID int, Cantidad int , 
		Precio decimal(10,2), ImpuestoID int, Subtotal decimal(10,2), Total decimal(10,2))

	-->Valida si es una nueva salida
		IF @entrID = 0
			BEGIN
				--Trae los datos de la salida en la cual esta basada la entrega

				SELECT @entrID [EntregaID], P.CodigoProducto, SPD.ProductoID, Cantidad
				FROM Pruebas.SalidaProductoDetalle SPD
				INNER JOIN Pruebas.Producto P ON SPD.ProductoID = P.ProductoID
				WHERE SPD.SalidaID = @salID

			END
		ELSE
			BEGIN
				SELECT ED.EntregaID, P.CodigoProducto, ED.ProductoID, ED.Cantidad
				FROM Pruebas.EntregaDetalle ED
				INNER JOIN Pruebas.Producto P ON ED.ProductoID = P.ProductoID
				WHERE ED.EntregaID = @entrID
			END
	end
go

exec  spTraeEntregaDetalle 0 , 13



select * from pruebas.entrega
select * from pruebas.entregadetalle
select * from pruebas.SalidaProducto












-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega Entrega >>>>>>>>>>>>>>>>>>>>>>>>>>>>

CREATE TYPE TipoEntrega as TABLE(

	EntregaID int ,
	Codigo varchar(10),
	ProductoID int not null,
	Cantidad int not null
)


go

CREATE OR ALTER PROCEDURE spAddUpdateEntrega 
@entrID int ,  @salID int ,  @socID int , @fecha date , @repID int, 
@depID int , @munID int , @col varchar(20), @det varchar(100), 
@detalle TipoEntrega READONLY

as 
	begin
		
		begin transaction

			DECLARE @err varchar(50) = '', @dirID int
	
		-->Valida si la direccion es igual a la del socio y si es distinta crea una nueva direccion solo para la entrega			
			select @dirID = DireccionID from pruebas.socio where SocioID = @socID

			SELECT @dirID = CASE 
			WHEN @munID = MunicipioID AND @col = Colonia AND @det = Detalle 
			THEN @dirID 
			ELSE 0 END 
			FROM pruebas.Direccion where DireccionId = @dirID

			IF @dirID = 0
				begin
					INSERT INTO Pruebas.Direccion (MunicipioID, Colonia, Detalle) VALUES (@munID, @col, @det)
					select top 1 @dirID = DireccionID from pruebas.Direccion order by DireccionID desc;
				end

	-->Crea o Edita 
			IF @entrID = 0 or @entrID IS NULL
				begin	--nueva Entrega
					INSERT INTO Pruebas.Entrega (Fecha,SocioID,SalidaID, DireccionID, RepartidorID) VALUES
					(@fecha, @socID ,  @salID, @dirID, @repID )
					IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
				end
			ELSE
				begin	--editar Entrega
					UPDATE Pruebas.Entrega SET Fecha = @fecha, SocioID = @socID , SalidaID = @salID, 
					DireccionID = @dirID, RepartidorID = @repID
					WHERE EntregaID = @entrID
					IF @@ERROR <> 0 AND @err = '' select @err = 'Error'
				end	

	-->Valida si hubieron errores en la Factura
		IF @err = ''   
			begin
				
				IF @entrID = 0 or @entrID IS NULL --si es una nueva trae la mas reciente
					select top 1 @entrID = EntregaID from pruebas.Entrega order by EntregaID desc;

		-->Ejecuta y valida si hubieron errores en la SALIDA detalle
				exec spAddUpdateEntregaDet @entrID, @detalle  --************PENDIENTE
				IF @@ERROR = 0   --valida error al ingresar la SALIDA detalle
					begin
						commit;
						select @entrID  
					end
				ELSE
					rollback;
			end
		ELSE
			rollback;

	end
go




select * from pruebas.Entrega
select * from pruebas.EntregaDetalle

select * from pruebas.direccion

select * from pruebas.SalidaProducto
select * from pruebas.SalidaProductoDetalle

go

-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Actualiza y Agrega entrega Detalle >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spAddUpdateEntregaDet @entrID int,
@detalle TipoEntrega READONLY
as
	begin
	--> Actualiza entrega detalle
		delete from pruebas.EntregaDetalle where EntregaID = @entrID
		insert into Pruebas.EntregaDetalle
		SELECT @entrID, ProductoID, Cantidad FROM @detalle
		
	end

go



-->>>>>>>>>>>>>>>>>>>>>>>>>>>> Borra Entrega >>>>>>>>>>>>>>>>>>>>>>>>>>>>


CREATE OR ALTER PROCEDURE spBorrarEntrega @entrID int
as
	begin
	--> Actualiza entrega detalle
		delete from pruebas.EntregaDetalle where EntregaID = @entrID
		delete from pruebas.Entrega where EntregaID = @entrID
	end
go












