using System;
using FormsIntro.Helpers.Events.Messages;

namespace FormsIntro.Helpers.Events
{
    public interface IEventAggregator
    {
        void SendMessage<T>(T message) where T : MessageBase;

        void Subscribe<T>(object subscriber, Action<T> callback) where T : MessageBase;

        void Unsubscribe<T>(object subscriber) where T : MessageBase;
    }
}