function getStatus(isBusy) {
  if(isBusy)
    return {status: "busy"};
  return {status: "available"};
}