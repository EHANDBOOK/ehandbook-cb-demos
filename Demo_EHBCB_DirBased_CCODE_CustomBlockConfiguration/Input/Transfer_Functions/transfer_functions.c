void process1() {
    // Example without dedicated DT1 metadata mapping
    float in;
    float Ta;
    float K;
    float T;

    float y = DT1_Filter_compute_V1(in, Ta, K, T);
}

void process2() {
    // Example with dedicated DT1 metadata mapping
    float in;
    float Ta;
    float K;
    float T;

    float y = DT1_Filter_compute_V2(in, Ta, K, T);
}
