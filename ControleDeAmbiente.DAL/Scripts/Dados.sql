use ControleDeAmbiente
go

BEGIN TRAN
BEGIN TRY

insert into Api(Nome,Descricao)
values('Mobile','Api Mobile'),
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

insert into chamado(numero,descricao,ambienteid,apiid,webid,chamadoweb,iosid,chamadoios,androidid,chamadoandroid,negocioid,ativo)
values
('','',1,1,1,'',1,'',1,'',1,0),
('','',2,1,1,'',1,'',1,'',1,0),
('','',3,1,1,'',1,'',1,'',1,0),
('','',4,1,1,'',1,'',1,'',1,0),
('','',5,1,1,'',1,'',1,'',1,0),
('','',6,1,1,'',1,'',1,'',1,0),
('','',7,1,1,'',1,'',1,'',1,0),
('','',8,1,1,'',1,'',1,'',1,0),
('','',9,1,1,'',1,'',1,'',1,0),
('','',10,1,1,'',1,'',1,'',1,0),
('','',11,1,1,'',1,'',1,'',1,0)

insert into Usuario(Login,Nome,Email,Senha,Perfil)
values(
'jm0002',
'Marco Gonçalves',
'marco.goncalves@bancodaycoval.com.br',
'12345678',
'ADMIN')


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
