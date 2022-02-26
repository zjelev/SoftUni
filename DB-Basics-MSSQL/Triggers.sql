create proc usp_BuyItem @itemId int, @userId int, @gameId int
as
begin transaction
	declare @user INT = (select Id from Users where Id = @userId)
	declare @item INT = (select Id from Items where Id = @itemId)

	if (@user is null)
		throw 50001, 'Invalid user id!', 1

	if (@item is NULL)
		throw 50002, 'Invalid item id!', 1

	declare @userGameId INT = (select Id from UsersGames
	where UserId = @userId and GameId = @gameId)

	if (@userGameId is NULL)
		throw 50003, 'Invalid userGame id!', 1

	declare @userCash decimal(15, 2) = (select Cash from UsersGames
			where Id = @userGameId)
	declare @itemPrice decimal(15, 2) = (select Price from Items
			where Id = @itemId)

	if (@userCash < @itemPrice)
		throw 50002, 'Insufficient funds!', 2

	update UsersGames
	set Cash -= @itemPrice
	where UserId = @userId and GameId = @gameId

	insert into UserGameItems (ItemId, UserGameId)
	values (@itemId, @userGameId)

commit
--19.2

select Username, Cash from Users u
join UsersGames ug on u.Id = ug.UserId
join Games g on ug.GameId = g.Id
	where Username in ('baleremuda', 'loosenoise', 'inguinalself'
	, 'buildingdeltoid', 'monoxidecos') and g.Name = 'bali'


update UsersGames
set Cash -= 50000
where GameId = (select Id from Games where Name = 'bali') AND
UserId IN (select Id from Users where Username in ('baleremuda', 'loosenoise', 'inguinalself'
	, 'buildingdeltoid', 'monoxidecos'))

	
--19.3
declare @item int = 251

while (@item <= 299)
	begin
		exec usp_BuyItem @item, 12, 212
		exec usp_BuyItem @item, 22, 212
		exec usp_BuyItem @item, 37, 212
		exec usp_BuyItem @item, 52, 212
		exec usp_BuyItem @item, 61, 212

		set @item += 1;
	end

--19.4
select u.Username, g.Name, ug.Cash, i.Name 
	from Users u
	join UsersGames ug on u.Id = ug.UserId
	join Games g on g.Id = ug.GameId
	join UserGameItems ugi on ugi.UserGameId = ug.Id
	join Items i on i.Id = ugi.ItemId
where g.Name = 'bali'
order by u.Username, i.Name

--20
select u.Username, g.Name, ug.Cash, i.Name, i.MinLevel
	from Users u
	join UsersGames ug on u.Id = ug.UserId
	join Games g on g.Id = ug.GameId
	join UserGameItems ugi on ugi.UserGameId = ug.Id
	join Items i on i.Id = ugi.ItemId
where u.Username = 'Stamat' and g.Name = 'Safflower'

declare @userIdn int = (select u.Id from Users u where u.Username = 'Stamat')
declare @gameIdn int = (select g.Id from Games g where g.Name = 'Safflower')

select Id from Items where (MinLevel >= 11 and MinLevel <= 12) or (MinLevel >= 19 and MinLevel <= 21)

exec usp_BuyItem