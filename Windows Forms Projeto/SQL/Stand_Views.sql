use p1g10;
GO

--Listagem de todos os clientes dos Stands e oficinas
CREATE VIEW AllClients AS
SELECT Nome, NIF, Morada, Contacto, Nr_Cliente
FROM STAND.CLIENTE;
GO

--Listagem de todos os mecânicos das Oficinas
CREATE VIEW AllMechanics AS
SELECT MECANICO.Nome, NIF, Morada, MECANICO.Contacto, Nr_Funcionario, MECANICO.Oficina_ID
FROM STAND.MECANICO JOIN STAND.OFICINA
ON MECANICO.Oficina_ID = OFICINA.Oficina_ID;
GO

--Listagem de todos os mecânicos disponíveis
CREATE VIEW AvailableMechanics AS
SELECT Nome, NIF, Morada, Contacto, Nr_Funcionario, MECANICO.Oficina_ID
FROM STAND.MECANICO WHERE MECANICO.Nr_Funcionario NOT IN (SELECT Mecanico FROM STAND.VEICULO_REPARAR);
GO

--Listagem de todos os mecânicos ocupados
CREATE VIEW OccupiedMechanics AS
SELECT Nome, NIF, Morada, Contacto, Nr_Funcionario, MECANICO.Oficina_ID
FROM STAND.MECANICO WHERE MECANICO.Nr_Funcionario IN (SELECT Mecanico FROM STAND.VEICULO_REPARAR);
GO

--Listagem de todas as peças
CREATE VIEW AllParts AS
SELECT Peca_ID, Nome, Fabricante, Disponibilidade, Tipo_Peca
FROM STAND.PECAS;
GO

--Listagem de todas as peças disponíveis
CREATE VIEW AvailableParts AS
SELECT Peca_ID, Nome, Fabricante, Tipo_Peca
FROM STAND.PECAS WHERE PECAS.Disponibilidade = 1;
GO

--Listagem de todas as peças indisponíveis
CREATE VIEW UnavailableParts AS
SELECT Peca_ID, Nome, Fabricante, Tipo_Peca
FROM STAND.PECAS WHERE PECAS.Disponibilidade = 0;
GO

--Listagem de todos os veiculos dos Stands
CREATE VIEW AllStandVehicles AS
SELECT Chassis_ID, Marca, Modelo, Quilometragem, Pais_Origem, Ano_Fabrico, Combustivel, Tracao, Tipo_Veiculo, Potencia, VEICULO_VENDA.Stand_ID
FROM STAND.VEICULO_VENDA JOIN STAND.STAND
ON VEICULO_VENDA.Stand_ID = STAND.Stand_ID;
GO

--Listagem de todos os veiculos novos dos Stands
CREATE VIEW AllNewVehicles AS
SELECT Chassis_ID, Marca, Modelo, Pais_Origem, Ano_Fabrico, Combustivel, Tracao, Tipo_Veiculo, Potencia, VEICULO_VENDA.Stand_ID
FROM STAND.VEICULO_VENDA JOIN STAND.STAND
ON VEICULO_VENDA.Stand_ID = STAND.Stand_ID
WHERE VEICULO_VENDA.Quilometragem = 0;
GO

--Listagem de todos os veiculos usados dos Stands
CREATE VIEW AllUsedVehicles AS
SELECT Chassis_ID, Marca, Modelo, Pais_Origem, Ano_Fabrico, Combustivel, Tracao, Tipo_Veiculo, Potencia, VEICULO_VENDA.Stand_ID
FROM STAND.VEICULO_VENDA JOIN STAND.STAND
ON VEICULO_VENDA.Stand_ID = STAND.Stand_ID
WHERE VEICULO_VENDA.Quilometragem != 0;
GO

--Listagem de todos os veiculos nas Oficinas
CREATE VIEW AllGarageVehicles AS
SELECT Chassis_ID, Marca, Modelo, Quilometragem, Tipo_Veiculo, Peca_ID, VEICULO_REPARAR.Oficina_ID, Mecanico
FROM STAND.VEICULO_REPARAR JOIN STAND.OFICINA
ON VEICULO_REPARAR.Oficina_ID = OFICINA.Oficina_ID;
GO

--Listagem de todos os veiculos reparados nas Oficinas
CREATE VIEW RepairedVehicles AS
SELECT Chassis_ID, Marca, Modelo, Quilometragem, Tipo_Veiculo, Peca_ID, VEICULOS_REPARADOS.Oficina_ID, Mecanico
FROM STAND.VEICULOS_REPARADOS JOIN STAND.OFICINA
ON VEICULOS_REPARADOS.Oficina_ID = OFICINA.Oficina_ID;
GO

--Listagem de todos os veiculos reparados nas Oficinas
CREATE VIEW ToRepairVehicles AS
SELECT Chassis_ID, Marca, Modelo, Quilometragem, Tipo_Veiculo, Peca_ID, VEICULO_REPARAR.Oficina_ID, Mecanico
FROM STAND.VEICULO_REPARAR JOIN STAND.OFICINA
ON VEICULO_REPARAR.Oficina_ID = OFICINA.Oficina_ID
WHERE VEICULO_REPARAR.Estado = 0;
GO

--Listagem de todos os veiculos
CREATE VIEW AllVehicles AS
SELECT 'Reparar' AS  Type, Chassis_ID, Marca, Modelo, Tipo_Veiculo
FROM STAND.VEICULO_REPARAR 
UNION
SELECT 'Vender' AS Type, Chassis_ID, Marca, Modelo, Tipo_Veiculo
From STAND.VEICULO_VENDA
UNION
SELECT 'Reparados' AS Type, Chassis_ID, Marca, Modelo, Tipo_Veiculo
From STAND.VEICULOS_REPARADOS
UNION
SELECT 'Veiculos_Clientes' AS Type, Chassis_ID, Marca, Modelo, Tipo_Veiculo
From STAND.VEICULOS_CLIENTES;
GO

--Listagem de todos os veiculos dos clientes
CREATE VIEW AllClientVehicles AS
SELECT Chassis_ID, Marca, Modelo, Tipo_Veiculo, Cliente_ID
FROM STAND.VEICULOS_CLIENTES
GO

--Teste das views
--SELECT * FROM AllClients;
--SELECT * FROM AllGarageVehicles;
--SELECT * FROM AllMechanics;
--SELECT * FROM AllNewVehicles;
--SELECT * FROM AllClientVehicles;
--SELECT * FROM AllParts;
--SELECT * FROM AllStandVehicles;
--SELECT * FROM AllUsedVehicles;
--SELECT * FROM AllVehicles;
--SELECT * FROM AvailableMechanics;
--SELECT * FROM AvailableParts;
--SELECT * FROM OccupiedMechanics;
--SELECT * FROM RepairedVehicles;
--SELECT * FROM ToRepairVehicles;
--SELECT * FROM UnavailableParts;
