string ? readUser; //initiate a nullable string to collect user input
string roleName = ""; //to store user input
bool validate = false; //boolean to validate iteration

Console.WriteLine($"Enter your role name (Administrator, Manager, or User)"); //To prompt user for input

do{
    readUser = Console.ReadLine(); //collects input and 
    if (readUser != null)
    {
        roleName = readUser.Trim().ToLower(); //stores in rolename
    }
    if (roleName.Contains("administrator") || roleName.Contains("manager") || roleName.Contains("user")) //conditional
    {
        validate = true;
   }
   else {
    Console.WriteLine($"The role name that you entered, {roleName} is not valid. Enter your role name (Administrator, Manager, or User)");
   }
} while (validate == false);
Console.WriteLine($"Welcome {roleName.ToUpper()}");