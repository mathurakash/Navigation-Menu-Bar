using System;

namespace Navigation_Menu_Bar
{
    internal class Mp3FileReader
    {
        private string v;

        public Mp3FileReader(string v)
        {
            this.v = v;
        }

        public TimeSpan TotalTime { get; internal set; }
    }
}