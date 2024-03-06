using Prism.Mvvm;

namespace Katharsis.Bots.Voice.Models
{
    public class LogModel : BindableBase
    {
        public DateTime OccurredAt { get; set; }
        public string Message { get; set; } = default!;
    }
}
