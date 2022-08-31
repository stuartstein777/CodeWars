function yearDays(year)
{
  if(year % 100 === 0)
    return (year % 400 === 0) ? `${year} has 366 days` : `${year} has 365 days`;
  else if(year % 4 === 0)
    return `${year} has 366 days`;
  else
    return `${year} has 365 days`;
}