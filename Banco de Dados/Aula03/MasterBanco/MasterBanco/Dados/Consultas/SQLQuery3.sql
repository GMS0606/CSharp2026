--Operações Read--
SELECT * FROM Contas

SELECT * FROM Contas
WHERE Saldo > 1000

SELECT * FROM Contas
WHERE Titular Like '%Maria%'
GO

SELECT * FROM Contas
WHERE Numero_da_conta = '1002'

SELECT * FROM Contas
ORDER BY Saldo DESC
GO 

SELECT * FROM Contas
ORDER BY Saldo ASC 
GO 

SELECT COUNT (*) AS TotalContas FROM Contas 

SELECT SUM (Saldo) AS SaldoTotal FROM Contas

SELECT AVG (Saldo) AS MediaSaldos FROM Contas

