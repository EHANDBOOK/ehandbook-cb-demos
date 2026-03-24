
void process1() {
    // Example of using a 1D interpolation function
    float x;
    float data1D[10];
    float y = interpolate1D_V1(data1D, x);
    
    // Example of using a 2D interpolation function
    float x1;
    float x2;
    float data2D[10][10];
    float z = interpolate2D_V1(data2D, x1, x2);
}

void process2() {
    // Example of using a 1D interpolation function
    float x;
    float data1D[10];
    float y = interpolate1D_V2(data1D, x);
    
    // Example of using a 2D interpolation function
    float x1;
    float x2;
    float data2D[10][10];
    float z = interpolate2D_V2(data2D, x1, x2);
}