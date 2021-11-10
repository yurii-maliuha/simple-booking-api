use [sql-booking-db]
select top(10) * from Properties
Order by Id desc

select top(10) * from Logs

use [sql-booking-logs-db]
select top(10) * from Logs

--delete from Properties
--where Id > 1136


--use [sql-booking-logs-db]
--select * from Logs