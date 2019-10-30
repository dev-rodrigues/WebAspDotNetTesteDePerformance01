# WebAspDotNetTesteDePerformance01

## Para apagar todos os dados --
--delete			
--from		Friends

## Para executar:
<p>
-- Va em exibir > Sql server object
-- Localize `Data.Context.DataBaseContext`
-- Btn direito > `New query`
-- Execute o seguinte script
</p>

<h1>scrip</h1>
<p>
declare @count		as int = 0;
declare @total		as int = 30;
declare @Name		as nvarchar(256) = 'TESTE';
declare @LastName	as nvarchar(256) = 'teste';
declare @Email		as nvarchar(256) = 'teste@teste.com';
declare @BirthDate	as datetime = getdate();

while(@count <= @total) 
begin

	insert into Friends (Name, LastName, Email, BirthDate)
	values (CONCAT(@Name, @count), CONCAT(@LastName, @count), CONCAT(@Email, @count), GETDATE())

	set @count += 1

end
</p>