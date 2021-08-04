using ShellShockProjectileMotion.Properties;

namespace ExtensionMethods
{
    public static class Extensions
    {
        private static readonly int s_screenHeight = Settings.Default.ScreenHeight;

        public static int FlipScreenHeight(this int i)
        {
            return s_screenHeight - i;
        }
    }
}
