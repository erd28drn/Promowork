USE [Promowork_data]
GO
/****** Object:  Trigger [dbo].[AgregaFestivoEmpresa]    Script Date: 09/08/2012 21:41:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[AgregaFestivoEmpresa] 
   ON  [dbo].[Empresas] 
   AFTER INSERT,UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	

    -- Insert statements for trigger here
    declare @fecha date,
			@nIdEmpresa int,
			@nmes int,
			@nano int,
			@nIdObra int
			
    --set @fecha=DATEADD(day,-DATEPART(Day ,getdate())+1,GETDATE())
    set @fecha=convert(datetime, convert(char,(select AnoEmpresa from inserted))+'/'+convert(char,(select MesEmpresa from inserted))+'/01')
    select @nIdEmpresa=inserted.IdEmpresa, @nmes=inserted.MesEmpresa, @nano=inserted.AnoEmpresa  from inserted
    
	if (select COUNT(*) from FestivosEmpresas Where FestivosEmpresas.IdEmpresa=@nIdEmpresa and FestivosEmpresas.MesFestivo=@nmes and FestivosEmpresas.AnoFestivo=@nano)=0
		begin
			if ((select COUNT(*) from FestivosEmpresas Where FestivosEmpresas.IdEmpresa=@nIdEmpresa and FestivosEmpresas.MesFestivo=@nmes and FestivosEmpresas.AnoFestivo=@nano-1)!=0)
				begin
					insert into FestivosEmpresas (IdEmpresa, DiaFestivo, MesFestivo, AnoFestivo) select @nIdEmpresa, DiaFestivo, @nmes, @nano from FestivosEmpresas Where FestivosEmpresas.IdEmpresa=@nIdEmpresa and FestivosEmpresas.MesFestivo=@nmes and FestivosEmpresas.AnoFestivo=@nano-1
				end
			else
			begin
				while (select count(*) from inserted where DATEPART(MONTH ,@fecha)=inserted.MesEmpresa)!=0
				begin
			 if DATEPART(DW ,@fecha)=1 or DATEPART(DW ,@fecha)=7
				begin
				  insert into FestivosEmpresas (IdEmpresa, DiaFestivo, MesFestivo, AnoFestivo) 
					values ((select IdEmpresa from Inserted), DATEPART(DAY ,@fecha),DATEPART(MONTH ,@fecha), DATEPART(YEAR ,@fecha))
				end
			set @fecha=DATEADD(day,1,@fecha)
			end
		end
	End
--------------------------------------------------------	
--AGREGANDO LOS FESTIVOS A LAS OBRAS DE LA EMPRESA
-----------------------------------------------------	
	declare tmpObras cursor for
	select IdObra from Obras where IdEmpresa=@nIdEmpresa and 
	Obras.FechaFinObra>=convert(datetime, convert(char,@nano)+'/'+convert(char,@nmes)+'/'+convert(char, 1)) AND FechaIniObra<=DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,@fecha)+1,0))
	
	OPEN tmpObras
	FETCH NEXT FROM tmpObras 
	INTO @nIdObra
	WHILE @@FETCH_STATUS = 0
	BEGIN
	    if ((select COUNT(*) from FestivosObras where festivosObras.IdObra=@nIdObra and FestivosObras.MesFestivo=@nmes and FestivosObras.AnoFestivo=@nano)=0)
		begin
	    insert into FestivosObras (IdObra, DiaFestivo, MesFestivo, AnoFestivo) 
		(select distinct @nIdObra, FestivosEmpresas.DiaFestivo, @nmes, @nano 
				from obras inner join FestivosEmpresas on Obras.IdEmpresa=FestivosEmpresas.IdEmpresa where FestivosEmpresas.IdEmpresa=@nIdEmpresa and FestivosEmpresas.MesFestivo=@nmes and FestivosEmpresas.AnoFestivo=@nano and 
							convert(datetime, convert(char,@nano)+'/'+convert(char,@nmes)+'/'+convert(char, FestivosEmpresas.DiaFestivo)) between Obras.FechaIniObra and Obras.FechaFinObra)
	
		end
	    
		FETCH NEXT FROM tmpObras 
		INTO @nIdObra
	END 
	CLOSE tmpObras
	DEALLOCATE tmpObras
	
	
	/*
	if ((select COUNT(*) from FestivosObras where festivosObras.IdObra in (select Obras.IdObra from  Obras where Obras.IdEmpresa=@nIdEmpresa) and FestivosObras.MesFestivo=@nmes and FestivosObras.AnoFestivo=@nano)=0)
	begin	
	
	--delete from FestivosObras where FestivosObras.IdEmpresa=@nIdEmpresa and FestivosObras.MesFestivo=@nmes and FestivosObras.AnoFestivo=@nano
	
	insert into FestivosObras (IdObra, DiaFestivo, MesFestivo, AnoFestivo) 
		(select distinct Obras.IdObra, FestivosEmpresas.DiaFestivo, @nmes, @nano 
				from Obras, FestivosEmpresas where Obras.idEmpresa=@nIdEmpresa and FestivosEmpresas.MesFestivo=@nmes and FestivosEmpresas.AnoFestivo=@nano
				and convert(datetime, convert(char,@nano)+'/'+convert(char,@nmes)+'/'+convert(char, FestivosEmpresas.DiaFestivo)) between Obras.FechaIniObra and Obras.FechaFinObra)
	
	end*/
	
	
	
	
END
