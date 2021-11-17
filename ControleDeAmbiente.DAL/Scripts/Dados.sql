use ControleDeAmbiente
go

BEGIN TRAN
BEGIN TRY

insert into negocio (Nome)
values('Sem alocação'),('Joyce'),('Natalia'),('Tiago')

insert into android (Nome)
values('Sem alocação'),('Adauto'),('Valeria'),('Romulo')

insert into api (Nome)
values('Sem alocação'),('Ciro'),('Marco'),('Michele'),('Marcelo'),('Douglas'),('Carlos')

insert into ios (Nome)
values('Sem alocação'),('Jarber'),('Will'),('Andre')

insert into ambientes(Nome,Chamado,Descricao,ApiId,IosId,AndroidId,NegocioId)
values('DEV 01','','Ambiente Disponível',1,1,1,1),
	  ('DEV 02','','Ambiente Disponível',1,1,1,1),
	  ('DEV 03','','Ambiente Disponível',1,1,1,1),
	  ('DEV 04','','Ambiente Disponível',1,1,1,1),
	  ('DEV 05','','Ambiente Disponível',1,1,1,1),
	  ('DEV 06','','Ambiente Disponível',1,1,1,1),
	  ('DEV 07','','Ambiente Disponível',1,1,1,1),
	  ('DEV 08','','Ambiente Disponível',1,1,1,1),
	  ('DEV 09','','Ambiente Disponível',1,1,1,1),
	  ('DEV 10','','Ambiente Disponível',1,1,1,1)

COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH