use p1g10;
GO

--Adicionar cliente
CREATE PROCEDURE sp_addClient @Nome VARCHAR(40), @NIF CHAR(9), @Morada VARCHAR(30), @Contacto CHAR(9) AS
	IF @NIF is null
	BEGIN
		PRINT 'O NIF não pode ser vazio.'
		RETURN
	END

	DECLARE @nifClient AS TINYINT
	SET @nifClient = (SELECT COUNT(STAND.CLIENTE.NIF) AS nifClient FROM STAND.CLIENTE WHERE STAND.CLIENTE.NIF=@NIF)

	DECLARE @nifMechanic AS TINYINT
	SET @nifMechanic = (SELECT COUNT(STAND.MECANICO.NIF) AS nifMechanic FROM STAND.MECANICO WHERE STAND.MECANICO.NIF=@NIF)	

	IF (@nifMechanic != 0)
	BEGIN
		PRINT 'Este NIF esta associado a um funcionário'
		RETURN
	END	

	IF (@nifClient = 0)
	BEGIN
		IF @Nome is null
		BEGIN
			PRINT 'O Nome não pode estar vazio'
			RETURN
		END

		IF @Contacto is null
		BEGIN
			PRINT 'O Contacto não pode estar vazio'
			RETURN
		END

		INSERT INTO STAND.CLIENTE(Nome, NIF, Morada, Contacto)
		VALUES (@Nome, @NIF, @Morada, @Contacto);
	END
	ELSE
		PRINT 'O cliente associado a este NIF ja existe'
GO

--Adicionar mecanico
CREATE PROCEDURE sp_addMechanic @Nome VARCHAR(40), @NIF CHAR(9), @Morada VARCHAR(30), @Contacto CHAR(9), @Veiculo_ID INT, @Oficina_ID INT AS
	IF @NIF is null
	BEGIN
		PRINT 'O NIF não pode ser vazio.'
		RETURN
	END

	DECLARE @nifClient AS TINYINT
	SET @nifClient = (SELECT COUNT(STAND.CLIENTE.NIF) AS nifClient FROM STAND.CLIENTE WHERE STAND.CLIENTE.NIF=@NIF)

	DECLARE @nifMechanic AS TINYINT
	SET @nifMechanic = (SELECT COUNT(STAND.MECANICO.NIF) AS nifMechanic FROM STAND.MECANICO WHERE STAND.MECANICO.NIF=@NIF)	

	IF (@nifClient != 0)
	BEGIN
		PRINT 'Este NIF esta associado a um cliente'
		RETURN
	END	

	IF (@nifMechanic = 0)
	BEGIN
		IF @Nome is null
		BEGIN
			PRINT 'O Nome não pode estar vazio'
			RETURN
		END

		IF @Contacto is null
		BEGIN
			PRINT 'O Contacto não pode estar vazio'
			RETURN
		END

		INSERT INTO STAND.MECANICO(Nome, NIF, Morada, Contacto, Oficina_ID)
		VALUES (@Nome, @NIF, @Morada, @Contacto, @Oficina_ID);
	END
	ELSE
		PRINT 'O funcionário associado a este NIF ja existe'
GO

