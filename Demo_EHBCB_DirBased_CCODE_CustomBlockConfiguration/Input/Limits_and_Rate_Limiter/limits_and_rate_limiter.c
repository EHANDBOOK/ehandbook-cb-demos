void process1_saturation() {
    // Example without dedicated metadata mapping
    float in;
    float min;
    float max;

    float limited = saturation_V1(in, min, max);
}

void process2_saturation() {
    // Example with dedicated metadata mapping
    float in;
    float min;
    float max;

    float limited = saturation_V2(in, min, max);
}

void process1_rate_limiter() {
    // Example without dedicated metadata mapping
    float in;
    float rise;
    float fall;

    float shaped = rateLimiter_V1(in, rise, fall);
}

void process2_rate_limiter() {
    // Example with dedicated metadata mapping
    float in;
    float rise;
    float fall;

    float shaped = rateLimiter_V2(in, rise, fall);
}
