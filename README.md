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
	declare @count		as int = 0;</br>
	declare @total		as int = 30;</br>
	declare @Name		as nvarchar(256) = 'TESTE';</br>
	declare @LastName	as nvarchar(256) = 'teste';</br>
	declare @Email		as nvarchar(256) = 'teste@teste.com';</br>
	declare @BirthDate	as datetime = getdate();</br>

	while(@count <= @total) 
	begin

	insert into Friends (Name, LastName, Email, BirthDate)
	values (CONCAT(@Name, @count), CONCAT(@LastName, @count), CONCAT(@Email, @count), GETDATE())

	set @count += 1

	end
</p>


<p>
	Caso queira diminuir o numero de amigos, basta ajustar o total desejado na variavel `@total`	
<p>