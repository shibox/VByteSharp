// VByte.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include <stdint.h> // please use a C99-compatible compiler
#include <stddef.h>

//extern "C" __declspec(dllexport) size_t vbyte_encode(uint32_t *in, size_t length, uint8_t *bout)
//{
//	return vbyte_encode;
//}
//
//extern "C" __declspec(dllexport) size_t masked_vbyte_decode(const uint8_t* in, uint32_t* out, uint64_t length)
//{
//	return 0;
//}

extern "C" __declspec(dllexport) int Add(int x, int y)
{
	return x + y;
}