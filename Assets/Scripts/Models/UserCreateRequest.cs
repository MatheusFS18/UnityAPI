using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserCreateRequest 
{
    [SerializeField]
    public string username;
    [SerializeField]
    public string password;

    public string confirmpassword;

    public string Validate()
    {
        if (password != confirmpassword)
            return "Confirmação de senha não corresponde";

        return "";
    }
}
