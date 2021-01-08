﻿using System;

namespace TernaryEmulator
{
    public readonly struct Trit : IComparable, IConvertible, IFormattable, IComparable<Trit>, IEquatable<Trit>
    {
        private readonly sbyte m_trit; // -1, 0 and 1

        public Trit(sbyte value)
        {
            m_trit = ToTrit(value).ToSByte(null);
        }

        public static Trit operator+ (Trit a, Trit b)
        {
            sbyte sb_a = a.ToSByte(null);
            sbyte sb_b = a.ToSByte(null);
            
            return new Trit((sbyte) (sb_a + sb_b));

        }
 
        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider? provider)
        {
            return m_trit;
        }
        
        public static Trit ToTrit(sbyte value)
        {
            value &= 0b11;
            return new Trit((sbyte)(value - 1));
        }
        
        public float ToSingle(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Trit other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Trit other)
        {
            throw new NotImplementedException();
        }
    }
}
