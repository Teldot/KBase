using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KBase.Data.Model.Catalogs;
using System.IO;
using System.IO.Compression;

namespace KBase.View.AFWControls
{
    public abstract partial class UcContent : UserControl
    {
        #region Atributes
        protected byte[] _content;
        protected string _contentUrl;
        protected bool _dynamicContent;
        #endregion
        #region Properties
        public CatContentType ContentType { get; set; }
        public Guid ArticleContentId { get; set; }
        public Guid ArticleId { get; set; }
        public string ArticleName { get; set; }
        public virtual byte[] GetContent()
        {
            return Compress(_content);
        }
        public virtual void SetContent(byte[] content)
        {
            _content = Decompress(content);
        }
        public string GetContentUrl()
        {
            return _contentUrl;
        }
        public virtual void SetContentUrl(string url)
        {
            _contentUrl = url;
        }
        public virtual void SetDynamicContent(bool dynCon)
        {
            _dynamicContent = dynCon;
        }
        public virtual bool GetDynamicContent()
        {
            return _dynamicContent;
        }
        #endregion
        #region Constructor
        public UcContent()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods
       

        public byte[] Compress(byte[] raw)
        {
            Stream input = new MemoryStream(raw);
            using (var compressStream = new MemoryStream())
            using (var compressor = new DeflateStream(compressStream, CompressionMode.Compress))
            {
                input.CopyTo(compressor);
                compressor.Close();
                return compressStream.ToArray();
            }
            //using (MemoryStream memory = new MemoryStream())
            //{
            //    using (GZipStream gzip = new GZipStream(memory, CompressionMode.Compress, true))
            //    {
            //        gzip.Write(raw, 0, raw.Length);
            //    }
            //    return memory.ToArray();
            //}
        }
        public byte[] Decompress(byte[] raw)
        {
            var output = new MemoryStream();

            using (var compressStream = new MemoryStream(raw))
            using (var decompressor = new DeflateStream(compressStream, CompressionMode.Decompress))
                decompressor.CopyTo(output);

            output.Position = 0;
            return output.ToArray();
            //using (MemoryStream memory = new MemoryStream())
            //{
            //    using (GZipStream gzip = new GZipStream(memory, CompressionMode.Decompress, true))
            //    {
            //        gzip.Write(raw, 0, raw.Length);
            //    }
            //    return memory.ToArray();
            //}
            
        }
        #endregion
    }
}
