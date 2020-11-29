using System;
using System.Collections.Generic;

class Verif
{
    public class Base
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public bool Check(string login, string pass)
    {
        var myBases = new List<Base>
        {
            new Base() { Login="root", Password="GeekBrains"},
        };

        foreach (Base myBase in myBases)
        {
            if (myBase.Login == login && myBase.Password == pass) return true;
        }

        return false;
    }

}