--Adicionar veiculo para vender
CREATE PROCEDURE sp_addVehicleToSell @Chassis_ID INT, @Marca VARCHAR(40), @Modelo VARCHAR(30), @Quilometragem INT, @Pais_Origem VARCHAR(30), @Ano_Fabrico CHAR(4),
@Combustivel VARCHAR(10), @Tracao VARCHAR(10), @Tipo_Veiculo INT, @Potencia INT, @Stand_ID INT AS
	IF @Chassis_ID is null
	BEGIN
		PRINT 'O numero do chassis não pode estar vazio.'
		RETURN
	END

	DECLARE @vehicleToSell AS TINYINT
	SET @vehicleToSell = (SELECT COUNT(STAND.VEICULO_VENDA.Chassis_ID) AS vehicleToSell FROM STAND.VEICULO_VENDA WHERE STAND.VEICULO_VENDA.Chassis_ID=@Chassis_ID)

	DECLARE @vehicleToRepair AS TINYINT
	SET @vehicleToRepair = (SELECT COUNT(STAND.VEICULO_REPARAR.Chassis_ID) AS vehicleToSell FROM STAND.VEICULO_REPARAR WHERE STAND.VEICULO_REPARAR.Chassis_ID=@Chassis_ID)
	
	IF (@vehicleToRepair != 0)
	BEGIN
		PRINT 'O veiculo com este numero de chassis está numa oficina'
		RETURN
	END	

	IF (@vehicleToSell = 0)
	BEGIN
		IF @Marca is null
		BEGIN
			PRINT 'A Marca nao pode estar vazia'
			RETURN
		END

		IF @Modelo is null
		BEGIN
			PRINT 'O Modelo não pode estar vazio'
			RETURN
		END

		IF @Quilometragem is null
		BEGIN
			PRINT 'A Quilometragem esta vazia, assume-se como veiculo novo'
			SET @Quilometragem = 0
		END

		IF @Combustivel is null
		BEGIN
			PRINT 'O Combustivel não pode estar vazio'
			RETURN
		END

		IF @Tipo_Veiculo is null
		BEGIN
			PRINT 'O veiculo tem que ter uma categoria (Tipo_Veiculo)'
			RETURN
		END

		IF @Stand_ID is null
		BEGIN
			PRINT 'O veiculo tem que estar associado a um stand'
			RETURN
		END

		INSERT INTO STAND.VEICULO_VENDA(Chassis_ID, Marca, Modelo, Quilometragem, Pais_Origem, Ano_Fabrico, Combustivel, Tracao, Tipo_Veiculo, Potencia, Stand_ID)
		VALUES (@Chassis_ID, @Marca, @Modelo, @Quilometragem, @Pais_Origem, @Ano_Fabrico, @Combustivel, @Tracao, @Tipo_Veiculo, @Potencia, @Stand_ID);
	END
	ELSE
		PRINT 'O número de chassis ja esta associado a um veiculo para venda'
GO

--Adicionar veiculo para reparar
CREATE PROCEDURE sp_addVehicleToRepair @Chassis_ID INT, @Marca VARCHAR(40), @Modelo VARCHAR(30), @Quilometragem INT, @Estado BIT, @Ano_Fabrico CHAR(4),
@Tipo_Veiculo INT, @Peca_ID INT, @Oficina_ID INT, @Mecanico INT AS
	IF @Chassis_ID is null
	BEGIN
		PRINT 'O numero do chassis não pode estar vazio.'
		RETURN
	END

	DECLARE @vehicleToSell AS TINYINT
	SET @vehicleToSell = (SELECT COUNT(STAND.VEICULO_VENDA.Chassis_ID) AS vehicleToSell FROM STAND.VEICULO_VENDA WHERE STAND.VEICULO_VENDA.Chassis_ID=@Chassis_ID)

	DECLARE @vehicleToRepair AS TINYINT
	SET @vehicleToRepair = (SELECT COUNT(STAND.VEICULO_REPARAR.Chassis_ID) AS vehicleToSell FROM STAND.VEICULO_REPARAR WHERE STAND.VEICULO_REPARAR.Chassis_ID=@Chassis_ID)
	
	IF (@vehicleToSell != 0)
	BEGIN
		PRINT 'O veiculo com este numero de chassis está para venda num Stand'
		RETURN
	END	

	IF (@vehicleToRepair = 0)
	BEGIN
		IF @Marca is null
		BEGIN
			PRINT 'A Marca nao pode estar vazia'
			RETURN
		END

		IF @Modelo is null
		BEGIN
			PRINT 'O Modelo não pode estar vazio'
			RETURN
		END

		IF @Tipo_Veiculo is null
		BEGIN
			PRINT 'O veiculo tem que ter uma categoria (Tipo_Veiculo)'
			RETURN
		END

		IF @Estado is null
		BEGIN
			PRINT 'O estado do veiculo esta vazio, assume-se como por reparar'
			SET @Estado = 0
		END

		INSERT INTO STAND.VEICULO_REPARAR(Chassis_ID, Marca, Modelo, Quilometragem, Estado, Tipo_Veiculo, Peca_ID, Oficina_ID, Mecanico)
		VALUES (@Chassis_ID, @Marca, @Modelo, @Quilometragem, @Estado, @Tipo_Veiculo, @Peca_ID, @Oficina_ID, @Mecanico);
	END
	ELSE
		PRINT 'O número de chassis ja esta associado a um veiculo para reparar'
