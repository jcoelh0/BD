use p1g10;
GO
INSERT INTO STAND.TIPO_VEICULO VALUES
(1, 'Ligeiro'),
(2, 'Motociclo'),
(3, 'Pesado de Passageiros'),
(4, 'Pesado de Mercadorias'),
(5, 'Veiculo Agricola'),
(6, 'Quadriciclo');

INSERT INTO STAND.TIPO_PECA VALUES
(234, 'Motor e Componentes'),
(482, 'Componentes Eletricos e Eletronicos'),
(559, 'Interiores'),
(570, 'Carroçaria'),
(657, 'Iluminação'),
(663, 'Vidros'),
(147, 'Suspensão'),
(798, 'Travagem'),
(957, 'Pneus de Ligeiro'),
(958, 'Pneus de Motociclo'),
(959, 'Pneus de Pesado'),
(960, 'Pneus de Quadriciclo'),
(961, 'Pneus de Veiculo Agricola'),
(374, 'Outros');

-- Disponibilidade: 1 -> Disponivel, 0 -> Indisponivel
INSERT INTO STAND.PECAS VALUES
('Bosch', 1, 234,'Filtro de Oleo'),
('Bosch', 1, 234, 'Filtro de Combustivel'),
('Bosch', 1, 234, 'Filtro de Ar'),
('Denso', 0, 234, 'Radiador'),
('VAICO', 0, 234, 'Carter do oleo'),
('Bosch', 0, 482, 'Buzina'),
('Bosch', 1, 482, 'Alternador'),
('Bosch', 1, 482, 'Distribuidor'),
('Norauto', 1, 482, 'Bateria'),
('Bosch', 1, 482, 'Motor de arranque'),
('TRW', 1, 147, 'Amortecedor'),
('Arnott', 0, 147, 'Mola pneumática'),
('Ridex', 0, 147, 'Mola de suspensão'),
('SKF', 1, 147, 'Apoio de amortecedor'),
('Eibach', 1, 147, 'Kit de suspensão, molas e amortecedores'),
('Abakus', 1, 559, 'Elevador de vidro'),
('Valeo', 0, 559, 'Mola de enrolamento, airbag'),
('Valeo', 1, 559, 'Sistema de assistência ao estacionamento'),
('Esen SKV', 1, 559, 'Fechadura da porta'),
('ERA', 0, 559, 'Comutador na coluna de direção'),
('Ridex', 1, 570, 'Mola pneumática mala'),
('Blic', 0, 570, 'Para-choques dianteiro'),
('TYE', 1, 570, 'Vidro do espelho retrovisor (esquerdo/direito)'),
('Blic', 1, 570, 'Puxador da porta'),
('Klokkerholm', 1, 570, 'Para-lamas'),
('TYE', 1, 657, 'Farol principal (esquerdo/direito)'),
('TYE', 1, 657, 'Farolim (esquerdo/direito)'),
('Hella', 1, 657, 'Luz de chapa da matricula'),
('Alkar', 0, 657, 'Farol de nevoeiro'),
('Abakus', 1, 657, 'Pisca (esquerdo/direito)'),
('SafeGlass', 1, 663, 'Vidro dianteiro'),
('SafeGlass', 0, 663, 'Vidro traseiro'),
('SafeGlass', 1, 663, 'Vidro frente-esquerdo'),
('SafeGlass', 1, 663, 'Vidro frente-direito'),
('SafeGlass', 0, 663, 'Vidro trás-esquerdo'),
('SafeGlass', 1, 663, 'Vidro trás-direito'),
('Brembo', 1, 798, 'Disco de travão'),
('Brembo', 1, 798, 'Jogo de pastilhas para travão de disco'),
('Ridex', 0, 798, 'Pinça de travão'),
('Castrol', 1, 798, 'Liquido dos travões (1L)'),
('LPR', 0, 798, 'Cilindro do travão'),
('Goodride', 1, 957, 'RP28'),
('Pirelli', 1, 957, 'Cinturato Winter'),
('Michelin', 1, 958, 'Pilot Road 4'),
('Michelin', 1, 958, 'Pilot Power Rear'),
('Bridgestone', 1, 958, 'Battlax BT 016 Pro Front'),
('Bridgestone', 1, 958, 'Battlax BT 016 Pro Rear'),
('Continental', 0, 957, 'SportContact'),
('Sun-F', 1, 960, 'A-027'),
('Vee Rubber', 1, 960, 'VRM330'),
('MAXI TRACTION', 1, 961, '65 Back'),
('RIB', 1, 961, '12 4 PR TT Front');

-- Estado: 1 -> Reparado, 0 -> Por Reparar
INSERT INTO STAND.VEICULO_REPARAR VALUES
(123456, 'Ford', 'Focus', 134628, 0, 1, 223, 1124, 22),
(345231, 'Yamaha', 'R1', 23453, 0, 2, 250, 1124, 26),
(09823, 'Daf', 'XF105', 789324, 0, 4, 234, 21, 27),
(8146, 'Man', 'R13', 453298, 0, 3, 219, 21, 24),
(41344, 'Kawasaki', 'Z125', 12367, 0, 2, 225, 412, 25),
(5152, 'Ford', '8970', 7843, 0, 5, 244, 21, 23),
(97623, 'Ranger', '800w', 1923, 0, 6, 247, 412, 27);

