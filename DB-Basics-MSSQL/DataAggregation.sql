select SUM([Difference]) from
(
select w1.FirstName as [Host Wizard],
	w1.DepositAmount as [Host Wizard Deposit], 
	w2.FirstName as [Guest Wizard], 
	w2.DepositAmount as [Guest Wizard Deposit], 
	w1.DepositAmount - w2.DepositAmount as [Difference]
from WizzardDeposits w1
join WizzardDeposits w2 on w1.Id = (w2.Id - 1)
) as tmp

select SUM([Difference]) from
(
select w.FirstName as [Host Wizard],
	w.DepositAmount as [Host Wizard Deposit], 
	LEAD(FirstName) OVER (Order BY Id) as [Guest Wizard],
	LEAD(DepositAmount) OVER (Order BY Id) as [Guest Wizard Deposit],
	w.DepositAmount - (LEAD(DepositAmount) OVER (Order BY Id)) as [Difference]
from WizzardDeposits w
) as tmp