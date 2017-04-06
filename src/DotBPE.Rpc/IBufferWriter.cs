﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotBPE.Rpc
{
    public interface IBufferWriter
    {
        IBufferWriter WriteInt(int value);
        IBufferWriter WriteByte(byte value);

        IBufferWriter WriteLong(long value);

        IBufferWriter WriteDouble(double value);

        IBufferWriter WriteBytes(byte[] value);

        IBufferWriter WriteChar(char value);

        IBufferWriter WriteShort(short value);

        byte[] GetBuffer();
    }
}
