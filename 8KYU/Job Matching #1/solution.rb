def match(candidate, job)
  if !job.key?('max_salary') or !candidate.key?('min_salary')
    raise "error"
  end
  return job['max_salary'] >= candidate['min_salary'] * 0.9
end

