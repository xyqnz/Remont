SELECT naimen, stoim from USLUGI where stoim between 2500 and 4000;
SELECT * FROM Remont WHERE data < '2023-11-23';
SELECT * FROM Avto WHERE marka LIKE 'Subaru%';
SELECT SUM(sum) FROM Remont;
SELECT MAX(sum), MIN(sum) from REMONT;
SELECT COUNT(n_avto) FROM Remont;
select n_avto, SUM(sum) from Remont group by n_avto;
select * from Avto where god in(2009,2016,2006,345);
select * from MASTER where fio LIKE N'%Сидоров%';
select n_avto, AVG (sum) from Remont group by n_avto having COUNT (*)>1;
INSERT INTO MASTER VALUES (11, 'Маклаков', 'мастер')
UPDATE USLUGI SET STOIM = 2900 WHERE n_usl = 1
DELETE FROM MASTER WHERE n_mast = 5