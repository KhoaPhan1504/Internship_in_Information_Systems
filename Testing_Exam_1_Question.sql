-- Câu 2:
SELECT C.`Name`, C.Phone, C.Email, C.Address, COUNT( CO.Amount)
FROM CUSTOMER C
JOIN CAR_ORDER CO ON C.CustomerID = CO.CustomerID
GROUP BY CO.Amount ASC;


-- Câu 3:
DROP PROCEDURE IF EXISTS Max_sell;
DELIMITER $$
CREATE PROCEDURE Max_sell()
BEGIN
	SELECT C.Maker, SUM(CO.Amount) SL
    FROM CAR C
    INNER JOIN CAR_ORDER CO ON C.CarID = CO.CarID
	where CO.`status` = 1 and Year(CO.DeliveryDate) = Year(now())
    GROUP BY C.Maker
    HAVING SUM(CO.Amount) = (SELECT MAX(A)
							FROM (SELECT SUM(COB.Amount) AS A
							FROM CAR_ORDER COB
							INNER JOIN CAR CB ON CB.CarID = COB.CarID
                            where COB.`status` = 1 and Year(COB.DeliveryDate) = Year(now())
							GROUP BY MAKER) AS Max_s);
END $$
DELIMITER ;
CALL Max_sell;

-- Câu 4:
DROP PROCEDURE IF EXISTS Delete_Order;
DELIMITER $$
CREATE PROCEDURE Delete_Order()
	BEGIN	
			SELECT * FROM CAR_ORDER
            WHERE `Status` = 2 AND YEAR(NOW()) > YEAR(OrderDate);
			DELETE FROM CAR_ORDER 
            WHERE `Status` = 2 AND YEAR(NOW()) > YEAR(OrderDate);
	END $$
DELIMITER ;
CALL Delete_Order;

-- Câu 5:
DROP PROCEDURE IF EXISTS data_cus;
DELIMITER $$
CREATE PROCEDURE data_cus(IN in_customerID TINYINT)
BEGIN
    SELECT CU.Name, CO.OrderID, CO.Amount, C.Maker
    FROM CAR_ORDER CO
    INNER JOIN CUSTOMER CU ON CU.CustomerID = CO.CustomerID
    INNER JOIN CAR C ON C.CarID = CO.CarID
    WHERE CU.CustomerID = in_customerID AND (CO.Status = 0 OR CO.Status = 1);
END $$
DELIMITER ;

-- Câu 6:
DROP TRIGGER IF EXISTS trigger_check_infor;
DELIMITER $$
	CREATE TRIGGER trigger_check_infor
    BEFORE INSERT ON CAR_ORDER
    FOR EACH ROW
    BEGIN
			IF (NEW.DeliveryDate < DATE_SUB(NEW.OrderDate, INTERVAL -15 DAY)) THEN
				SIGNAL SQLSTATE '12345'
            		SET MESSAGE_TEXT = 'Cannot insert data';
				END IF; 
	END$$
DELIMITER ;
INSERT INTO		CAR_ORDER(CustomerID,	CarID,	Amount,	  SalePrice,   OrderDate   ,     DeliveryDate, 	DeliveryAddress ,`Status`,		Note)
VALUES                   (    5     ,	  3  ,	  1   ,	   5.000000,   '2022-03-03',	 '2022-03-10',	'THAI NGUYEN'   ,	2    ,	   '123')
				