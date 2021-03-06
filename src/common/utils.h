/**
\author		Korotkov Andrey aka DRON
\date		08.03.2017 (c)Korotkov Andrey

This file is a part of DGLE project and is distributed
under the terms of the GNU Lesser General Public License.
See "DGLE.h" for more details.
*/

#pragma once

#include <DGLE.h>
#include <string>

namespace detail
{
	template<signed offset>
	inline constexpr const char *const FindFilename(const char path[])
	{
		return path[offset] == '\\' || path[offset] == '/' ? path + offset + 1 : FindFilename<offset - 1>(path);
	}

	template<>
	inline constexpr const char *const FindFilename<-1>(const char path[])
	{
		return path;
	}
}

// use C++14 extended constexpr
template<signed length>
inline constexpr const char *const ExtractFilename(const char (&path)[length])
{
	static_assert(length > 0, "path must be null-terminated string");
	return detail::FindFilename<length - 1>(path);
}

template<typename Char>
std::basic_string<Char> ToLowerCase(std::basic_string<Char> str);

template<typename Char>
std::basic_string<Char> ToUpperCase(std::basic_string<Char> str);

template<typename Char>
inline auto ToLowerCase(const Char str[])
{
	return ToLowerCase(std::basic_string<Char>(str));
}

template<typename Char>
inline auto ToUpperCase(const Char str[])
{
	return ToUpperCase(std::basic_string<Char>(str));
}

bool StrToBool(std::string str);

std::string ToStrX(DGLE::uint val);
std::string ToStrFmt(double val);
std::string ToStrExp(double val);
std::string BoolToStr(bool val);

DGLE::uchar EngKeyToASCIIKey(const DGLE::uint8 key);
DGLE::uint8 ASCIIKeyToEngKey(const DGLE::uchar key);

DGLE::uint32 GetCRC32(const DGLE::uint8 *pData, DGLE::uint32 ui32Size);

DGLE::uint8 GetPixelDataAlignmentIncrement(DGLE::uint uiLineWidth, DGLE::uint8 ui8BytesPerPixel, DGLE::uint8 ui8Alignment);