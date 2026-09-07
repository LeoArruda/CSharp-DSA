namespace JaggedArrays
{

    public static class TransportEnumExtensions
    {
        public static char GetChar(this TransportEnum transport)
        {
            return transport switch
            {
                TransportEnum.CAR => 'C',
                TransportEnum.BUS => 'U',
                TransportEnum.SUBWAY => 'S',
                TransportEnum.BIKE => 'B',
                TransportEnum.WALK => 'W',
                _ => throw new Exception("Unknown transport type")
            };
        }

        public static ConsoleColor GetColor(this TransportEnum transport)
        {
            return transport switch
            {
                TransportEnum.CAR => ConsoleColor.Red,
                TransportEnum.BUS => ConsoleColor.DarkGreen,
                TransportEnum.SUBWAY => ConsoleColor.DarkMagenta,
                TransportEnum.BIKE => ConsoleColor.Blue,
                TransportEnum.WALK => ConsoleColor.Yellow,
                _ => throw new Exception("Unknown transport type")
            };
        }
    }

}