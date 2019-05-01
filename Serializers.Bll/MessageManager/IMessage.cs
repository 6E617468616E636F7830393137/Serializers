using Serializers.Dto.Models;

namespace Serializers.Bll.MessageManager
{
    public interface IMessage
    {
        MessageModel setMessage(string data);
        string getMessage(MessageModel data);
    }
}
