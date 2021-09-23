using FIRE.Fire;
using System;
using System.Collections.Generic;
using System.Text;

namespace FIRE.FIRE
{
    public class FireOutput
    {
        private string UserInput;
        private string Output;

        public FireOutput(string UserInput)
        {
            this.UserInput = UserInput;
        }

        public void SetUserInput(string value)
        {
            UserInput = value;
        }
        public string GetOutput()
        {
            if (UserInput.Contains("hello fire")|| UserInput.Contains("hi fire"))
            {
                Output = "Hi Cipher";
            }
            if (UserInput.Contains("find"))
            {
                if (UserInput.Contains("ip"))
                {
                    AddressIpInputForm addressIpInputForm = new AddressIpInputForm();
                    addressIpInputForm.ShowDialog();
                    

                    FindIp ipAdress = new FindIp();
                    Output = ipAdress.GetIpResult(addressIpInputForm.GetIpUserInput());
                }
            }
            else
            {
                Output = "What?";
            }
            return Output;
        }
       

    }
}
