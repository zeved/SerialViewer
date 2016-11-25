
namespace SerialViewer
{
    class Constants
    {
        public static int[] baudList = new int[]
        {
            1200, 2400, 4600, 9600, 14400, 19200, 38400, 57600, 115200, 230400, 460800, 921600
        };

        public static string[] parityList = new string[]
        {
            "None", "Odd", "Even", "Mark", "Space"
        };
    }
}