GO

--Adicionar tipo de veiculo
CREATE PROCEDURE sp_addVehicleType @Veiculo_ID INT, @Nome VARCHAR(50) AS
	IF @Veiculo_ID is null
	BEGIN
		PRINT 'O id do veiculo não pode ser vazio'
		RETURN
	END 

	IF EXISTS (SELECT 1 FROM STAND.TIPO_VEICULO WHERE Veiculo_ID = @Veiculo_ID)
	BEGIN
		PRINT 'O id fornecido já existe'
		RETURN
	END

	IF @Nome is null
	BEGIN
		PRINT 'O tipo de veiculo necessita de um nome'
		RETURN
	END
	
	INSERT INTO STAND.TIPO_VEICULO VALUES(@Veiculo_ID, @Nome);
GO

--Reparar um veiculo
CREATE PROCEDURE sp_repairVehicle @Chassis_ID INT, @Mec INT AS
	DECLARE @chassis AS INT
	SET @chassis = (SELECT Chassis_ID FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Chassis_ID);
	IF @chassis is null
	BEGIN 
		PRINT 'O número de chassis não esta associado a nenhum veiculo na garagem'
		RETURN
	END

	DECLARE @peca_id AS INT
	SET @peca_id = (SELECT Peca_ID FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Chassis_ID);

	DECLARE @peca AS INT
	SET @peca = (SELECT Disponibilidade FROM STAND.PECAS JOIN STAND.VEICULO_REPARAR ON PECAS.Peca_ID = VEICULO_REPARAR.Peca_ID WHERE VEICULO_REPARAR.Chassis_ID = @Chassis_ID);
	IF @peca = 0
	BEGIN	
		PRINT 'A peça necessária para reparar o veiculo não está disponível'
		RETURN
	END

	DECLARE @mecanico AS INT
	SET @mecanico = (SELECT Mecanico FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Chassis_ID);
	IF @mecanico is null
	BEGIN
		PRINT 'O veiculo não tem nenhum mecanico associado'
		EXEC sp_VehicleToMechanic @Mec, @Chassis_ID
	END

	DECLARE @oficina AS INT
	SET @oficina = (SELECT Oficina_ID FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Chassis_ID);
	IF @oficina is null
	BEGIN
		PRINT 'O veiculo não tem nenhuma oficina associada'
		RETURN
	END

	UPDATE STAND.VEICULO_REPARAR SET Estado = 1 WHERE Chassis_ID=@Chassis_ID;

	IF EXISTS (SELECT 1 FROM STAND.VEICULOS_REPARADOS WHERE Chassis_ID = @Chassis_ID)
	BEGIN
		UPDATE STAND.VEICULOS_REPARADOS
		SET Quilometragem= (SELECT Quilometragem FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Chassis_ID AND Estado = 1),
		Peca_ID= (SELECT Peca_ID FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Chassis_ID AND Estado = 1),
		Oficina_ID = (SELECT Oficina_ID FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Chassis_ID AND Estado = 1)
		WHERE Chassis_ID = @Chassis_ID; 
		RETURN;
	END

	DECLARE @Cliente_ID AS INT
	SET @Cliente_ID = (SELECT Cliente_ID FROM STAND.LEVA WHERE Veiculo_ID = @Chassis_ID);
	INSERT INTO STAND.VEICULOS_REPARADOS(Chassis_ID,Marca,Modelo,Quilometragem,Tipo_Veiculo,Peca_ID,Oficina_ID,Cliente_ID)
	(SELECT Chassis_ID,Marca,Modelo,Quilometragem,Tipo_Veiculo,Peca_ID,Oficina_ID,@Cliente_ID AS Cliente_ID
	FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Chassis_ID AND Estado = 1);
GO

--Adicionar uma peça ao stock
CREATE PROCEDURE sp_addPart @Fabricante VARCHAR(20), @Tipo_Peca INT, @Nome VARCHAR(50) AS
	IF @Tipo_Peca is null
	BEGIN
		PRINT 'Todas as peças são categorizadas por um tipo (Tipo_Peca)'
		RETURN
	END

	IF NOT EXISTS (SELECT 1 FROM STAND.Tipo_Peca WHERE TipoPeca_ID=@Tipo_Peca)
	BEGIN
		PRINT 'A categoria de peças definida não existe'
		RETURN
	END

	IF @Nome is null
	BEGIN
		PRINT 'A peça necessita de ter um nome'
		RETURN
	END

	INSERT INTO STAND.PECAS(Fabricante, Disponibilidade, Tipo_Peca, Nome)
	VALUES (@Fabricante, 1, @Tipo_Peca, @Nome);
