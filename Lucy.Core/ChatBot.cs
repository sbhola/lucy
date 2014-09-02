using Lucy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucy.Core
{
    public class ChatBot : ICanChat
    {
        private ICommandAdapter _commandAdapter;
        public ChatBot(ICommandAdapter commandAdapter)
        {
            _commandAdapter = commandAdapter;
        }

        public void Notify(string newMessage)
        {
            throw new NotImplementedException();
        }

        public string ChatterId
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
