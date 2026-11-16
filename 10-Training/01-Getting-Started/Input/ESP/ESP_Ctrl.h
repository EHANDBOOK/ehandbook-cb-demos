#ifndef ESP_CTRL_H
#define ESP_CTRL_H

/* ---- Inputs ---------------------------------------------------------- */
extern float v_veh;          /* Vehicle speed [m/s], shared with ABS_Ctrl        */
extern float delta_steer;    /* Road wheel steering angle [rad]                  */
extern float r_meas;         /* Measured yaw rate [rad/s]                        */
extern float T_brake;        /* Brake torque requested by ABS_Ctrl [N*m]         */

/* ---- Outputs --------------------------------------------------------- */
extern float T_esp_req;              /* ESP brake torque request [N*m]           */
extern unsigned char ESP_flgActive;  /* ESP intervention active [0/1]            */

/* ---- Local signals --------------------------------------------------- */
extern float r_ref;          /* Reference yaw rate from single-track model [rad/s] */
extern float e_yaw;          /* Yaw rate error [rad/s]                           */
extern float T_headroom;     /* Brake torque headroom left by ABS [N*m]          */

/* ---- Calibrations ---------------------------------------------------- */
extern const float ESP_WheelBase;   /* Vehicle wheelbase [m]                          */
extern const float ESP_vCharac;     /* Characteristic speed of the vehicle [m/s]      */
extern const float ESP_KpYaw;       /* Yaw rate controller gain [N*m/(rad/s)]         */
extern const float ESP_YawErrThr;   /* Yaw rate error threshold for intervention [rad/s] */
extern const float ABS_BrkGainKf;   /* Brake gain [N*m], calibration owned by ABS_Ctrl */

void ESP_Ctrl_Step(void);

#endif /* ESP_CTRL_H */
