use ControleDeAmbiente
go

BEGIN TRAN
BEGIN TRY

insert into Api(Nome,Descricao)
values('Mobile','Api Mobile')


insert into Negocio(Nome,Email)
values
('Sem aloca��o',''),
('Joyce','maria.joyce@bancodaycoval.com.br'),
('Natalia','maria.joyce@bancodaycoval.com.br'),
('Tiago','maria.joyce@bancodaycoval.com.br')

insert into Android (Nome,Usuario,Email)
values
('Sem aloca��o','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Adauto','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Valeria','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Romulo','jm0002','marco.goncalves@bancodaycolva.com.br')

insert into Web (Nome,Usuario,Email)
values
('Sem aloca��o','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Ciro','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Marco','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Michele','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Marcelo','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Douglas','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Carlos','jm0002','marco.goncalves@bancodaycolva.com.br')

insert into Ios (Nome,Usuario,Email)
values
('Sem aloca��o','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Jarber','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Will','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Andre','jm0002','marco.goncalves@bancodaycolva.com.br')

insert into ambientes(Nome,Chamado,Descricao,WebId,IosId,AndroidId,NegocioId)
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