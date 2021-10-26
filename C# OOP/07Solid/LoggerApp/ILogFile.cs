namespace LoggerApp
{
    public interface ILogFile
    {
        int Size {get; }

        void Write(string error);
    }
}
