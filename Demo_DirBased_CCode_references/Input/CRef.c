
//
#include "structs.h"
#include "arrays.h"

#include "stddef.h"



// struct with array
struct StructAndArray {
	int value;
	char s[5];
} structAndArray;

struct StructAndTypeDefedArray {
	int value;
	BALOONS s;
} structAndTypeDefedArray;

struct StructAndMultiDimArray {
	int value;
	ROWS_OF_BALOONS st;
} structAndMultiDimArray;

struct StructAndPointerArray {
	int value;
	char *s[5];
} structAndPointerArray;

struct StructAndPointerToArray {
	int value;
	ROWS_OF_BALOONS * b;
} structAndPointerToArray;

struct StructAndPointerToArray manyN[5];

struct StructAndTwoArrays {
	int a[1];
	int b[1];
} structAndTwoArrays;

struct StructInStructAndArray {
	struct StructTypeName a[1];
} nestedStructAndArray;


struct Q {
	int value;
	struct Q1 {
		int values[5];
		struct Q2 {
			int values[5];
			struct Q3 {
				int values[5];
			} inner3[5];
		} inner2[5];
	} inner1[5];
} mixedAndNested;





int main()
{
	structAndArray.value = 1;
	structAndArray.s[0] = 'a';

	structAndTypeDefedArray.value = 1;
	structAndTypeDefedArray.s[1] = 'b';

	structAndMultiDimArray.value = 1;
	structAndMultiDimArray.st[0][1] = 'c';

	structAndPointerArray.value = 1;
	structAndPointerArray.s[1][1] = 'd';

	ROWS_OF_BALOONS someBaloons;
	structAndPointerToArray.value = 1;
	structAndPointerToArray.b = &someBaloons;
	(*structAndPointerToArray.b)[0][1] = 'n';

	manyN[0].value = 1;
	*manyN[1].b[0][1] = 'z';

	structAndTwoArrays.a[0] = 1;
	structAndTwoArrays.b[0] = 2;
	structAndTwoArrays.a[0] = structAndTwoArrays.b[0];

	nestedStructAndArray.a[0].value = 1;

	mixedAndNested.value = 1;
	mixedAndNested.inner1[0].values[0] = 1;
	mixedAndNested.inner1[1].inner2[2].values[0] = 1;
	mixedAndNested.inner1[1].inner2[2].inner3[3].values[0] = 1;

	return 0;
}

