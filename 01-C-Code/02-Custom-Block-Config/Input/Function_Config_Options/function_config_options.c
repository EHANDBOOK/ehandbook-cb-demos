void process1_port_default() {
    float in;
    float out = portTop_raw(in);
}

void process2_port_top() {
    float in;
    float out = portTop(in);
}

void process1_port_left() {
    float in;
    float out = portLeft_raw(in);
}

void process2_port_left() {
    float in;
    float out = portLeft(in);
}

void process1_port_bottom() {
    float in;
    float out = portBottom_raw(in);
}

void process2_port_bottom() {
    float in;
    float out = portBottom(in);
}

void process1_port_invisible() {
    float in;
    float out = portInvisible_raw(in);
}

void process2_port_invisible() {
    float in;
    float out = portInvisible(in);
}

void process1_instance_name() {
    float instanceId;
    float out = instanceName_raw(instanceId);
}

void process2_instance_name() {
    float instanceId;
    float out = instanceName(instanceId);
}

void process1_reference_arg() {
    float refValue;
    float out = referenceArg_raw(&refValue);
}

void process2_reference_arg() {
    float refValue;
    float out = referenceArg(&refValue);
}

void process1_instance_reference() {
    float instanceRef;
    float out = instanceReference_raw(&instanceRef);
}

void process2_instance_reference() {
    float instanceRef;
    float out = instanceReference(&instanceRef);
}
