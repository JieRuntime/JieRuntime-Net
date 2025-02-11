using System.Runtime.InteropServices;

namespace JieRuntime;

/// <summary>
/// 提供基本数据类型和字节数组的转换服务
/// </summary>
public static class BinaryConvert
{
	#region --公开方法--
	/// <summary>
	/// 返回由字节数组转换来的 Unicode 字符
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由两个字节构成的 Unicode 字符</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static char ToChar (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToChar (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的两个字节转换来的 Unicode 字符
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由两个字节构成的 Unicode 字符</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static char ToChar (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (char), isBigEndian);
		return BitConverter.ToChar (bytes);
	}

	/// <summary>
	/// 返回由字节数组转换来的 16 位有符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由两个字节构成的 16 位有符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static short ToInt16 (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToInt16 (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的两个字节转换来的 16 位有符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由两个字节构成的 16 位有符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static short ToInt16 (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (short), isBigEndian);
		return BitConverter.ToInt16 (bytes);
	}

	/// <summary>
	/// 返回由字节数组转换来的 16 位无符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由两个字节构成的 16 位无符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static ushort ToUInt16 (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToUInt16 (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的两个字节转换来的 16 位无符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由两个字节构成的 16 位无符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static ushort ToUInt16 (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (ushort), isBigEndian);
		return BitConverter.ToUInt16 (bytes);
	}

	/// <summary>
	/// 返回由字节数组转换来的 32 位有符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由四个字节构成的 32 位有符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static int ToInt32 (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToInt32 (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的四个字节转换来的 32 位有符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由四个字节构成的 32 位有符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static int ToInt32 (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (int), isBigEndian);
		return BitConverter.ToInt32 (bytes);
	}

	/// <summary>
	/// 返回由字节数组转换来的 32 位无符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由四个字节构成的 32 位无符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static uint ToUInt32 (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToUInt32 (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的四个字节转换来的 32 位无符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由四个字节构成的 32 位无符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static uint ToUInt32 (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (uint), isBigEndian);
		return BitConverter.ToUInt32 (bytes);
	}

	/// <summary>
	/// 返回由字节数组转换来的 64 位有符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由八个字节构成的 64 位有符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static long ToInt64 (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToInt64 (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的八个字节转换来的 64 位有符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由八个字节构成的 64 位有符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static long ToInt64 (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (long), isBigEndian);
		return BitConverter.ToInt64 (bytes);
	}

	/// <summary>
	/// 返回由字节数组转换来的 64 位无符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由八个字节构成的 64 位无符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static ulong ToUInt64 (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToUInt64 (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的八个字节转换来的 64 位无符号整数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由八个字节构成的 64 位无符号整数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static ulong ToUInt64 (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (ulong), isBigEndian);
		return BitConverter.ToUInt64 (bytes);
	}

	/// <summary>
	/// 返回由字节数组转换来的单精度浮点数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由四个字节构成的单精度浮点数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static float ToSingle (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToSingle (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的四个字节转换来的单精度浮点数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由四个字节构成的单精度浮点数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static float ToSingle (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (float), isBigEndian);
		return BitConverter.ToSingle (bytes);
	}

	/// <summary>
	/// 返回由字节数组转换来的双精度浮点数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由八个字节构成的双精度浮点数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static double ToDouble (ReadOnlySpan<byte> bytes, bool isBigEndian = false)
	{
		return ToDouble (bytes, 0, isBigEndian);
	}

	/// <summary>
	/// 返回由字节数组中指定位置的八个字节转换来的双精度浮点数
	/// </summary>
	/// <param name="bytes">指定数据存在的字节数组</param>
	/// <param name="startIndex">从指定位置开始读取</param>
	/// <param name="isBigEndian">指定输入的字节数组是否应使用大端序列进行读取</param>
	/// <returns>由八个字节构成的双精度浮点数</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static double ToDouble (ReadOnlySpan<byte> bytes, int startIndex, bool isBigEndian = false)
	{
		CheckArguments (bytes, startIndex);
		bytes = CheckFormat (bytes, startIndex, sizeof (double), isBigEndian);
		return BitConverter.ToDouble (bytes);
	}

	/// <summary>
	/// 作为字节数组返回指定的 Unicode 字符值
	/// </summary>
	/// <param name="value">要转换的字符</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 2 的字节数组</returns>
	public static byte[] GetBytes (char value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (char)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 作为字节数组返回指定的 16 位有符号整数值
	/// </summary>
	/// <param name="value">要转换的数值</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 2 的字节数组</returns>
	public static byte[] GetBytes (short value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (short)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 作为字节数组返回指定的 16 位无符号整数值
	/// </summary>
	/// <param name="value">要转换的数值</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 2 的字节数组</returns>
	public static byte[] GetBytes (ushort value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (ushort)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 作为字节数组返回指定的 32 位有符号整数值
	/// </summary>
	/// <param name="value">要转换的数值</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 4 的字节数组</returns>
	public static byte[] GetBytes (int value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (int)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 作为字节数组返回指定的 32 位无符号整数值
	/// </summary>
	/// <param name="value">要转换的数值</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 4 的字节数组</returns>
	public static byte[] GetBytes (uint value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (uint)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 作为字节数组返回指定的 64 位有符号整数值
	/// </summary>
	/// <param name="value">要转换的数值</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 8 的字节数组</returns>
	public static byte[] GetBytes (long value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (long)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 作为字节数组返回指定的 64 位无符号整数值
	/// </summary>
	/// <param name="value">要转换的数值</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 8 的字节数组</returns>
	public static byte[] GetBytes (ulong value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (ulong)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 作为字节数组返回指定的单精度浮点数值
	/// </summary>
	/// <param name="value">要转换的数值</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 4 的字节数组</returns>
	public static byte[] GetBytes (float value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (float)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 作为字节数组返回指定的双精度浮点数值
	/// </summary>
	/// <param name="value">要转换的数值</param>
	/// <param name="isBigEndian">指定输出的字节数组是否应使用大端序列进行写入</param>
	/// <returns>长度为 8 的字节数组</returns>
	public static byte[] GetBytes (double value, bool isBigEndian = false)
	{
		Span<byte> result = stackalloc byte[sizeof (double)];
#if NET6_0
		MemoryMarshal.Write (result, ref value);
#elif NET8_0
		MemoryMarshal.Write (result, value);
#endif
		if (isBigEndian && BitConverter.IsLittleEndian)
			result.Reverse ();
		return result.ToArray ();
	}

	/// <summary>
	/// 将指定的字节子数组的每个元素的数值转换为其等效的十六进制字符串表示形式
	/// </summary>
	/// <param name="bytes">字节数组</param>
	/// <param name="startIndex">数组内的起始位置</param>
	/// <param name="length"><paramref name="bytes"/> 中要转换的数组元素的数目</param>
	/// <param name="separator">连字分隔符</param>
	/// <returns>由连字符分隔的十六进制对组成的字符串, 其中每一对表示 <paramref name="bytes"/> 的子数组中相应的元素; 例如 “7F 2C 4A 00”</returns>
	/// <exception cref="ArgumentException">字节数组是空的</exception>
	/// <exception cref="IndexOutOfRangeException">起始索引不能小于0 或 起始索引超出了字节数组的长度</exception>
	public static string ToHex (ReadOnlySpan<byte> bytes, int startIndex, int length, char? separator = null)
	{
		if (bytes.IsEmpty)
			throw new ArgumentException ("字节数组是空的", nameof (bytes));
		if (startIndex < 0)
			throw new IndexOutOfRangeException ("起始索引不能小于0");
		if (startIndex >= bytes.Length)
			throw new IndexOutOfRangeException ("起始索引超出了字节数组的长度");

		int separatorLen = separator.HasValue ? 1 : 0;
		Span<char> result = stackalloc char[length * (2 + separatorLen) - separatorLen];
		int index = 0;
		for (int i = startIndex; i < startIndex + length; i++)
		{
			byte b = bytes[i];
			result[index++] = D2H ((byte)(b >> 4));
			result[index++] = D2H ((byte)(b & 0x0F));

			// 填充分隔符
			if (i < startIndex + length - 1 && separator is not null)
				result[index++] = separator.Value;
		}

		return new string (result);
	}

	/// <summary>
	/// 将指定的十六进制字符串的每个子数值转换其等效为字节数组表示形式
	/// </summary>
	/// <param name="hex">十六进制字符串</param>
	/// <param name="separator">连字分隔符</param>
	/// <returns>包含十六进制转换结果的字节数组</returns>
	/// <exception cref="ArgumentException">字符数组是空的 或 字符数组长度不符合要求</exception>
	/// <exception cref="FormatException">无效的分隔符</exception>
	public static byte[] ToBytes (ReadOnlySpan<char> hex, char? separator = null)
	{
		if (hex.IsEmpty)
			throw new ArgumentException ("字符数组是空的", nameof (hex));
		int separatorLen = separator.HasValue ? 1 : 0;
		if ((hex.Length + separatorLen) % (2 + separatorLen) != 0)
			throw new ArgumentException ("字符数组长度不符合要求", nameof (hex));

		int count = (hex.Length + separatorLen) / (2 + separatorLen);
		Span<byte> result = stackalloc byte[count];

		int index = 0;
		int hexIndex = 0;
		while (index < count)
		{
			byte h = H2D (hex[hexIndex++]);
			byte l = H2D (hex[hexIndex++]);

			result[index++] = (byte)((h << 4) | l);
			if (separator is not null && hexIndex < hex.Length)
			{
				if (hex[hexIndex] != separator)
					throw new FormatException ($"无效的分隔符: {hex[hexIndex]}");
				hexIndex++;
			}
		}
		return result.ToArray ();
	}
	#endregion

	#region --私有方法--
	/// <summary>
	/// 将字节转换为十六进制字符
	/// </summary>
	private static char D2H (byte n) => (char)(n < 0x0A ? n + 0x30 : n - 0x0A + 0x41);
	/// <summary>
	/// 将十六进制字符转换为字节
	/// </summary>
	private static byte H2D (char c)
	{
		if (c >= 0x30 && c <= 0x39)
			return (byte)(c - 0x30);
		if (c >= 0x41 && c <= 0x5A)
			return (byte)(c - 0x41 + 0x0A);
		if (c >= 0x61 && c <= 0x7A)
			return (byte)(c - 0x61 + 0x0A);
		throw new ArgumentException ($"无效的十六进制字符: {c}", nameof (c));
	}

	/// <summary>
	/// 检查参数是否合法
	/// </summary>
	private static void CheckArguments (ReadOnlySpan<byte> bytes, int startIndex)
	{
		if (bytes.IsEmpty)
			throw new ArgumentException ("字节数组是空的", nameof (bytes));

		if (startIndex < 0)
			throw new IndexOutOfRangeException ("起始索引不能小于0");

		if (startIndex >= bytes.Length)
			throw new IndexOutOfRangeException ("起始索引超出了字节数组的长度");
	}
	/// <summary>
	/// 检查序列格式
	/// </summary>
	private static Span<byte> CheckFormat (ReadOnlySpan<byte> source, int startIndex, int len, bool isBigEndian)
	{
		Span<byte> buffer = new byte[len];
		if (source.Length - startIndex < len)
		{
			// 计算需要复制的长度
			int copyLen = len - (len - (source.Length - startIndex));
			// 如果是大端序, 需要将高位字节需要保留0
			if (isBigEndian)
				for (int i = 0; i < copyLen; i++)
					buffer[len - copyLen + i] = source[startIndex + i];
			else
				for (int i = 0; i < copyLen; i++)
					buffer[i] = source[startIndex + i];
		}
		else
			// 如果长度足够, 直接复制
			for (int i = 0; i < len; i++)
				buffer[i] = source[startIndex + i];


		// 如果系统是小端序, 并且输入的是大端序, 需要反转字节序
		if (isBigEndian && BitConverter.IsLittleEndian)
			buffer.Reverse ();
		return buffer;
	}
	#endregion
}
