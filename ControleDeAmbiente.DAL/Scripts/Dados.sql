use ControleDeAmbiente
go

BEGIN TRAN
BEGIN TRY

insert into negocio (Nome)
values('Sem aloca��o'),('Joyce'),('Natalia'),('Tiago')

insert into android (Nome)
values('Sem aloca��o'),('Adauto'),('Valeria'),('Romulo')

insert into api (Nome)
values('Sem aloca��o'),('Ciro'),('Marco'),('Michele'),('Marcelo'),('Douglas'),('Carlos')

insert into ios (Nome)
values('Sem aloca��o'),('Jarber'),('Will'),('Andre')

insert into ambientes(Nome,Chamado,Descricao,ApiId,IosId,AndroidId,NegocioId)
values('DEV 01','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 02','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 03','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 04','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 05','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 06','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 07','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 08','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 09','','Ambiente Dispon�vel',1,1,1,1),
	  ('DEV 10','','Ambiente Dispon�vel',1,1,1,1)

COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH