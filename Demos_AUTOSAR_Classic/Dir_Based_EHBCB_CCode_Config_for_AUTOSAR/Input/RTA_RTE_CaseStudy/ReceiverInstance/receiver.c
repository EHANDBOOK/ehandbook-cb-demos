/** \file      receiver.c
  *
  * \brief     Component Implementation
  *
  * [$crn:2005:doxygen 
  * \copyright Copyright 2005 - 2007 LiveDevices Ltd.
  *            Copyright 2007 - 2008 ETAS Engineering Tools Application and Services Ltd.
  *            Copyright 2008 - 2018 ETAS GmbH.
  * $]
  *            www.etasgroup.com
  *
 * $Rev: 15373 $ $Date: 2009-03-31 17:56:43 +0100 (Tue, 31 Mar 2009) $
  */

#include "Rte_ReceiverComponent.h" /* Automatically generated file by RTEGen */
#include "target.h"                /* Please define LED_*() macros here */

/* ---------------------------------------------------------------------- */
/* Runnable: ReceiverComponent.InputPort_CaseStudyData
 *  
 * Event: /autosar/ReceiverInternal/InputPort_CaseStudyData_Event 
 * Event type: DATA-RECEIVED-EVENT
 * Mode disabling dependencies: No
 */

FUNC(void, RTE_APPL_CODE)
Receiver_InputPort_CaseStudyData(Rte_Instance self)
{
   sint16 message;

   Rte_Read_InputPort_CaseStudyData(self, &message);

   if (LED_TEST())
   {
      LED_OFF();
   }
   else
   {
      LED_ON();
   }
}

/* ---------------------------------------------------------------------- */
/* Runnable: ReceiverComponent.initialize
 *  
 * Event: /autosar/ReceiverInternal/mse1 
 * Event type: MODE-SWITCH-EVENT (ENTRY, /autosar/mg1/imode)
 * Mode disabling dependencies: No
 */

FUNC(void, RTE_APPL_CODE)
Receiver_initialize(Rte_Instance self)
{
   LED_INIT();
}
