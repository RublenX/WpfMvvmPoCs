using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using WpfMvvmNet6.Messaging.Messages;

namespace WpfMvvmNet6.ViewModels
{
    public class SegunderoViewModel : ObservableRecipient, IRecipient<SegunderoChangedMessage>
    {
        private int _segundos = -1;

        public int Segundos
        {
            get { return _segundos; }
            private set { SetProperty(ref _segundos, value); }
        }

        public SegunderoViewModel()
        {
            this.OnActivated();
        }

        protected override void OnActivated()
        {
            base.OnActivated();

            Messenger.Register<SegunderoViewModel, CurrentSegunderoRequestMessage>(this, (r, m) => m.Reply(r.Segundos));
        }

        public void Receive(SegunderoChangedMessage message)
        {
            Segundos = message.Value;
        }
    }
}
