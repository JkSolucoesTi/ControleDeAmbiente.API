use ControleDeAmbiente
go

BEGIN TRAN
BEGIN TRY

insert into TipoDesenvolvedor(Tipo)
values('Web'),('Android'),('IOS'),('Sem Alocação')

insert into Desenvolvedor(Nome,Usuario,Email,TipoDesenvolvedorId)
values
('Sem alocação','bd0001','bancodaycoval@bancodaycoval.com.br',4),
('Ciro','jm0002','marco.goncalves@bancodaycoval.com.br',1),
('Marco','jm0002','marco.goncalves@bancodaycoval.com.br',1),
('Michele','jm0002','marco.goncalves@bancodaycoval.com.br',1),
('Marcelo','jm0002','marco.goncalves@bancodaycoval.com.br',1),
('Douglas','jm0002','marco.goncalves@bancodaycoval.com.br',1),
('Carlos','jm0002','marco.goncalves@bancodaycoval.com.br',1),
('Adauto','jm0002','marco.goncalves@bancodaycoval.com.br',2),
('Valeria','jm0002','marco.goncalves@bancodaycoval.com.br',2),
('Romulo','jm0002','marco.goncalves@bancodaycoval.com.br',2),
('Jarber','jm0002','marco.goncalves@bancodaycoval.com.br',3),
('Will','jm0002','marco.goncalves@bancodaycoval.com.br',3),
('Andre','jm0002','marco.goncalves@bancodaycoval.com.br',3)


insert into Api(Nome,Descricao)
values('Mobile','Api Mobile'),
('PIX','Api Pix')

insert into Negocio(Nome,Email)
values
('Sem alocação',''),
('Joyce','maria.joyce@bancodaycoval.com.br'),
('Natalia','maria.joyce@bancodaycoval.com.br'),
('Tiago','maria.joyce@bancodaycoval.com.br')

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

insert into ambientes(Nome,DesenvolvedorId,ServidorId,Acesso)
values('DEV 01',4,1,''),
	  ('DEV 02',4,1,''),
	  ('DEV 03',4,1,''),
	  ('DEV 04',4,1,''),
	  ('DEV 05',4,1,''),
	  ('DEV 06',4,1,''),
	  ('DEV 07',4,1,''),
	  ('DEV 08',4,1,''),
	  ('DEV 09',4,1,''),
	  ('DEV 10',4,1,''),
	  ('DEV 11',4,1,''),
	  ('Desenv01',4,5,''),
  	  ('Desenv02',4,5,''),
  	  ('Desenv03',4,5,''),
  	  ('Desenv04',4,5,''),
	  ('Desenv05',4,5,''),
	  ('Desenv06',4,5,''),
  	  ('Desenv07',4,5,''),
  	  ('Desenv08',4,5,''),
  	  ('Desenv09',4,5,''),
	  ('Desenv10',4,5,''),
	  ('Desenv11',4,5,''),
  	  ('Desenv12',4,5,''),
  	  ('Desenv13',4,5,''),
  	  ('Desenv14',4,5,''),
	  ('Desenv15',4,5,''),
	  ('Remoting.Desenv01',4,2,''),
	  ('Remoting.Desenv02',4,2,''),
	  ('Remoting.Desenv03',4,2,''),
	  ('Remoting.Desenv04',4,2,''),
	  ('Remoting.Desenv05',4,2,''),
	  ('Remoting.Desenv06',4,2,''),
	  ('Remoting.Desenv07',4,2,''),
	  ('Remoting.Desenv08',4,2,''),
	  ('Remoting.Desenv09',4,2,''),
	  ('Remoting.Desenv10',4,2,''),
	  ('Remoting.Desenv11',4,2,''),
	  ('Remoting.Desenv12',4,2,''),
	  ('Remoting.Desenv13',4,2,''),
	  ('Remoting.Desenv14',4,2,''),
	  ('Remoting.Desenv15',4,2,''),
	  ('DayconnectBackoffice.Desenv01',4,3,''),
	  ('DayconnectBackoffice.Desenv02',4,3,''),
	  ('DayconnectBackoffice.Desenv03',4,3,''),
	  ('DayconnectBackoffice.Desenv04',4,3,''),
	  ('DayconnectBackoffice.Desenv05',4,3,''),
	  ('DayconnectBackoffice.Desenv06',4,3,''),
	  ('DayconnectBackoffice.Desenv07',4,3,''),
	  ('DayconnectBackoffice.Desenv08',4,3,''),
	  ('DayconnectBackoffice.Desenv09',4,3,''),
	  ('DayconnectBackoffice.Desenv10',4,3,''),
	  ('DayconnectBackoffice.Desenv11',4,3,''),
	  ('DayconnectBackoffice.Desenv12',4,3,''),
	  ('DayconnectBackoffice.Desenv13',4,3,''),
	  ('DayconnectBackoffice.Desenv14',4,3,''),
	  ('DayconnectBackoffice.Desenv15',4,3,''),
	  ('WcfGerenciadorInvestimento',4,4,''),
	  ('WebApiIntegracaoInvestimento',4,4,'')


COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH