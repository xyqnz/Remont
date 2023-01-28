SELECT n_mast, fio, 0 as type FROM MASTER
UNION
SELECT n_mast2 as n_mast, fio, 1 as type FROM MASTER2