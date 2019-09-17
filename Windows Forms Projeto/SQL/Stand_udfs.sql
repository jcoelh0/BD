use p1g10;
go

-- Retorna todos os clientes dos stands e oficinas
CREATE FUNCTION STAND.AllClients() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.CLIENTE
	);
GO

-- Retorna todos os mecanicos
CREATE FUNCTION STAND.AllMechanics() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.MECANICO
	);
GO

-- Retorna todos os mecanicos disponiveis

CREATE FUNCTION STAND.AvailableMechanics() RETURNS TABLE AS 
	RETURN(
		SELECT Nome, NIF, Morada, Contacto, Nr_Funcionario, MECANICO.Oficina_ID
		FROM STAND.MECANICO WHERE MECANICO.Nr_Funcionario NOT IN (SELECT Mecanico FROM STAND.VEICULO_REPARAR)
	);
GO

-- Retorna todos os mecanicos ocupados
CREATE FUNCTION STAND.OccupiedMechanics() RETURNS TABLE AS 
	RETURN(
		SELECT Nome, NIF, Morada, Contacto, Nr_Funcionario, MECANICO.Oficina_ID
		FROM STAND.MECANICO WHERE MECANICO.Nr_Funcionario IN (SELECT Mecanico FROM STAND.VEICULO_REPARAR)
	);
GO

-- Retorna todas as peças
CREATE FUNCTION STAND.AllParts() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.PECAS
	);
GO

-- Retorna todas as peças disponiveis
CREATE FUNCTION STAND.AvailableParts() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.PECAS WHERE Disponibilidade = 1
	);
GO

-- Retorna todas as peças indisponiveis
CREATE FUNCTION STAND.UnavailableParts() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.PECAS WHERE Disponibilidade = 0
	);
GO

-- Retorna todos os veiculos dos stands
CREATE FUNCTION STAND.AllStandVehicles() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.VEICULO_VENDA
	);
GO

-- Retorna todos os veiculos novos
CREATE FUNCTION STAND.AllNewVehicles() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.VEICULO_VENDA WHERE Quilometragem = 0
	);
GO

-- Retorna todos os veiculos usados
CREATE FUNCTION STAND.AllUsedVehicles() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.VEICULO_VENDA WHERE Quilometragem != 0
	);
GO

-- Retorna todos os veiculos das oficinas
CREATE FUNCTION STAND.AllGarageVehicles() RETURNS TABLE AS 
	RETURN(
		SELECT Chassis_ID, Marca, Modelo, Quilometragem, Estado, Tipo_Veiculo, VEICULO_REPARAR.Oficina_ID, Mecanico
		FROM STAND.VEICULO_REPARAR JOIN STAND.OFICINA
		ON VEICULO_REPARAR.Oficina_ID = OFICINA.Oficina_ID
	);	
GO

-- Retorna todos os veiculos reparados
CREATE FUNCTION STAND.RepairedVehicles() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.VEICULO_REPARAR WHERE Estado = 1
	);
GO

-- Retorna todos os veiculos por reparar
CREATE FUNCTION STAND.ToRepairVehicles() RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.VEICULO_REPARAR
		WHERE Estado = 0
	);
GO

-- Retorna todos os veiculos
CREATE FUNCTION STAND.AllVehicles() RETURNS TABLE AS 
	RETURN(
		SELECT 'Reparar' AS  Type, Chassis_ID, Marca, Modelo, Tipo_Veiculo
		FROM STAND.VEICULO_REPARAR 
		UNION
		SELECT 'Vender' AS Type, Chassis_ID, Marca, Modelo, Tipo_Veiculo
		FROM STAND.VEICULO_VENDA
		UNION
		SELECT 'Reparados' AS Type, Chassis_ID, Marca, Modelo, Tipo_Veiculo
		FROM STAND.VEICULOS_REPARADOS
		UNION
		SELECT 'Veiculos_Clientes' AS Type, Chassis_ID, Marca, Modelo, Tipo_Veiculo
		FROM STAND.VEICULOS_CLIENTES
	);
GO

-- Retorna todos os veiculos do cliente correspondente ao ID dado
CREATE FUNCTION STAND.ClientVehicles(@Cliente INT) RETURNS TABLE AS
	RETURN(
		SELECT Chassis_ID, Marca, Modelo, Tipo_Veiculo
		FROM STAND.VEICULOS_CLIENTES WHERE Cliente_ID = @Cliente
		UNION
		SELECT Chassis_ID, Marca, Modelo, Tipo_Veiculo
		FROM STAND.VEICULOS_REPARADOS WHERE Cliente_ID = @Cliente
	);
