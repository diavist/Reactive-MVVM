﻿using Core.Log.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Log.Faults
{
    [DataContract]
    public class GenericFault<T> where T : IBaseException
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Message { get; set; }

        public GenericFault()
        {

        }

        public GenericFault(T baseException)
        {
            Message = baseException.Message;
            Code = baseException.Code;
        }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Code))
            {
                return string.Format("{0}", Message);
            }
            else
            {
                return string.Format("{0}: {1}", Code, Message);
            }

        }


    }
}
