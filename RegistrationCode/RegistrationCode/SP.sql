declare @GeneratedCode varchar(6)
exec pGenerateMemberCode @GeneratedCode


Text
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC [dbo].[pGenerateMemberCode]
 @GeneratedCode varchar(6) OUTPUT
as
BEGIN


--DECLARE @GeneratedCode VARCHAR(6)

DECLARE @tmpTable TABLE (chars varchar(1))
INSERT INTO @tmpTable VALUES ('A'),('E'),('I'),('O'),('U') --vowel 

--select * from #tmpTable
--CREATE TABLE #tmpTable (chars varchar(1))
INSERT INTO @tmpTable VALUES ('B'),('C'),('D'),('F'),('G'),('H'),('J'),('K'),('L'),('M'),('N'),('P'),('Q'),('R'),('S'),('T'),('V'),('W'),('X'),('Y'),('Z') --consonant
INSERT INTO @tmpTable VALUES (0),(1),(2),(3),(4),(5),(6),(7),(8),(9) -- number

--select * from #tmpTable

DECLARE @tmpTable2 TABLE (chars varchar(1))
INSERT INTO @tmpTable2 VALUES (0),(1),(2),(3),(4),(5),(6),(7),(8),(9)

SELECT
@GeneratedCode = v1.chars + c1.chars + c2.chars + n2.chars + n3.chars + n4.chars --AS Result

FROM (SELECT TOP 1 chars FROM @tmpTable2 ORDER BY NEWID()) v1 
CROSS JOIN (SELECT TOP 1 chars FROM @tmpTable ORDER BY NEWID()) c1
CROSS JOIN (SELECT TOP 1 chars FROM @tmpTable ORDER BY NEWID()) c2
CROSS JOIN (SELECT TOP 1 chars FROM @tmpTable ORDER BY NEWID()) n2
CROSS JOIN (SELECT TOP 1 chars FROM @tmpTable ORDER BY NEWID()) n3
CROSS JOIN (SELECT TOP 1 chars FROM @tmpTable ORDER BY NEWID()) n4
ORDER BY NEWID() 

--SELECT @GeneratedCode

SELECT @GeneratedCode = dbo.fnRandomizedText(@GeneratedCode)


--RETURN @GeneratedCode

END

