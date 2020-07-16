function getData(){
    //Array
    // var userData = ["Hello","hi"];
    // userData[2] = "Welcome"
    // userData.push("G3");
    //Object
    // var userDetails={
       
    // };
    // userDetails.name = frmUser.txtName.value;
    // userDetails.age = frmUser.txtAge.value;
    // userDetails.dob = frmUser.txtDOB.value;
    // userDetails.email = frmUser.txtEmail.value;
    // userDetails.gender = frmUser.rdbMale.checked?frmUser.rdbMale.value:frmUser.rdbFemale.value;
    // userDetails.grad = frmUser.chkUG.value+" "+frmUser.chkPG.value;
    // userDetails.city = frmUser.ddlCity.value;
    // userDetails.country = frmUser.ddlCountry.value;
    // console.log(userDetails);
    var num = parseInt(frmUser.txtAge.value);
    var num1 = frmUser.txtAge.value
    if(num1===num)//=== compares data type too
        alert("Equal");
    else
        alert("No no no");
    document.write(userDetails);
}