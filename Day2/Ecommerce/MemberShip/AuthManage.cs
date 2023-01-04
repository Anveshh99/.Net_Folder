namespace MemberShip;

public static class AuthManage
{
  public static bool Validate(string email, string password){
        bool status=false;
        if(email == "anveshmodak22@gmail.com" && password=="Anvesh@99"){
            status=true;
        }
        return status;
    }

  public static bool Register(string firstName, string lastName, 
                            string email, string location, string contactNumber){
          bool status=false;
          try{

            User theUser =new User();
            theUser.FirstName=firstName;
            theUser.LastName=lastName;
            theUser.Email=email;
            theUser.Location=location;
            theUser.ContactNumber=contactNumber;
            //Store object into persistent medium
            status=true;

          }
          catch(Exception e){
            Console.WriteLine(e);
          }
          finally{
          }
         return status;
    }

 
}