INSERT INTO STAND.VEICULO_VENDA VALUES
(58974, 'Citroen', 'C4', 24031, 'França', '2006', 'Gasolina', 'Frontal', 1, 110, 1123),
(12317, 'Honda', 'Civic', 0, 'Japão', '2019', 'Gasolina', 'Frontal', 1, 160, 1123),
(92342, 'BMW', 'R', 79000, 'Alemanha', '2008', 'Gasolina', 'Traseira', 2, 105, 917),
(89721, 'Mercedes-Benz', 'C63 AMG', 0, 'Alemanha', '2019', 'Gasolina', 'Traseira', 1, 510, 1123),
(18767, 'Harley-Davidson', 'FXDR', 0, 'USA', 2019, 'Gasolina', 'Traseira', 2, 142, 917),
(52452, 'Scania', 'HGV', 0, 'Suécia', 2019, 'Gasóleo', 'Traseira', 4, 570, 542),
(87171, 'Daf', 'XF', 543429, 'Holanda', 2015, 'Gasóleo', 'Traseira', 4, 480, 542),
(56551, 'Mercedes-Benz', 'Tourismo RHD', 0, 'Alemanha', 2017, 'Gasóleo', 'Traseira', 3, 630, 542),
(74372, 'Iveco', 'Magelys', 424132, 'Itália', 2015, 'Gasóleo', 'Traseira', 3, 540, 542),
(71414, 'Lamborghini', 'Spark 130VRT', 0, 'Itália', 2019, 'Gasóleo', 'Traseira', 5, 127, 542),
(89611, 'John Deere', '6155R', 12445, 'USA', 2013, 'Gasóleo', 'Traseira', 5, 159, 542),
(12351, 'Suzuki', 'KingQuad750', 1254, 'Japan', 2009, 'Gasolina', 'Traseira', 6, 120, 917),
(15436, 'Kawasaki', 'Brute Force 300 MY', 0, 'Japan', 2017, 'Gasolina', 'Traseira', 6, 114, 917);

INSERT INTO STAND.CLIENTE VALUES
('Carlos Silva', 141244123, NULL, 921827364),
('Joana Marques', 345234786, 'Estarreja', 967843421),
('Roberto Dias', 542555266, NULL, 913415233),
('Catia Silva', 198741624, 'Guarda', 934172856),
('Joana Matias', 134512515, 'Vila Real', 967324512),
('Ines Costa', 189746242, 'Mangualde', 918273465),
('André Esteves', 124525494, 'Lisboa', 924562534),
('Beatriz Coutinho', 178435901, NULL, 935721841);

INSERT INTO STAND.MECANICO(Nome, NIF, Morada, Contacto, Oficina_ID) VALUES
('José Matias', 231425987, 'Aveiro', 912345678, 1124),
('Diogo Silva', 241532654, 'Vagos', 934576981, 1124),
('Manuel Alvaro', 198472645, 'Gondomar', 918284513, 412),
('Teotonio Ramalho', 174892034, 'Setubal', 967843281, 21),
('Alberto Saraiva', 213456749, 'Vila Nova de Gaia', 925648102, 412),
('Juan Roberto', 257900123, 'Montijo', 91234718, 21);

INSERT INTO STAND.LEVA VALUES
('2019-04-24', 8146, 51),
('2019-04-20', 123456, 45),
('2019-04-27', 9823, 50),
('2019-04-30', 345231, 46),
('2019-05-4', 41344, 47),
('2019-05-15', 5152, 46),
('2019-05-23', 97623, 49);

INSERT INTO STAND.COMPRA VALUES
(24500, 1123, 5844),
(18990, 1123, 534),
(58700, 917, 4),
(784570, 542, 74);

INSERT INTO STAND.FAZ VALUES
(21, 44, '2019-01-12'),
(22, 47, '2019-04-04'),
(23, 50, '2019-05-16'),
(24, 49, '2019-05-31');

INSERT INTO STAND.STAND VALUES
(1123, 'AutoMaster', 'Cacia', 234542768, 'www.automaster.pt'),
(542, 'TruckHouse', 'Vila Real', 259141544, 'www.truckhouse.pt'),
(917, 'BikeDealer', 'Guarda', 215523907, 'www.bikedealer.pt');

INSERT INTO STAND.OFICINA VALUES
(1124, 'AutoOficina', 234542769, 'Esgueira'),
(412, 'AutoFix', 224413853, 'Vila Nova de Gaia'),
(21, 'TruckStation', 213567412, 'Setubal');

INSERT INTO STAND.VEICULOS_CLIENTES VALUES
(5844, 'Citroen', 'C5', 2031, 'França', '2006', 'Gasolina', 'Frontal', 1, 110, 1123, 44),
(534, 'Ford', 'Fiesta', 51231, 'USA', '2013', 'Gasolina', 'Frontal', 1, 119, 1123, 47),
(4, 'Yamaha', 'MT-125', 1231, 'Japão', '2019', 'Gasolina', 'Traseira', 2, 15, 917, 50),
(74, 'John-Deere', '9RX', 24154, 'USA', '2017', 'Gasolina', 'Traseira', 5, 110, 542, 49);

INSERT INTO STAND.VEICULOS_REPARADOS VALUES
(1451, 'Peugeot', '3008', 155144, 1, 210, 1124, 48),
(54432, 'BMW', 'z4', 12513, 1, 222, 1124, 52);