GO

--Adicionar tipo de peça
CREATE PROCEDURE sp_addPartType @Peca_ID INT, @Nome VARCHAR(50) AS
	IF @Peca_ID is null
	BEGIN
		PRINT 'O id da peça não pode ser vazio'
		RETURN
	END 

	IF EXISTS (SELECT 1 FROM STAND.TIPO_PECA WHERE TipoPeca_ID = @Peca_ID)
	BEGIN
		PRINT 'O id fornecido já existe'
		RETURN
	END

	IF @Nome is null
	BEGIN
		PRINT 'O tipo de peça necessita de um nome'
		RETURN
	END
	
	INSERT INTO STAND.TIPO_PECA VALUES(@Peca_ID, @Nome);
GO

--Atualizar o stock de peças
CREATE PROCEDURE sp_updateStock @Peca_ID INT, @Fabricante VARCHAR(20), @Tipo_Peca INT, @Nome VARCHAR(50) AS
	IF @Peca_ID is null
	BEGIN
		PRINT 'Esta peça não existe'
		EXEC sp_addPart @Fabricante, @Tipo_Peca, @Nome
		RETURN
	END

	DECLARE @Disp as BIT
	SET @Disp = (SELECT Disponibilidade FROM STAND.PECAS WHERE Peca_ID=@Peca_ID)

	IF @Disp = 1
	BEGIN
		SET @Disp = 0
	END
	ELSE
	BEGIN
		SET @Disp = 1
	END

	UPDATE STAND.PECAS SET Disponibilidade = @Disp WHERE Peca_ID = @Peca_ID;
GO

--Adicionar uma oficina
CREATE PROCEDURE sp_addGarage @Oficina_ID INT, @Nome VARCHAR(20), @Contacto VARCHAR(9), @Localizacao VARCHAR(30) AS
	IF @Oficina_ID is null
	BEGIN
		PRINT 'A oficina necessita de ter uma identificação (Oficina_ID)'
		RETURN
	END

	IF EXISTS (SELECT 1 FROM STAND.OFICINA WHERE Oficina_ID = @Oficina_ID)
	BEGIN
		PRINT 'O id fornecido já está associado a uma oficina'
		RETURN
	END

	IF @Nome is null
	BEGIN
		PRINT 'O nome está vazio'
		RETURN
	END 

	IF @Contacto is null
	BEGIN
		PRINT 'O Contacto está vazio'
		RETURN
	END

	IF @Localizacao is null
	BEGIN
		PRINT 'A Localizacao está vazia'
		RETURN
	END

	INSERT INTO STAND.OFICINA VALUES(@Oficina_ID, @Nome, @Contacto, @Localizacao);
GO

--Adicionar um stand
CREATE PROCEDURE sp_addStand @Stand_ID INT, @Nome VARCHAR(20), @Localizacao VARCHAR(9), @Contacto VARCHAR(30), @Website VARCHAR(50) AS
	IF @Stand_ID is null
	BEGIN
		PRINT 'O Stand necessita de ter uma identificação (Stand_ID)'
		RETURN
	END

	IF EXISTS (SELECT 1 FROM STAND.STAND WHERE Stand_ID = @Stand_ID)
	BEGIN
		PRINT 'O id fornecido já está associado a um Stand'
		RETURN
	END

	IF @Nome is null
	BEGIN
		PRINT 'O nome está vazio'
		RETURN
	END 

	IF @Contacto is null
	BEGIN
		PRINT 'O Contacto está vazio'
		RETURN
	END

	IF @Localizacao is null
	BEGIN
		PRINT 'A Localizacao está vazia'
		RETURN
	END

	INSERT INTO STAND.STAND VALUES(@Stand_ID, @Nome, @Localizacao, @Contacto, @Website);
GO

