function login(){
  if(frmLogin.txtUN.value =="Ramu" && frmLogin.txtPass.value =="1234")
    alert("Welcome ");
  else
    alert("Invalid username or password");
    reset();
}

function reset(){
    frmLogin.txtUN.value = "";
    frmLogin.txtPass.value = "";
    frmLogin.txtUN.focus();
}