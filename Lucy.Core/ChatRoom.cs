using Lucy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucy.Core
{
    public class ChatRoom
    {
        List<ChatBot> _chatBotList;

        public void Join(ICanChat chatter)
        {
            
        }

        public void Leave(ICanChat chatter)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(string message, ICanChat sender)
        {
            throw new NotImplementedException();
        }

        public bool IsUserPresent(ICanChat chatter)
        {
            throw new NotImplementedException();
        }
    }
}