--Atualizar a info de um cliente
CREATE PROCEDURE sp_updateClient @Nome VARCHAR(40), @NIF CHAR(9), @Morada VARCHAR(30), @Contacto CHAR(9) AS
	IF @NIF is null
	BEGIN
		PRINT 'O NIF não pode ser vazio.'
		RETURN
	END

	DECLARE @nifClient AS TINYINT
	SET @nifClient = (SELECT COUNT(STAND.CLIENTE.NIF) AS nifClient FROM STAND.CLIENTE WHERE STAND.CLIENTE.NIF=@NIF)

	DECLARE @nifMechanic AS TINYINT
	SET @nifMechanic = (SELECT COUNT(STAND.MECANICO.NIF) AS nifMechanic FROM STAND.MECANICO WHERE STAND.MECANICO.NIF=@NIF)

	IF (@nifMechanic != 0)
	BEGIN
		PRINT 'Este NIF esta associado a um funcionário'
		RETURN
	END	

	IF (@nifClient = 0)
	BEGIN
		PRINT 'Este NIF não está associado a um cliente'
	END
	ELSE
	BEGIN
		IF @Nome is null
		BEGIN
			PRINT 'O Nome não pode estar vazio'
			RETURN
		END

		IF @Contacto is null
		BEGIN
			PRINT 'O Contacto não pode estar vazio'
			RETURN
		END

		UPDATE STAND.CLIENTE
		SET Nome = @Nome, Morada = @Morada, Contacto = @Contacto
		WHERE NIF = @NIF;
	END
GO

--Atualizar a info de um mecanico
CREATE PROCEDURE sp_updateMechanic @Nome VARCHAR(40), @NIF CHAR(9), @Morada VARCHAR(30), @Contacto CHAR(9), @Oficina_ID INT AS
	IF @NIF is null
	BEGIN
		PRINT 'O NIF não pode ser vazio.'
		RETURN
	END

	DECLARE @nifClient AS TINYINT
	SET @nifClient = (SELECT COUNT(STAND.CLIENTE.NIF) AS nifClient FROM STAND.CLIENTE WHERE STAND.CLIENTE.NIF=@NIF)

	DECLARE @nifMechanic AS TINYINT
	SET @nifMechanic = (SELECT COUNT(STAND.MECANICO.NIF) AS nifMechanic FROM STAND.MECANICO WHERE STAND.MECANICO.NIF=@NIF)	

	IF (@nifClient != 0)
	BEGIN
		PRINT 'Este NIF esta associado a um cliente'
		RETURN
	END	

	IF (@nifMechanic = 0)
	BEGIN
		PRINT 'Este NIF não está associado a um funcionário'
	END
	ELSE
	BEGIN
		IF @Nome is null
		BEGIN
			PRINT 'O Nome não pode estar vazio'
			RETURN
		END

		IF @Contacto is null
		BEGIN
			PRINT 'O Contacto não pode estar vazio'
			RETURN
		END

		UPDATE STAND.MECANICO
		SET Nome = @Nome, Morada = @Morada, Contacto = @Contacto, Oficina_ID = @Oficina_ID
		WHERE NIF = @NIF;
	END
GO

--Atribuir um mecanico a um veiculo (Mecanico e Oficina_ID atribuidos a um tuplo da tabela VEICULO_REPARAR)
CREATE PROCEDURE sp_VehicleToMechanic @Nr_Funcionario INT, @Veiculo_ID INT AS
	DECLARE @mechanic AS INT
	SET @mechanic = (SELECT Nr_Funcionario	FROM STAND.MECANICO WHERE Nr_Funcionario = @Nr_Funcionario);
	IF @Nr_Funcionario is null
	BEGIN
		PRINT 'O número de funcionário dado nao existe'
		RETURN
	END

	DECLARE @id AS INT
	SET @id = (SELECT Chassis_ID FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Veiculo_ID); 
	IF @id is null
	BEGIN
		PRINT 'O id fornecido nao correponde a nenhum veiculo na oficina'
		RETURN
	END 

	DECLARE @Oficina AS INT
	SET @Oficina = (SELECT Oficina_ID FROM STAND.MECANICO WHERE Nr_Funcionario = @Nr_Funcionario)
	IF @Oficina is null
	BEGIN
		PRINT 'Este Mecanico nao tem oficina onde trabalhar'
		RETURN
	END

	UPDATE STAND.VEICULO_REPARAR
	SET Mecanico = @Nr_Funcionario, Oficina_ID = @Oficina
	WHERE Chassis_ID = @Veiculo_ID;
