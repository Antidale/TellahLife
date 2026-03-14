using System.ComponentModel;

namespace TellahLife.Extenstions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum name)
        {
            var field = name.GetType().GetField(name.ToString());
            if (field == null)
            {
                return name.ToString();
            }

            var attributes = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes != null && attributes.Length > 0
                ? attributes[0].Description
                : name.ToString();

        }

        public static T GetAttribute<T>(this Enum name) where T : Attribute, new()
        {
            var field = name.GetType().GetField(name.ToString());
            if (field == null)
                return new T();

            var attributes = (T[])field.GetCustomAttributes(typeof(T), false);

            return attributes != null && attributes.Length > 0
                ? attributes[0]
                : new T();
        }

        public static bool HasAttribute<T>(this Enum name) where T : Attribute
        {
            var field = name.GetType().GetField(name.ToString());
            if (field == null)
                return false;

            var attributes = (T[])field.GetCustomAttributes(typeof(T), false);

            return attributes != null && attributes.Length > 0;
        }
    }
}
