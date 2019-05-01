using Serializers.Dto.Models;

namespace Serializers.Bll.MessageManager
{
    public class Message : IMessage
    {
        public string getMessage(Dto.Models.MessageModel data)
        {
            return data.Message;
        }

        public MessageModel setMessage(string data)
        {
            return new MessageModel() {
                Message = data
            };
        }
    }
}
