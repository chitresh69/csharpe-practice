class OddNumException : Exception
{
    public override string Message
    {
        get
        {
            return "Divisor cannot be Odd Number";
        }    
        }

    public override string HelpLink 
    { 
        get 
        {
            return "Get more information here : https://dotnettutorials.net/lesson/create-custom-exception-csharp/";

        }
    }
}