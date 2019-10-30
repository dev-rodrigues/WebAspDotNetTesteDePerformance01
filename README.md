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
	<li>declare @count		as int = 0;</li>
	<li>declare @total		as int = 30;</li>
	<li>declare @Name		as nvarchar(256) = 'TESTE';</li>
	<li>declare @LastName	as nvarchar(256) = 'teste';</li>
	<li>declare @Email		as nvarchar(256) = 'teste@teste.com';</li>
	<li>declare @BirthDate	as datetime = getdate();</li>

	while(@count <= @total) 
	begin

	insert into Friends (Name, LastName, Email, BirthDate)
	values (CONCAT(@Name, @count), CONCAT(@LastName, @count), CONCAT(@Email, @count), GETDATE())

	set @count += 1

	end
</p>