﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    public class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }
        public string GetReverseName()
        {
            string fullName = GetFullName();
            string reverseName = "";
            for(int index = fullName.Length - 1; index >=0; index--)
            {
                reverseName += fullName[index];
            }
            return reverseName;

        }
    }
}
