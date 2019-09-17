use p1g10;
go

CREATE TRIGGER trg_updateTransaction on STAND.FAZ AFTER INSERT AS
BEGIN
	UPDATE STAND.FAZ SET Data_Compra = GETDATE() FROM STAND.FAZ f JOIN Inserted i ON f.Transacao = i.Transacao;
END;
GO

CREATE TRIGGER trg_updateVehicleToMechanic on STAND.LEVA AFTER INSERT AS
BEGIN
	UPDATE STAND.LEVA SET Data_Entrega = GETDATE() FROM STAND.LEVA l JOIN Inserted i ON l.Veiculo_ID = i.Veiculo_ID;
END;