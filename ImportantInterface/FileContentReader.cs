using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class FileContentReader : IDisposable
    {
        private Stream _stream;

        public FileContentReader(string path)
        {
            _stream = File.Open(path, FileMode.Open);
        }

        public void Dispose()
        {
            _stream?.Dispose();
        }

        public string GetContent(int size)
        {
            byte[] buffer = new byte[size];
            _stream.Read(buffer, 0, size);

            return Encoding.UTF8.GetString(buffer);
        }
    }
}