GO 

--Atribuir um mecanico a uma garagem (Oficina_ID é atribuido a um tuplo da tabela MECANICO)
CREATE PROCEDURE sp_MechanicToGarage @Nr_Funcionario INT, @Oficina_ID INT AS
	DECLARE @mechanic AS INT
	SET @mechanic = (SELECT Nr_Funcionario	FROM STAND.MECANICO WHERE Nr_Funcionario = @Nr_Funcionario);
	IF @Nr_Funcionario is null
	BEGIN
		PRINT 'O número de funcionário dado nao existe'
		RETURN
	END

	DECLARE @oficina AS INT
	SET @oficina = (SELECT Oficina_ID FROM STAND.OFICINA WHERE Oficina_ID = @Oficina_ID);
	IF @Oficina_ID is null
	BEGIN
		PRINT 'É necessário um id de uma oficina para associar ao Mecanico'
		RETURN
	END

	UPDATE STAND.MECANICO
	SET Oficina_ID = @Oficina_ID
	WHERE Nr_Funcionario = @Nr_Funcionario;
GO 

--Cliente compra veiculo
CREATE PROCEDURE sp_buyVehicle @Preço INT, @Stand_ID INT, @Veiculo_ID INT, @Cliente INT AS
	DECLARE @id AS INT
	SET @id = (SELECT Chassis_ID FROM STAND.VEICULO_VENDA WHERE Chassis_ID = @Veiculo_ID); 
	IF @id is null
	BEGIN
		PRINT 'O id fornecido nao correponde a nenhum veiculo para venda'
		RETURN
	END 

	DECLARE @stand AS INT
	SET @stand = (SELECT Stand_ID FROM STAND.STAND WHERE Stand_ID = @Stand_ID);
	IF @stand is null
	BEGIN
		PRINT 'É necessário o id do Stand para fazer uma compra'
		RETURN
	END	

	IF @Preço is null
	BEGIN
		PRINT 'O preço do veiculo é necessário para uma compra'
		RETURN
	END

	INSERT INTO STAND.COMPRA VALUES(@Preço, @Stand_ID, @Veiculo_ID);
	DECLARE @transacao as INT
	SET @transacao = (SELECT MAX(Transacao_ID) FROM STAND.COMPRA)
	INSERT INTO STAND.FAZ VALUES(@transacao, @Cliente, NULL);
	INSERT INTO STAND.VEICULOS_CLIENTES(Chassis_ID,Marca,Modelo,Quilometragem,Pais_Origem,Ano_Fabrico,Combustivel,Tracao,Tipo_Veiculo,Potencia,Stand_ID, Cliente_ID)
	(SELECT Chassis_ID,Marca,Modelo,Quilometragem,Pais_Origem,Ano_Fabrico,Combustivel,Tracao,Tipo_Veiculo,Potencia,Stand_ID, @Cliente AS Cliente_ID
	FROM STAND.VEICULO_VENDA WHERE Chassis_ID = @Veiculo_ID);
	DELETE FROM STAND.VEICULO_VENDA WHERE Chassis_ID = @Veiculo_ID;
GO

--Entregar o veiculo ao cliente (isto é, mudar para VEICULOS_REPARADOS)
CREATE PROCEDURE sp_deliverVehicle @Veiculo_ID INT AS
	DECLARE @id AS INT
	SET @id = (SELECT Chassis_ID FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Veiculo_ID); 
	IF @id is null
	BEGIN
		PRINT 'O id fornecido nao correponde a nenhum veiculo nas Oficinas'
		RETURN
	END 

	DECLARE @state AS BIT
	SET @state = (SELECT Estado FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Veiculo_ID);	
	IF @state = 0
	BEGIN
		PRINT 'O veiculo ainda não foi reparado'
		RETURN
	END

	DELETE FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @id;
GO

--Apagar cliente
CREATE PROCEDURE sp_deleteClient @Nr_Cliente INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.CLIENTE WHERE Nr_Cliente = @Nr_Cliente)
	BEGIN
		PRINT 'Não é possivel apagar um cliente que não exista'
		RETURN
	END

	DELETE FROM STAND.CLIENTE WHERE Nr_Cliente = @Nr_Cliente;
GO

