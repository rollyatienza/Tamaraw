declare @GeneratedCode varchar(6)
declare @count int

set @count = 1
while @count <= 1000
begin
	EXEC schoolonline..pGenerateRegistrationCode @GeneratedCode OUTPUT
	insert into RegistrationCodes(RegistrationCode,UserID)
	select @GeneratedCode, NULL
	
	set @COUNT = @COUNT + 1
end

--select * from registrationcodes