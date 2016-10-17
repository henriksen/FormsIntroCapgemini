using System;
using FormsIntro.Helpers.Events.Messages;

namespace FormsIntro.Helpers.Events
{
    public class EventAggregator : IEventAggregator
    {
        public void SendMessage<T>(T message) where T : MessageBase
        {
            Xamarin.Forms.MessagingCenter.Send<T>(message, typeof(T).Name);
        }

        public void Subscribe<T>(object subscriber, Action<T> callback) where T : MessageBase
        {
            Xamarin.Forms.MessagingCenter.Subscribe<T>(subscriber, typeof(T).Name, callback);
        }

        public void Unsubscribe<T>(object subscriber) where T : MessageBase
        {
            Xamarin.Forms.MessagingCenter.Unsubscribe<T>(subscriber, typeof(T).Name);
        }
    }
}