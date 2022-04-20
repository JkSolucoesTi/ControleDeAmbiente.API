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

insert into chamado(numero,descricao,negocioid,ambienteid,ativo)
values('','',1,1,0)
,('','',1,2,0)
,('','',1,3,0)
,('','',1,4,0)
,('','',1,5,0)
,('','',1,6,0)
,('','',1,7,0)
,('','',1,8,0)
,('','',1,9,0)
,('','',1,10,0)
,('','',1,11,0)

insert into detalhe(Numero,ChamadoId,DesenvolvedorId)
values
 ('',21,4)
,('',21,4)
,('',21,4)
,('',22,4)
,('',22,4)
,('',22,4)
,('',23,4)
,('',23,4)
,('',23,4)
,('',24,4)
,('',24,4)
,('',24,4)
,('',25,4)
,('',25,4)
,('',25,4)
,('',26,4)
,('',26,4)
,('',26,4)
,('',27,4)
,('',27,4)
,('',27,4)
,('',28,4)
,('',28,4)
,('',28,4)
,('',29,4)
,('',29,4)
,('',29,4)
,('',30,4)
,('',30,4)
,('',30,4)
,('',31,4)
,('',31,4)
,('',31,4)

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
values('DEV 01',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev1/api/default/swagger/ui/index'),
	  ('DEV 02',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev2/api/default/swagger/ui/index'),
	  ('DEV 03',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev3/api/default/swagger/ui/index'),
	  ('DEV 04',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev4/api/default/swagger/ui/index'),
	  ('DEV 05',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev5/api/default/swagger/ui/index'),
	  ('DEV 06',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev6/api/default/swagger/ui/index'),
	  ('DEV 07',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev7/api/default/swagger/ui/index'),
	  ('DEV 08',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev8/api/default/swagger/ui/index'),
	  ('DEV 09',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev9/api/default/swagger/ui/index'),
	  ('DEV 10',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev10/api/default/swagger/ui/index'),
	  ('DEV 11',1,1,'http://sdaysp06qa009/desenvolvimento/dayconnect/dev11/api/default/swagger/ui/index'),
	  ('Desenv01',1,5,'http://sdaysp06d044:8001/'),
  	  ('Desenv02',1,5,'http://sdaysp06d044:8002/'),
  	  ('Desenv03',1,5,'http://sdaysp06d044:8003/'),
  	  ('Desenv04',1,5,'http://sdaysp06d044:8004/'),
	  ('Desenv05',1,5,'http://sdaysp06d044:8005/'),
	  ('Desenv06',1,5,'http://sdaysp06d044:8006/'),
  	  ('Desenv07',1,5,'http://sdaysp06d044:8007/'),
  	  ('Desenv08',1,5,'http://sdaysp06d044:8008/'),
  	  ('Desenv09',1,5,'http://sdaysp06d044:8009/'),
	  ('Desenv10',1,5,'http://sdaysp06d044:8010/'),
	  ('Desenv11',1,5,'http://sdaysp06d044:8011/'),
  	  ('Desenv12',1,5,'http://sdaysp06d044:8012/'),
  	  ('Desenv13',1,5,'http://sdaysp06d044:8013/'),
  	  ('Desenv14',1,5,'http://sdaysp06d044:8014/'),
	  ('Desenv15',1,5,'http://sdaysp06d044:8015/'),
	  ('Remoting.Desenv01',1,2,''),
	  ('Remoting.Desenv02',1,2,''),
	  ('Remoting.Desenv03',1,2,''),
	  ('Remoting.Desenv04',1,2,''),
	  ('Remoting.Desenv05',1,2,''),
	  ('Remoting.Desenv06',1,2,''),
	  ('Remoting.Desenv07',1,2,''),
	  ('Remoting.Desenv08',1,2,''),
	  ('Remoting.Desenv09',1,2,''),
	  ('Remoting.Desenv10',1,2,''),
	  ('Remoting.Desenv11',1,2,''),
	  ('Remoting.Desenv12',1,2,''),
	  ('Remoting.Desenv13',1,2,''),
	  ('Remoting.Desenv14',1,2,''),
	  ('Remoting.Desenv15',1,2,''),
	  ('DayconnectBackoffice.Desenv01',1,3,''),
	  ('DayconnectBackoffice.Desenv02',1,3,''),
	  ('DayconnectBackoffice.Desenv03',1,3,''),
	  ('DayconnectBackoffice.Desenv04',1,3,''),
	  ('DayconnectBackoffice.Desenv05',1,3,''),
	  ('DayconnectBackoffice.Desenv06',1,3,''),
	  ('DayconnectBackoffice.Desenv07',1,3,''),
	  ('DayconnectBackoffice.Desenv08',1,3,''),
	  ('DayconnectBackoffice.Desenv09',1,3,''),
	  ('DayconnectBackoffice.Desenv10',1,3,''),
	  ('DayconnectBackoffice.Desenv11',1,3,''),
	  ('DayconnectBackoffice.Desenv12',1,3,''),
	  ('DayconnectBackoffice.Desenv13',1,3,''),
	  ('DayconnectBackoffice.Desenv14',1,3,''),
	  ('DayconnectBackoffice.Desenv15',1,3,''),
	  ('WcfGerenciadorInvestimento',1,4,''),
	  ('WebApiIntegracaoInvestimento',1,4,'')


COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH