﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloService" in both code and config file together.
    public class HelloService : IHelloService
    {

        #region IHelloService Members
	//check git if modified
        public string Getmessage(string name)
        {
            return "Hello " + name;

        }

        #endregion
    }
}
