typedef struct {
    float a;
    float b;
} Data;

void process_address_and_member_access() {
    Data data;

    data.a = 1.0;
    data.b = 2.0;

    // GetAddr: address of variable/member
    Data* pData = &data;
    float* pB = &data.b;

    // GetMember: read struct member
    float memberRead = data.a;

    // Prevent unused-variable optimization in example code
    data.a = memberRead + pData->b + *pB;
}

void process_pointer_and_index_read() {
    Data data;
    float values[4];

    data.a = 1.0;
    data.b = 2.0;
    values[0] = 10.0;
    values[1] = 20.0;
    values[2] = 30.0;
    values[3] = 40.0;

    float* pB = &data.b;

    // GetDeref: read value via pointer
    float derefRead = *pB;

    // GetIndexDeref: read array element
    float indexRead = values[2];

    // Prevent unused-variable optimization in example code
    data.a = derefRead + indexRead;
}

void process_write_access() {
    Data data;
    float values[4];

    data.a = 1.0;
    data.b = 2.0;
    values[0] = 10.0;
    values[1] = 20.0;
    values[2] = 30.0;
    values[3] = 40.0;

    Data* pData = &data;
    float* pB = &data.b;
    float memberRead = data.a;
    float derefRead = *pB;
    float indexRead = values[2];

    // SetMember: write struct member
    data.a = indexRead;

    // SetDeref: write value via pointer
    *pB = memberRead + derefRead;

    // SetIndexDeref: write array element
    values[1] = pData->a;
}
