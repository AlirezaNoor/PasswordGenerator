using NanoidDotNet;

namespace passwordgenrate.Services;

public class PasswordGeneric
{
      private string _password;
      
      private  string createpassword( int id)
      {
          var _password = Nanoid.Generate(size:id);

          return _password;
          
      }

      public string Generatepass( int id)
      {
          var generic = createpassword(id);

          return generic;
      }
}