using CommunityToolkit.Mvvm.Messaging.Messages;

namespace WpfMvvmNet6.Messaging.Messages
{
    /// <summary>
    /// Clase que informa que el segundero ha cambiado
    /// </summary>
    public class SegunderoChangedMessage : ValueChangedMessage<int>
    {
        public SegunderoChangedMessage(int value) : base(value)
        {
        }
    }
}
