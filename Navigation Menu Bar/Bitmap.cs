using System.IO;

namespace Navigation_Menu_Bar
{
    internal class Bitmap
    {
        private MemoryStream mStream;
        private bool v;

        public Bitmap(MemoryStream mStream, bool v)
        {
            this.mStream = mStream;
            this.v = v;
        }
    }
}