# WebAspDotNetTesteDePerformance01

## Para apagar todos os dados --
<p> delete from Friends </p>

## Para executar:
<p>
	<li>Va em exibir > Sql server object</li>
	<li>Localize `Data.Context.DataBaseContext`</li>
	<li>Btn direito > `New query`</li>
	<li>Execute o seguinte script</li>
</p>

<h1>Scrip</h1>
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