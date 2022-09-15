namespace Musse.Helpers
{
    public static class Base64Helper
    {
        public static string StreamToBase64(Stream stream)
        {
            return Convert.ToBase64String(ReadFully(stream));
        }

        private static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
    }
}
