CREATE TABLE SALESMANLOGIN (
	SL INT PRIMARY KEY IDENTITY(1,1), USER_NAME VARCHAR(10), PASSWORD VARCHAR(10) NOT NULL UNIQUE 
);
/*LOGIN TABLE CREATE CONNET WITH LOGIN FORM TO MATCH USER_ID AND PASSWORD TO ALLOW LOGIN
IDENTITY IS USE TO AUTO INCREMENT THE SL VALUE	START WITH 1 AND INCREMENT BY 1
*/

INSERT INTO SALESMANLOGIN VALUES(
'ADAM','582456'
);

INSERT INTO SALESMANLOGIN VALUES(
'SAMANTA','788562'
);


SELECT *FROM SALESMANLOGIN;