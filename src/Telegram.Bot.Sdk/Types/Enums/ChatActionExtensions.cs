using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Telegram.Bot.Types.Enums
{
    internal static class ChatActionExtensions
    {
        internal static string ToActionString(this ChatAction action)
        {
            return action.GetType()
                .GetRuntimeField(action.ToString())
                .GetCustomAttributes(typeof(EnumMemberAttribute), true)
                .Select(a => ((EnumMemberAttribute)a).Value).FirstOrDefault();
        }
    }
}