namespace MessageGenerator
{
    public class MessageGen
    {
        public string Message { get; set; }


        public string PrintMessage()
        {
            return ("Hello " + Message.ToUpper());
        }

    }
}