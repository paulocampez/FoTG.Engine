using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoTG.Engine.Core.Servicos
{
    public static class Memoria
    {

        public static byte[] Comprimir(byte[] inputData)
        {
            if (inputData == null)
                throw new ArgumentNullException("erro. input data");

            MemoryStream output = new MemoryStream();
            using (GZipStream dstream = new GZipStream(output, CompressionLevel.Optimal))
            {
                dstream.Write(inputData, 0, inputData.Length);
            }
            return output.ToArray();
        }

        public static byte[] Descomprimir(byte[] inputData)
        {
            if (inputData == null)
                throw new ArgumentNullException("erro. input data");

            MemoryStream input = new MemoryStream(inputData);
            MemoryStream output = new MemoryStream();
            using (GZipStream dstream = new GZipStream(input, CompressionMode.Decompress))
            {
                dstream.CopyTo(output);
            }
            return output.ToArray();
        }
    }
}