GO

-- Retorna todos os veiculos de todos os clientes
CREATE FUNCTION STAND.AllClientVehicles() RETURNS TABLE AS
	RETURN(
		SELECT Chassis_ID, Marca, Modelo, Tipo_Veiculo, Cliente_ID
		FROM STAND.VEICULOS_CLIENTES
		UNION
		SELECT Chassis_ID, Marca, Modelo, Tipo_Veiculo, Cliente_ID
		FROM STAND.VEICULOS_REPARADOS
	);
GO

-- Retorna todos os veiculos de um certo tipo (Recebe o ID do tipo como argumento)
CREATE FUNCTION STAND.VehicleByType(@Veiculo INT) RETURNS TABLE AS
	RETURN(
		SELECT 'Para Reparar' AS Type, Chassis_ID,Marca,Modelo FROM STAND.VEICULO_REPARAR WHERE Tipo_Veiculo = @Veiculo
		UNION
		SELECT 'Para Venda' AS Type, Chassis_ID,Marca,Modelo FROM STAND.VEICULO_VENDA WHERE Tipo_Veiculo = @Veiculo
		UNION
		SELECT 'Dos Clientes' AS Type, Chassis_ID,Marca,Modelo FROM STAND.VEICULOS_CLIENTES WHERE Tipo_Veiculo = @Veiculo
		UNION
		SELECT 'Repararados' AS Type, Chassis_ID,Marca,Modelo FROM STAND.VEICULOS_REPARADOS WHERE Tipo_Veiculo = @Veiculo
	);
GO

-- Retorna todos os veiculos que nao tem mecanico associado
CREATE FUNCTION STAND.ToRepairNoMechanic() RETURNS TABLE AS
	RETURN(
		SELECT Chassis_ID,Marca,Modelo 
		FROM STAND.VEICULO_REPARAR 
		WHERE Mecanico IS NULL
	);
GO

-- Retorna todos os veiculos reparados de um cliente
CREATE FUNCTION STAND.RepairedOfCliente(@Cliente INT) RETURNS TABLE AS
	RETURN(
		SELECT Chassis_ID, Marca, Modelo, 
			(CASE 
				WHEN STAND.VEICULOS_REPARADOS.Peca_ID is null THEN 'Nenhuma Peça'
				ELSE STAND.PECAS.Nome
			END) AS 'Peça Trocada'
		FROM STAND.VEICULOS_REPARADOS LEFT JOIN STAND.PECAS ON VEICULOS_REPARADOS.Peca_ID = PECAS.Peca_ID
		WHERE Cliente_ID = @Cliente
	);
GO 

-- Retorna todos os veiculos por reparar de um mecanico
CREATE FUNCTION STAND.ToRepairVehiclesByMec(@Mec INT) RETURNS TABLE AS 
	RETURN(
		SELECT *
		FROM STAND.VEICULO_REPARAR
		WHERE Estado = 0 AND Mecanico = @Mec
	);
GO

--Teste as funções
--SELECT * FROM STAND.AllClients();
--SELECT * FROM STAND.AllGarageVehicles();
--SELECT * FROM STAND.AllNewVehicles();
--SELECT * FROM STAND.AllParts();
--SELECT * FROM STAND.AllStandVehicles();
--SELECT * FROM STAND.AllUsedVehicles();
--SELECT * FROM STAND.AllVehicles();
--SELECT * FROM STAND.AvailableParts();
--SELECT * FROM STAND.ClientVehicles(3);
--SELECT * FROM STAND.AllMechanics();
--SELECT * FROM STAND.OccupiedMechanics();
--SELECT * FROM STAND.AvailableMechanics();
--SELECT * FROM STAND.ToRepairVehicles();
--SELECT * FROM STAND.RepairedVehicles();
--SELECT * FROM STAND.UnavailableParts();
--SELECT * FROM STAND.VehicleByType(1);
--SELECT * FROM STAND.AllClientVehicles();
--SELECT * FROM STAND.ToRepairNoMechanic();
--SELECT * FROM STAND.RepairedOfCliente(7);
