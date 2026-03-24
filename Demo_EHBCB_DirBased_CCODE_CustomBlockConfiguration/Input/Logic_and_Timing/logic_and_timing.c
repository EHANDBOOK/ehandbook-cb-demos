void process1_edge_rising() {
    // Example without dedicated metadata mapping
    float in;
    float out = risingEdgeDetector_V1(in);
}

void process2_edge_rising() {
    // Example with dedicated metadata mapping
    float in;
    float out = edgeRising_V2(in);
}

void process1_edge_falling() {
    // Example without dedicated metadata mapping
    float in;
    float out = fallingEdgeDetector_V1(in);
}

void process2_edge_falling() {
    // Example with dedicated metadata mapping
    float in;
    float out = edgeFalling_V2(in);
}

void process1_timer() {
    // Example without dedicated metadata mapping
    float in;
    float duration;
    float out = timer_V1(in, duration);
}

void process2_timer() {
    // Example with dedicated metadata mapping
    float in;
    float duration;
    float out = timer_V2(in, duration);
}
