using System.ComponentModel.Design;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        int byteLength;

        if (reading >= 4_294_967_296 || reading <= -2_147_483_649)
        {
            // long
            buffer[0] = 256 - 8;
        }
        else if (reading >= 2_147_483_648)
        {
            // uint
            buffer[0] = 4;
        }
        else if (reading >= 65_536 || reading <= -32_769)
        {
            // int
            buffer[0] = 256 - 4;
        }
        else if(reading <= -1)
        {
            // Short
            buffer[0] = 256 - 2;
        }
        else
        {
            // ushort
            buffer[0] = 2;
        }
        byteLength = buffer[0] > 128 ? 256 - buffer[0] : buffer[0];
        Array.Copy(BitConverter.GetBytes(reading), 0, buffer, 1, byteLength);
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        int[] validByteLengths = { 2, 4, 8 };
        int byteLength = buffer[0] > 128 ? 256 - buffer[0] : buffer[0];

        if (!validByteLengths.Contains(byteLength)) return 0;

        if (buffer[0] > 128)
        {
            if (byteLength == 2) return BitConverter.ToInt16(buffer, 1);
            if (byteLength == 4) return BitConverter.ToInt32(buffer, 1);

            return BitConverter.ToInt64(buffer, 1);
        }

        if (byteLength == 2) return BitConverter.ToUInt16(buffer, 1);
        return BitConverter.ToUInt32(buffer, 1);
    }
}

