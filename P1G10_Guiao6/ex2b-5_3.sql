-- Prescrição Medicamentos DATASET

-- BD@UA

--group: Prescricao 

INSERT INTO PRESCRIÇAO_MEDICAMENTOS.MEDICO VALUES
	--numSNS, nome, especialidade
	(101,'Joao Pires Lima', 'Cardiologia'),
	(102,'Manuel Jose Rosa', 'Cardiologia'),
	(103,'Rui Luis Caraca', 'Pneumologia'),
	(104,'Sofia Sousa Silva', 'Radiologia'),
	(105,'Ana Barbosa', 'Neurologia');

--DELETE FROM PRESCRIÇAO_MEDICAMENTOS.MEDICO;

INSERT INTO PRESCRIÇAO_MEDICAMENTOS.PACIENTE VALUES
	--numUtente, nome, dataNasc, endereco
	(1,'Renato Manuel Cavaco','1980-01-03','Rua Nova do Pilar 35'),
	(2,'Paula Vasco Silva','1972-10-30','Rua Direita 43'),
	(3,'Ines Couto Souto','1985-05-12','Rua de Cima 144'),
	(4,'Rui Moreira Porto','1970-12-12','Rua Zig Zag 235'),
	(5,'Manuel Zeferico Polaco','1990-06-05','Rua da Baira Rio 1135');


INSERT INTO PRESCRIÇAO_MEDICAMENTOS.FARMACIA VALUES
	--nome, , endereco, telefone
	('Farmacia BelaVista','Avenida Principal 973',221234567),
	('Farmacia Central','Avenida da Liberdade 33',234370500),
	('Farmacia Peixoto','Largo da Vila 523',234375111),
	('Farmacia Vitalis','Rua Visconde Salgado 263',229876543);


INSERT INTO PRESCRIÇAO_MEDICAMENTOS.FARMACEUTICA VALUES
	--numReg, nome, endereco
	(905,'Roche','Estrada Nacional 249'),
	(906,'Bayer','Rua da Quinta do Pinheiro 5'),
	(907,'Pfizer','Empreendimento Lagoas Park - Edificio 7'),
	(908,'Merck', 'Alameda Fernão Lopes 12');


INSERT INTO PRESCRIÇAO_MEDICAMENTOS.FARMACO VALUES
	-- nome, formula, numRegFarm,
	('Boa Saude em 3 Dias','XZT9',905),
	('Voltaren Spray','PLTZ32',906),
	('Xelopironi 350','FRR-34',906),
	('Gucolan 1000','VFR-750',906),
	('GEROaero Rapid','DDFS-XEN9',907),
	('Aspirina 1000','BIOZZ02',908);


INSERT INTO PRESCRIÇAO_MEDICAMENTOS.PRESCRIÇAO VALUES
	--numPresc, nummedico, numutent, farmacia, dataProc
	(10001,105,1,'2015-03-03','Farmacia Central'),
	(10002,105,1,NULL,NULL),
	(10003,102,3,'2015-01-17','Farmacia Central'),
	(10004,101,3,'2015-02-09','Farmacia BelaVista'),
	(10005,102,3,'2015-01-17','Farmacia Central'),
	(10006,102,4,'2015-02-22','Farmacia Vitalis'),
	(10007,103,5,NULL,NULL),
	(10008,103,1,'2015-01-02','Farmacia Central'),
	(10009,102,3,'2015-02-02','Farmacia Peixoto');

INSERT INTO PRESCRIÇAO_MEDICAMENTOS.CONTEM VALUES
--	(numPresc, numRegFarm, nomeFarmaco),
	(10001,905,'Boa Saude em 3 Dias'),
	(10002,907,'GEROaero Rapid'),
	(10003,906,'Voltaren Spray'),
	(10003,906,'Xelopironi 350'),
	(10003,908,'Aspirina 1000'),
	(10004,905,'Boa Saude em 3 Dias'),
	(10004,908,'Aspirina 1000'),
	(10005,906,'Voltaren Spray'),
	(10006,905,'Boa Saude em 3 Dias'),
	(10006,906,'Voltaren Spray'),
	(10006,906,'Xelopironi 350'),
	(10006,908,'Aspirina 1000'),
	(10007,906,'Voltaren Spray'),
	(10008,905,'Boa Saude em 3 Dias'),
	(10008,908,'Aspirina 1000'),
	(10009,905,'Boa Saude em 3 Dias'),
	(10009,906,'Voltaren Spray'),
	(10009,908,'Aspirina 1000');
