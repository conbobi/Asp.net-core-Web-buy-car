namespace ASC.WEB.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message); // Sửa lại cho đúng
    }
}
