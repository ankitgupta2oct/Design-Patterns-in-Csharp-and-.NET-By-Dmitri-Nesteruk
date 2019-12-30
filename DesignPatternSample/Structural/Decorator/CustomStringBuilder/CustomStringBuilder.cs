using System;
using System.Runtime.Serialization;
using System.Text;

namespace DesignPatternSample.Structural.Decorator.CustomStringBuilder
{
    class CustomStringBuilder
    {
        private readonly StringBuilder _builder = new StringBuilder();

        public static implicit operator CustomStringBuilder(string text)
        {
            var customStringBuilder = new CustomStringBuilder();
            customStringBuilder.Append(text);
            return customStringBuilder;
        }

        public static CustomStringBuilder operator +(CustomStringBuilder builder, string text)
        {
            builder.Append(text);
            return builder;
        }


        public override string ToString()
        {
            return _builder.ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable)_builder).GetObjectData(info, context);
        }

        public int EnsureCapacity(int capacity)
        {
            return _builder.EnsureCapacity(capacity);
        }

        public string ToString(int startIndex, int length)
        {
            return _builder.ToString(startIndex, length);
        }

        public CustomStringBuilder Clear()
        {
            _builder.Clear();
            return this;
        }

        public CustomStringBuilder Append(char value, int repeatCount)
        {
            _builder.Append(value, repeatCount);
            return this;
        }

        public CustomStringBuilder Append(char[] value, int startIndex, int charCount)
        {
            _builder.Append(value, startIndex, charCount);
            return this;
        }

        public CustomStringBuilder Append(string value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(string value, int startIndex, int count)
        {
            _builder.Append(value, startIndex, count);
            return this;
        }

        public CustomStringBuilder AppendLine()
        {
            _builder.AppendLine();
            return this;
        }

        public CustomStringBuilder AppendLine(string value)
        {
            _builder.AppendLine(value);
            return this;
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            _builder.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public CustomStringBuilder Insert(int index, string value, int count)
        {
            _builder.Insert(index, value, count);
            return this;
        }

        public CustomStringBuilder Remove(int startIndex, int length)
        {
            _builder.Remove(startIndex, length);
            return this;
        }

        public CustomStringBuilder Append(bool value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(sbyte value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(byte value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(char value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(short value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(int value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(long value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(float value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(double value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(decimal value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(ushort value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(uint value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(ulong value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(object value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Append(char[] value)
        {
            _builder.Append(value);
            return this;
        }

        public CustomStringBuilder Insert(int index, string value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, bool value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, sbyte value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, byte value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, short value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, char value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, char[] value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, char[] value, int startIndex, int charCount)
        {
            _builder.Insert(index, value, startIndex, charCount);
            return this;
        }

        public CustomStringBuilder Insert(int index, int value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, long value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, float value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, double value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, decimal value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, ushort value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, uint value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, ulong value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder Insert(int index, object value)
        {
            _builder.Insert(index, value);
            return this;
        }

        public CustomStringBuilder AppendFormat(string format, object arg0)
        {
            _builder.AppendFormat(format, arg0);
            return this;
        }

        public CustomStringBuilder AppendFormat(string format, object arg0, object arg1)
        {
            _builder.AppendFormat(format, arg0, arg1);
            return this;
        }

        public CustomStringBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
        {
            _builder.AppendFormat(format, arg0, arg1, arg2);
            return this;
        }

        public CustomStringBuilder AppendFormat(string format, params object[] args)
        {
            _builder.AppendFormat(format, args);
            return this;
        }

        public CustomStringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
        {
            _builder.AppendFormat(provider, format, args);
            return this;
        }

        public CustomStringBuilder Replace(string oldValue, string newValue)
        {
            _builder.Replace(oldValue, newValue);
            return this;
        }

        public bool Equals(CustomStringBuilder sb)
        {
            return _builder.Equals(sb);
        }

        public CustomStringBuilder Replace(string oldValue, string newValue, int startIndex, int count)
        {
            _builder.Replace(oldValue, newValue, startIndex, count);
            return this;
        }

        public CustomStringBuilder Replace(char oldChar, char newChar)
        {
            _builder.Replace(oldChar, newChar);
            return this;
        }

        public CustomStringBuilder Replace(char oldChar, char newChar, int startIndex, int count)
        {
            _builder.Replace(oldChar, newChar, startIndex, count);
            return this;
        }

        public int Capacity
        {
            get => _builder.Capacity;
            set => _builder.Capacity = value;
        }

        public int MaxCapacity => _builder.MaxCapacity;

        public int Length
        {
            get => _builder.Length;
            set => _builder.Length = value;
        }

        public char this[int index]
        {
            get => _builder[index];
            set => _builder[index] = value;
        }
    }
}