--Apagar mecanico
CREATE PROCEDURE sp_deleteMechanic @Nr_Funcionario INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.MECANICO WHERE Nr_Funcionario = @Nr_Funcionario)
	BEGIN
		PRINT 'Não é possivel apagar um mecanico que não exista'
		RETURN
	END

	DELETE FROM STAND.MECANICO WHERE Nr_Funcionario = @Nr_Funcionario;
GO

--Apagar veiculo para venda
CREATE PROCEDURE sp_deleteToSell @Veiculo_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.VEICULO_VENDA WHERE Chassis_ID = @Veiculo_ID)
	BEGIN
		PRINT 'Não é possivel apagar um veiculo que não exista'
		RETURN
	END

	DELETE FROM STAND.VEICULO_VENDA WHERE Chassis_ID = @Veiculo_ID;
GO

--Apagar veiculo para reparar
CREATE PROCEDURE sp_deleteToRepair @Veiculo_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Veiculo_ID)
	BEGIN
		PRINT 'Não é possivel apagar um veiculo que não exista'
		RETURN
	END

	DELETE FROM STAND.VEICULO_REPARAR WHERE Chassis_ID = @Veiculo_ID;
GO

--Apagar veiculo reparado
CREATE PROCEDURE sp_deleteRepaired @Veiculo_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.VEICULOS_REPARADOS WHERE Chassis_ID = @Veiculo_ID)
	BEGIN
		PRINT 'Não é possivel apagar um veiculo que não exista'
		RETURN
	END

	DELETE FROM STAND.VEICULOS_REPARADOS WHERE Chassis_ID = @Veiculo_ID;
GO

--Apagar veiculo do cliente
CREATE PROCEDURE sp_deleteVeiculoCliente @Veiculo_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.VEICULOS_CLIENTES WHERE Chassis_ID = @Veiculo_ID)
	BEGIN
		PRINT 'Não é possivel apagar um veiculo que não exista'
		RETURN
	END

	DELETE FROM STAND.VEICULOS_CLIENTES WHERE Chassis_ID = @Veiculo_ID;
GO

--Apagar oficina
CREATE PROCEDURE sp_deleteGarage @Oficina_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.OFICINA WHERE Oficina_ID = @Oficina_ID)
	BEGIN
		PRINT 'Não é possivel apagar uma oficina que não exista'
		RETURN
	END

	DELETE FROM STAND.OFICINA WHERE Oficina_ID = @Oficina_ID;
GO

--Apagar oficina
CREATE PROCEDURE sp_deleteStand @Stand_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.STAND WHERE Stand_ID = @Stand_ID)
	BEGIN
		PRINT 'Não é possivel apagar um Stand que não exista'
		RETURN
	END

	DELETE FROM STAND.STAND WHERE Stand_ID = @Stand_ID;
GO

--Apagar Peça
CREATE PROCEDURE sp_deletePart @Peca_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.PECAS WHERE Peca_ID = @Peca_ID)
	BEGIN
		PRINT 'Não é possivel apagar uma peça que não exista'
		RETURN
	END

	DELETE FROM STAND.PECAS WHERE Peca_ID = @Peca_ID;
GO

--Apagar Tipo de Peça
CREATE PROCEDURE sp_deletePartType @Peca_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.TIPO_PECA WHERE TipoPeca_ID = @Peca_ID)
	BEGIN
		PRINT 'Não é possivel apagar uma peça que não exista'
		RETURN
	END

	DELETE FROM STAND.TIPO_PECA WHERE TipoPeca_ID = @Peca_ID;
GO

--Apagar Tipo de Veiculo
CREATE PROCEDURE sp_deleteVehicleType @Veiculo_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.TIPO_VEICULO WHERE Veiculo_ID = @Veiculo_ID)
	BEGIN
		PRINT 'Não é possivel apagar uma peça que não exista'
		RETURN
	END

	DELETE FROM STAND.TIPO_VEICULO WHERE Veiculo_ID = @Veiculo_ID;
GO

