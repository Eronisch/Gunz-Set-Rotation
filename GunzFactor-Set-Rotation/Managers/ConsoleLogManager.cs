using System;

namespace GunzFactor_Set_Rotation.Managers
{
    public static class ConsoleLogManager
    {
        private static readonly string Title = "GunzFactor - ";

        public static void Reset()
        {
            SetTitle("Monthly set rotation");
        }

        public static void SetTitle(string title)
        {
            Console.Title = $"{Title} {title}";
        }
    }
}
