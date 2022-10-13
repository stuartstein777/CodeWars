function setAlarm(bool $employed, bool $vacation): bool {
  return $employed && !$vacation;
}