-- Cliente leva veiculo para reparar
CREATE PROCEDURE sp_takeToRepair @Veiculo_ID INT, @Cliente_ID INT, @Peca_ID INT, @Oficina_ID INT AS
	IF NOT EXISTS (SELECT 1 FROM STAND.OFICINA WHERE Oficina_ID = @Oficina_ID)
	BEGIN
		PRINT 'Não existe uma oficina associada ao id: ' + CAST(@Oficina_ID AS VARCHAR)
	END

	IF NOT EXISTS (SELECT 1 FROM STAND.CLIENTE WHERE Nr_Cliente = @Cliente_ID)
	BEGIN
		PRINT 'Não existe um cliente associado ao id: ' + CAST(@Cliente_ID AS VARCHAR)
	END

	IF NOT EXISTS (SELECT 1 FROM STAND.PECAS WHERE Peca_ID = @Peca_ID)
	BEGIN
		PRINT 'Não existe uma peça associada ao id: ' + CAST(@Peca_ID AS VARCHAR)
	END

	IF NOT EXISTS (SELECT 1 FROM STAND.VEICULOS_CLIENTES WHERE Chassis_ID = @Veiculo_ID AND Cliente_ID = @Cliente_ID)
	BEGIN
		PRINT 'O veiculo com id: ' + CAST(@veiculo_ID AS VARCHAR) + ' não existe ou não está associado ao cliente com id: ' + CAST(@Cliente_ID AS VARCHAR)
		RETURN
	END

	INSERT INTO STAND.VEICULO_REPARAR(Chassis_ID,Marca,Modelo,Quilometragem,Estado,Tipo_Veiculo,Peca_ID,Oficina_ID,Mecanico)
	(SELECT Chassis_ID,Marca,Modelo,Quilometragem,0 AS Estado,Tipo_Veiculo,@Peca_ID AS Peca_ID,@Oficina_ID AS Oficina_ID, null as Mecanico
	FROM STAND.VEICULOS_CLIENTES WHERE Chassis_ID = @Veiculo_ID);
	INSERT INTO STAND.LEVA VALUES(null, @Veiculo_ID, @Cliente_ID);
GO

-- Teste stored procedures
--exec sp_addClient "Marco Silva", "122314453", "Rua de cima", "915122334"
--exec sp_addGarage 4325,"AutoFix2", "234542118", "Albergaria"
--exec sp_addMechanic "Jose Estalo", "432332552", "Rua D.Carlos", "923511543",null,null
--exec sp_addPart "Bosch", 234, "Carburador"
--exec sp_addPartType 1, "Teste Tipo"
--exec sp_addStand 5425, "HotWheels", "Braga", "223415343", "www.hotwheels.com"
--exec sp_addVehicleToRepair 98124, "Audi", "A3", 231954, 0, "1994", 1, 4, null, null
--exec sp_addVehicleToSell 21415, "Ford", "Focus RS", 0, "USA", "2019", "Gasolina", "Integral", 1, "320", 917
--exec sp_addVehicleType 10, "Teste tipo veiculo"
--exec sp_buyVehicle 15000, 917, 21415, 2
--exec sp_deleteClient 6
--exec sp_deleteGarage 4325
--exec sp_deleteMechanic 8
--exec sp_deletePart 52
--exec sp_deleteStand 5425
--exec sp_deleteToRepair 98124
--exec sp_deleteToSell 12351
--exec sp_deleteVeiculoCliente 21415
--exec sp_deliverVehicle 123456
--exec sp_MechanicToGarage 3,21
--exec sp_repairVehicle 8146
--exec sp_VehicleToMechanic 4, 5152, 2
--exec sp_updateStock 4, "Denso", 234, "Radiador"
--exec sp_updateClient "Joana Teste Matias", "134512515", "Vila Nova", 967324512
--exec sp_updateMechanic "Manuel Alvaro", "198472645", "Gondomar", 918284513, 412
--exec sp_takeToRepair 21415,2,10,21;

--exec sp_VehicleToMechanic 2, 21415, 2; associa o mecanico e respetiva oficina ao veiculo que deseja reparar
--exec sp_repairVehicle 21415;	passa o Estado do veiculo na tabela VEICULO_REPARAR para 1 e insere o tuplo na tabela VEICULOS_REPARADOS
--exec sp_deliverVehicle 21415;	elimina o tuplo da tabela VEICULO_REPARAR


--NOTA: assumir que a TABELA VEICULO_REPARAR é todos os veiculos presentes nas oficinas quer estejam reparados ou não
--NOTA: a tabela VEICULOS_REPARADOS so serve para ver que veiculos foram reparados e onde
