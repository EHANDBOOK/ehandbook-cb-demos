void process1() {
    // Example without dedicated metadata mapping
    float x;
    float min;
    float max;
    float y = SrvF_Limit_V1(x, min, max);
}

void process2() {
    // Example with dedicated metadata mapping
    float x;
    float min;
    float max;
    float y = SrvF_Limit_V2(x, min, max);
}
