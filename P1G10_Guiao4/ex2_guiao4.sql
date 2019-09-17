
CREATE SCHEMA RESERVA_DE_VOOS
go


CREATE TABLE RESERVA_DE_VOOS.AIRPORT (
	airport_code	INT NOT NULL,
	city			VARCHAR(30),
	airp_state		VARCHAR(30),
	airp_name		VARCHAR(30),
	PRIMARY KEY(airport_code)
);

CREATE TABLE RESERVA_DE_VOOS.AIRPLANE_TYPE (
	type_name	VARCHAR(30),
	max_seats	INT NOT NULL,
	company		VARCHAR(30),
	PRIMARY KEY(type_name),
	CHECK(max_seats > 0)
);

CREATE TABLE RESERVA_DE_VOOS.AIRPLANE (
	airplane_id			INT,
	total_no_of_seats	INT NOT NULL,
	airplane_type		VARCHAR(30) NOT NULL,
	PRIMARY KEY(airplane_id),
	FOREIGN KEY(airplane_type) REFERENCES RESERVA_DE_VOOS.AIRPLANE_TYPE(type_name),
	CHECK(total_no_of_seats > 0)
);

CREATE TABLE RESERVA_DE_VOOS.FLIGHT (
	number_flight	INT,
	airline			VARCHAR(30)  NOT NULL,
	weekdays		VARCHAR(150),
	PRIMARY KEY(number_flight)
);

CREATE TABLE RESERVA_DE_VOOS.FLIGHT_LEG (
	leg_no			INT,	number_flight	INT,	dep_airport		INT NOT NULL,	dep_time		TIME NOT NULL,	arriv_airport	INT NOT NULL,	arriv_time		TIME NOT NULL,
	PRIMARY KEY(leg_no, number_flight),
	FOREIGN KEY(number_flight) REFERENCES RESERVA_DE_VOOS.FLIGHT(number_flight),
	FOREIGN KEY(dep_airport) REFERENCES RESERVA_DE_VOOS.AIRPORT(airport_code),
	FOREIGN KEY(arriv_airport) REFERENCES RESERVA_DE_VOOS.AIRPORT(airport_code),
	CHECK(number_flight > 0)
);

CREATE TABLE RESERVA_DE_VOOS.FARE (
	code			INT,
	flight			INT,
	amount			MONEY NOT NULL,
	restrictions	VARCHAR(30),
	PRIMARY KEY(code, flight),
	FOREIGN KEY(flight) REFERENCES RESERVA_DE_VOOS.FLIGHT(number_flight),
	CHECK(amount >= 0)
);

CREATE TABLE RESERVA_DE_VOOS.LEG_INSTANCE (
	leg_date			DATE,	
	leg_no				INT,
	number_flight		INT,
	available_seats		INT,
	airplane			INT NOT NULL,
	dep_airport			INT NOT NULL,
	dep_time			TIME NOT NULL,
	arriv_airport		INT NOT NULL,
	arriv_time			TIME NOT NULL,
	PRIMARY KEY(leg_date, leg_no, number_flight),
	FOREIGN KEY(leg_no, number_flight) REFERENCES RESERVA_DE_VOOS.FLIGHT_LEG(leg_no, number_flight),
	FOREIGN KEY(airplane) REFERENCES RESERVA_DE_VOOS.AIRPLANE(airplane_id),
	FOREIGN KEY(dep_airport) REFERENCES RESERVA_DE_VOOS.AIRPORT(airport_code),
	FOREIGN KEY(arriv_airport) REFERENCES RESERVA_DE_VOOS.AIRPORT(airport_code)
);

CREATE TABLE RESERVA_DE_VOOS.SEAT (
	seat_no			INT,
	leg_date		DATE NOT NULL,
	leg_no			INT NOT NULL,
	number_flight	INT NOT NULL,
	customer_name	VARCHAR(30) NOT NULL,
	cphone			VARCHAR(9) NOT NULL,
	PRIMARY KEY(seat_no, leg_date, leg_no, number_flight),
	FOREIGN KEY(leg_date, leg_no, number_flight) 
	REFERENCES RESERVA_DE_VOOS.LEG_INSTANCE(leg_date, leg_no, number_flight)
);

CREATE TABLE RESERVA_DE_VOOS.CAN_LAND (
	airport_code 	INT,
	type_name		VARCHAR(30),
	PRIMARY KEY(airport_code, type_name),
	FOREIGN KEY(airport_code) REFERENCES RESERVA_DE_VOOS.AIRPORT(airport_code),
	FOREIGN KEY(type_name) REFERENCES RESERVA_DE_VOOS.AIRPLANE_TYPE(type_name)
);
