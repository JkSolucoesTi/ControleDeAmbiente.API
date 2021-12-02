use ControleDeAmbiente
go

BEGIN TRAN
BEGIN TRY

insert into Api(Nome,Descricao)
values('Mobile','Api Mobile'),
('Investimento','Api Investimento'),
('PIX','Api Pix')

insert into Negocio(Nome,Email)
values
('Sem alocação',''),
('Joyce','maria.joyce@bancodaycoval.com.br'),
('Natalia','maria.joyce@bancodaycoval.com.br'),
('Tiago','maria.joyce@bancodaycoval.com.br')

insert into Android (Nome,Usuario,Email)
values
('Sem alocação','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Adauto','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Valeria','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Romulo','jm0002','marco.goncalves@bancodaycolva.com.br')

insert into Web (Nome,Usuario,Email)
values
('Sem alocação','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Ciro','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Marco','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Michele','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Marcelo','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Douglas','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Carlos','jm0002','marco.goncalves@bancodaycolva.com.br')

insert into Ios (Nome,Usuario,Email)
values
('Sem alocação','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Jarber','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Will','jm0002','marco.goncalves@bancodaycolva.com.br'),
('Andre','jm0002','marco.goncalves@bancodaycolva.com.br')

insert into ambientes(Nome)
values('DEV 01'),
	  ('DEV 02'),
	  ('DEV 03'),
	  ('DEV 04'),
	  ('DEV 05'),
	  ('DEV 06'),
	  ('DEV 07'),
	  ('DEV 08'),
	  ('DEV 09'),
	  ('DEV 10'),
	  ('DEV 11')

COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH



delete from android
delete from ios
delete from web
delete from ambientes
delete from negocio
delete from chamado
