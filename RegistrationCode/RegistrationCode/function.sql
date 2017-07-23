USE [DERMSL_Test]
GO

/****** Object:  UserDefinedFunction [dbo].[fnRandomizedText]    Script Date: 7/13/2017 9:37:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[fnRandomizedText](@TextToScramble varchar(30)) RETURNS varchar(52)
 
as
 
BEGIN
 
DECLARE @counter smallint,
@TextToScrambleLen tinyint,
@pos int,@retVal varchar(52),
@maxRandID float,
@myChar varchar(1),
@Scrambled Varchar(30),
@rowCount tinyint,
@test tinyint
 
DECLARE @ScrambleTable TABLE (letter varchar(1),randid float)
 
set @pos =0
 
set @TextToScrambleLen =len(@TextToScramble)
 
set @Scrambled='';
 
SET @counter = 0
 
WHILE @counter < @TextToScrambleLen
begin 
 SET @counter = @counter + 1
 insert into @ScrambleTable (letter,randid) values (substring(@TextToScramble,@counter,1), (select value from vwRandom))
end
set @rowCount = 0
set @counter=0
set @maxRandID = 2
select @rowCount = count(*) from @ScrambleTable
set @test=0
set @test=@test+1
 
WHILE @counter < @rowCount
begin
 select @maxRandID = max(randid) from @ScrambleTable where randid < @maxRandID
 select @myChar = letter from @ScrambleTable where randid = @maxRandID
 set @Scrambled = @Scrambled + @myChar
 select @counter = @counter + 1
end
 
return @Scrambled
 
END


GO


