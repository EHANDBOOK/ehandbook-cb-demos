/**
 * ESP_Ctrl.c - simplified Electronic Stability Program.
 *
 * Compares the measured yaw rate with a reference from a single-track model
 * and requests a corrective brake torque. The request is limited to the
 * torque headroom left by the ABS (ABS_BrkGainKf - T_brake).
 */

#include <math.h>
#include "ESP_Ctrl.h"

/* Outputs */
float T_esp_req = 0.0f;
unsigned char ESP_flgActive = 0u;

/* Local signals */
float r_ref = 0.0f;
float e_yaw = 0.0f;
float T_headroom = 0.0f;

/* Calibrations */
const float ESP_WheelBase = 2.7f;
const float ESP_vCharac = 20.0f;
const float ESP_KpYaw = 800.0f;
const float ESP_YawErrThr = 0.05f;

/**
 * Cyclic step function, called every 10 ms.
 */
void ESP_Ctrl_Step(void)
{
    /* Avoid division by zero at standstill */
    float v = (v_veh > 1.0f) ? v_veh : 1.0f;
    float k = 1.0f + (v / ESP_vCharac) * (v / ESP_vCharac);

    /* Steady-state yaw rate of the single-track model */
    r_ref = (v * delta_steer) / (ESP_WheelBase * k);
    e_yaw = r_ref - r_meas;

    /* Torque the ABS does not use */
    T_headroom = ABS_BrkGainKf - T_brake;
    if (T_headroom < 0.0f) {
        T_headroom = 0.0f;
    }

    if (fabsf(e_yaw) > ESP_YawErrThr) {
        ESP_flgActive = 1u;
        T_esp_req = ESP_KpYaw * fabsf(e_yaw);
        if (T_esp_req > T_headroom) {
            T_esp_req = T_headroom;
        }
    } else {
        ESP_flgActive = 0u;
        T_esp_req = 0.0f;
    }
}
