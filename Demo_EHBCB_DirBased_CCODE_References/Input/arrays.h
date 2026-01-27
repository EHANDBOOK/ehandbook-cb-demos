
#define SIX  6
#define ROWS 3

// an array with six elements
typedef int sixpack[SIX];

// an array of three sixpacks
typedef  sixpack box[ROWS];

// new array type
typedef char BALOONS[99] ;

// new array of array type
typedef BALOONS ROWS_OF_BALOONS[5];

int AccessOneDimensional(int oneDim[], int offset);
int AccessCompileTimeInitialized(int value, int offset);
void AccessTwoDimensional(ROWS_OF_BALOONS rows, int dim1, int dim2);
void CopyWithForLoop(sixpack one, sixpack two, int count);
void CopyWithIncrementDecrement(sixpack one, sixpack two, int count);
