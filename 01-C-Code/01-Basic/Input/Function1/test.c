int add(int summand1, int summand2) {
	return summand1 + summand2;
}

int sub(int minuend, int subtrahend) {
	return minuend - subtrahend;
}

int in1, in2, loc1, loc2, sig1, sig2;

void main() {	

	loc1 = add(in1,in2);
	loc2 = sub(loc1,in1);

	sig1 = mul(loc1,loc2);
	sig2 = div(loc1,loc2);
}