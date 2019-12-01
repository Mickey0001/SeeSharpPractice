﻿namespace CustomerManagmentBusinessLayer
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string EmailAdrress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public static int InstanceCount { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdrress)) isValid = false;

            return isValid;
        }
    }
}