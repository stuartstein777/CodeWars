function validate(username, password){
  console.log(username);
  console.log(password);
  var database = new Database();
  if(password.includes('||') || password.includes('//'))
    return "Wrong username or password!";
  else
    return database.login(username, password);
}