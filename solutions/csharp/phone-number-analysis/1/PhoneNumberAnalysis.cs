public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        const string NewYorkCode = "212";
        const string codeFake = "555";
        string lastDigit = phoneNumber.Substring(8);
        string fristTreeDigits = phoneNumber.Substring(0, 3);
        string restDigits = phoneNumber.Substring(4, 3);
        
        (bool, bool, string) phone = (fristTreeDigits == NewYorkCode, restDigits == codeFake, lastDigit);
        return phone;
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {        
        return phoneNumberInfo.IsFake;
    }
}
