function match(candidate, job) {
  if(!candidate.minSalary || !job.maxSalary)
    throw "error";
  
  var wiggle = candidate.minSalary * 0.1;
  if(candidate.minSalary - wiggle > job.maxSalary)
    return false;
  return true;
}