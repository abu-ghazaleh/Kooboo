﻿using System;
using System.Collections.Generic;
using System.Text;
using Kooboo.Model.Meta.Validation;

namespace Kooboo.Model.Setting
{
    public class RegisterModel: IKoobooModel
    {
        public ModelType ModelType { get; set; }

        public string ModelName => "Register";

        [RequiredRule("username can't be empty")]
        [UniqueRule("/user/IsUniqueName?name={userName}", "username is not unique")]
        public string UserName { get; set; }

        [RequiredRule("password can't be empty")]
        public string Password { get; set; }

        [SameAsRule("password", "password is not the same.")]
        public string ConfirmPassword { get; set; }

        [RequiredRule("email can't be empty")]
        [EmailRule]
        [UniqueRule("/user/IsUniqueEmail?email={email}","email is not unique")]
        public string Email { get; set; }

        
    }
}