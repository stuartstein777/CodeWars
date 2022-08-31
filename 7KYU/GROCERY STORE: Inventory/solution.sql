select id, name, stock
from products
where producent = 'CompanyA' and stock < 3
order by id