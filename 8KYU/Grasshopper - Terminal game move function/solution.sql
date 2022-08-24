--# write your statement here: you will be given a table 'moves' with columns 'position' and 'roll'. return a table with a column 'res'. #--
select (position + 2 * roll) as res
from moves