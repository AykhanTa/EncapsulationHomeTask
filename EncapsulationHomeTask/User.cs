namespace EncapsulationHomeTask
{
    class User
    {
        string _userName;
        public string UserName { get; set; }

        string _password;
        public string Password {
            get 
            { 
                return _password;
            }
            set 
            {
                if (string.IsNullOrEmpty(value)==true || value.Length<8)
                {
                    Console.WriteLine("Duzgun formatda daxil edilmeyib.");
                    return;
                }
                else
                {
                    Console.WriteLine(RulesOfPassword(value));
                }
            }
        }

        int _age;
        public int Age { 
            get 
            {
                return _age;
            }
            set 
            { 
                if (value<0)
                {
                    Console.WriteLine("Yash menfi ola bilmez.");
                    return;
                }
                _age = value;
            }
        }

        private string RulesOfPassword(string password)
        {
            int count = 0;
            int count1=0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    count++;
                }
                else if (char.IsDigit(password[i]))
                {
                    count1++;
                }
            }
            if (count>0 && count1>0)
            {
                return password;
            }
            else
            {
                return "Uncorrect password format";
            }

        }
    }
}
