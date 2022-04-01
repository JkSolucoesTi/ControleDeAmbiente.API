use ControleDeAmbiente
go

BEGIN TRAN
BEGIN TRY

insert into TipoDesenvolvedor(Tipo)
values('Web'),('Android'),('IOS')

insert into Desenvolvedor(Nome,Usuario,Email,TipoDesenvolvedorId)
values
('Sem alocação','jm0002','marco.goncalves@bancodaycolva.com.br',1),
('Ciro','jm0002','marco.goncalves@bancodaycolva.com.br',1),
('Marco','jm0002','marco.goncalves@bancodaycolva.com.br',1),
('Michele','jm0002','marco.goncalves@bancodaycolva.com.br',1),
('Marcelo','jm0002','marco.goncalves@bancodaycolva.com.br',1),
('Douglas','jm0002','marco.goncalves@bancodaycolva.com.br',1),
('Carlos','jm0002','marco.goncalves@bancodaycolva.com.br',1),

('Sem alocação','jm0002','marco.goncalves@bancodaycolva.com.br',2),
('Adauto','jm0002','marco.goncalves@bancodaycolva.com.br',2),
('Valeria','jm0002','marco.goncalves@bancodaycolva.com.br',2),
('Romulo','jm0002','marco.goncalves@bancodaycolva.com.br',2),

('Sem alocação','jm0002','marco.goncalves@bancodaycolva.com.br',3),
('Jarber','jm0002','marco.goncalves@bancodaycolva.com.br',3),
('Will','jm0002','marco.goncalves@bancodaycolva.com.br',3),
('Andre','jm0002','marco.goncalves@bancodaycolva.com.br',3)

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

insert into Servidor(Nome,Dominio)
Values
('Mobile','SDAYSP06QA009'),
('Remoting','SDAYSP06D040'),
('Backoffice','SDAYSP06D041'),
('Investimento','SDAYSP06D043'),
('Dayconnect','SDAYSP06D044')

insert into ambientes(Nome,ServidorId)
values('DEV 01',1),
	  ('DEV 02',1),
	  ('DEV 03',1),
	  ('DEV 04',1),
	  ('DEV 05',1),
	  ('DEV 06',1),
	  ('DEV 07',1),
	  ('DEV 08',1),
	  ('DEV 09',1),
	  ('DEV 10',1),
	  ('DEV 11',1),
	  ('Desenv01',5),
  	  ('Desenv02',5),
  	  ('Desenv03',5),
  	  ('Desenv04',5),
	  ('Desenv05',5),
	  ('Desenv06',5),
  	  ('Desenv07',5),
  	  ('Desenv08',5),
  	  ('Desenv09',5),
	  ('Desenv10',5),
	  ('Desenv11',5),
  	  ('Desenv12',5),
  	  ('Desenv13',5),
  	  ('Desenv14',5),
	  ('Desenv15',5),
	  ('Remoting.Desenv01',2),
	  ('Remoting.Desenv02',2),
	  ('Remoting.Desenv03',2),
	  ('Remoting.Desenv04',2),
	  ('Remoting.Desenv05',2),
	  ('Remoting.Desenv06',2),
	  ('Remoting.Desenv07',2),
	  ('Remoting.Desenv08',2),
	  ('Remoting.Desenv09',2),
	  ('Remoting.Desenv10',2),
	  ('Remoting.Desenv11',2),
	  ('Remoting.Desenv12',2),
	  ('Remoting.Desenv13',2),
	  ('Remoting.Desenv14',2),
	  ('Remoting.Desenv15',2),
	  ('DayconnectBackoffice.Desenv01',3),
	  ('DayconnectBackoffice.Desenv02',3),
	  ('DayconnectBackoffice.Desenv03',3),
	  ('DayconnectBackoffice.Desenv04',3),
	  ('DayconnectBackoffice.Desenv05',3),
	  ('DayconnectBackoffice.Desenv06',3),
	  ('DayconnectBackoffice.Desenv07',3),
	  ('DayconnectBackoffice.Desenv08',3),
	  ('DayconnectBackoffice.Desenv09',3),
	  ('DayconnectBackoffice.Desenv10',3),
	  ('DayconnectBackoffice.Desenv11',3),
	  ('DayconnectBackoffice.Desenv12',3),
	  ('DayconnectBackoffice.Desenv13',3),
	  ('DayconnectBackoffice.Desenv14',3),
	  ('DayconnectBackoffice.Desenv15',3),
	  ('WcfGerenciadorInvestimento',4),
	  ('WebApiIntegracaoInvestimento',4)


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
