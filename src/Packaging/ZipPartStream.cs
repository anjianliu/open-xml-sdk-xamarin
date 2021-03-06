﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXmlSdk.Xamarin.Packaging
{
	internal class ZipPartStream : Stream
	{
		public MemoryStream BaseStream { get; private set; }
		public ZipPackage Package { get; private set; }

		public override bool CanRead
		{
			get
			{
				return BaseStream.CanRead;
			}
		}

		public override bool CanSeek
		{
			get
			{
				return BaseStream.CanSeek;
			}
		}

		public override bool CanTimeout
		{
			get { return BaseStream.CanTimeout; }
		}

		public override bool CanWrite
		{
			get { return Writeable; }
		}

		public override long Length
		{
			get { return BaseStream.Length; }
		}

		public override long Position
		{
			get;
			set;
		}

		public bool Writeable
		{
			get;
			set;
		}

		public override int WriteTimeout
		{
			get
			{
				return BaseStream.WriteTimeout;
			}
			set
			{
				BaseStream.WriteTimeout = value;
			}
		}

		public override int ReadTimeout
		{
			get
			{
				return BaseStream.ReadTimeout;
			}
			set
			{
				BaseStream.ReadTimeout = value;
			}
		}

		public ZipPartStream(ZipPackage package, MemoryStream stream, FileAccess access)
		{
			BaseStream = stream;
			Package = package;
			Writeable = access != FileAccess.Read;
		}

		public override void Flush()
		{
			// If the user flushes any of the part streams,
			// we need to flush the entire package

			// FIXME: Ensure that this actually happens with a testcase
			// ...if possible
			// Package.Flush();
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			Seek(Position, SeekOrigin.Begin);
			int read = BaseStream.Read(buffer, offset, count);
			Position += read;
			return read;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			Position = BaseStream.Seek(offset, origin);
			return Position;
		}

		public override void SetLength(long value)
		{
			if (!CanWrite)
				throw new InvalidOperationException("Stream is not writeable");

			BaseStream.SetLength(value);
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			if (!CanWrite)
				throw new InvalidOperationException("Stream is not writeable");

			Seek(Position, SeekOrigin.Begin);
			BaseStream.Write(buffer, offset, count);
			Position += count;
		}
	}
}
