﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileEncrypter
{
    [Serializable()]
    public class EncryptionKey : ISerializable
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Key { get; set; }
        public string Password { get; set; }

        public EncryptionKey()
        {

        }

        public EncryptionKey( string FirstName , string LastName, string Key, string Password)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Key = Key;
            this.Password = Password;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("FirstName", FirstName);
            info.AddValue("LastName", LastName);
            info.AddValue("Key", Key);
            info.AddValue("Password", Password);
        }

        public EncryptionKey(SerializationInfo info, StreamingContext context)
        {
            FirstName = (string)info.GetValue("FirstName", typeof(string));
            LastName = (string)info.GetValue("LastName", typeof(string));
            Key = (string)info.GetValue("Key", typeof(string));
            Password = (string)info.GetValue("Password", typeof(string));
        }
    }
}
