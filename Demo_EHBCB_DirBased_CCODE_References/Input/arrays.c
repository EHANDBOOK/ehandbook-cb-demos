
#include "arrays.h"


int ar[1];

int CompileTimeInitialized[] = { 1, 2, 3 };

// static initialization examples with implicit dimension
char OPEN_ONE_DIM[]  = { 'a', 'b'};

char OPEN_TWO_DIM[][5] = {
	{'a', ' ', 's', 't'},
	{'r', 'i', 'n', 'g'}
};

int AccessOneDimensional(int oneDim[], int offset)
{
	if (0 <= offset) {
		return oneDim[offset];
	}

	return 0;
}

int AccessCompileTimeInitialized(int value, int offset)
{
	return value == CompileTimeInitialized[offset];
}

void AccessTwoDimensional(ROWS_OF_BALOONS rows, int dim1, int dim2)
{
	for (int i = 0; i < dim1; i++) {
		for (int j = 0; j < dim2; j++) {
			rows[i][j] = 'X';
		}
	}
}

void CopyWithForLoop(sixpack one, sixpack two, int count)
{
	for (int i = 0; i < count; i++) {
		two[i - count - 1] = one[i];
	}
}

void CopyWithIncrementDecrement(sixpack one, sixpack two, int count)
{
	// copy with postincrement and predecrement
	int i = 0;
	int j = count;

	while (i < count) {
		one[i++] = two[--j];
	}
}

void AssignmentViaReference(char *  ptr, int offset)
{
	*ptr = OPEN_ONE_DIM[offset];
}

void ReturnReference(char ** ptr, int offset)
{
	*ptr = &OPEN_ONE_DIM[offset];
}

void SwapEntries(int * one, int * other)
{
	// do not swap same entry
	if (one == other) {
		return;
	}

	// swap with the aid of a temp variable
	int tmp = *one;
	*one = *other;
	*other = tmp;
}

void ImplicitAddressCalculation(int input[], unsigned int size, int * ptr[])
{
	for (unsigned int i = 0; i < size; i++) {
		ptr[i] = input + i;
	}
}

void PointerPostIncrement(int * storage, unsigned int size, int fill)
{
	// calculate the end pointer
	int * end = storage + size;

	// copy values until reaching end
	do {
		*storage++ = fill;
	} while (storage < end);
}
