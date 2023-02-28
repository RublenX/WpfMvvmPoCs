using CommunityToolkit.Mvvm.Messaging.Messages;

namespace WpfMvvmNet6.Messaging.Messages
{
    /// <summary>
    /// Clase para informar del estado del segundero al que lo solicite
    /// </summary>
    public class CurrentSegunderoRequestMessage : AsyncRequestMessage<int>
    {
    }
}
