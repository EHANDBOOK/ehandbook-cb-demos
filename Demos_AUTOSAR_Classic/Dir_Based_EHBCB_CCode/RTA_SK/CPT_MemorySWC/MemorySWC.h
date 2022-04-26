#ifndef MEMORYSWC_H
#define MEMORYSWC_H

#define BLOCK_CHANGED        1u

#define MEM_TEST_WAITING    1u
#define MEM_TEST_RESTART    0u
#define MEM_TEST_FINISHED   2u

#define TEST_VALUE          0x3333
#define MEM_TEST_CODE       0xA0

extern volatile uint8 memTestState;

/* MEMORYSWC_H */
#endif
