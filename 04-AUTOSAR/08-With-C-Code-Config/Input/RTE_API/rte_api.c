


void Runnable() {	
	/*
	Std_ReturnType Rte_Call_<p>_<o>([IN Rte_Instance <instance>,] [IN|INOUT|OUT] param_1, ... [IN|INOUT|OUT] param_n)

	Where <p> is the port name and <o> the operation within the client-server interface that categorizes the port.
	*/
	Rte_Call_Port_Operation(self, param1, param2);


	/*
	<data type> const Rte_Prm_<port>_<name>([IN Rte_Instance <Instance>])

	Where <name> is the name of the calibration element to access and <port> the name of the require port name(which must be categorized by a calibration interface).
	*/
	UInt16 abc = Rte_Prm_Port_abc(self);

	/*
	Rte_CData <data type> const Rte_CData_<name>([IN Rte_Instance <Instance>])
	
	Where <name> is the name of the calibration element.	
	*/
	UInt16 abc = Rte_CData_abc(self);

	/*
	Std_ReturnType Rte_Enter_<area>([IN Rte_Instance <instance>]) 

	Where <area> is the exclusive area name.	
	*/
	Rte_Enter_A(self);


	/*
	Std_ReturnType Rte_Exit_<area>([IN Rte_Instance <instance>])

	Where <area> is the exclusive area name.
	*/
	Rte_Exit_A(self);

	/*
	Std_ReturnType Rte_IFeedback_<re>_<port>_<item>([IN Rte_Instance <inst>])

	Where <re> is the accessing runnable entity name, <port> is the port name and <item> the data element within the sender-receiver interface categorizing the port.	
	*/

	Rte_Write_pa_val(self, 23);
	if (Rte_IFeedback_re1_pa_val(self) == RTE_E_TRANSMIT_ACK)
	{
	/* Transmit okay */
		TransmitOK();
	}	



	/*

	*/

	/*
	<data type> Rte_IRead_<re>_<p>_<d>([IN Rte_Instance <inst>))

	Where <re> is the runnable entity name, <p> is the port name	
	*/
	//SInt16 a;
	a = Rte_IRead_re1_ra_val(self);

	/*
	void Rte_IWrite_<re>_<p>_<d>([IN Rte_Instance <inst>] IN <type> <data>)

	Where re is the runnable entity name, p is the port name and d the data element within the sender-receiver interface categorizing the port.
	*/
	Rte_IWrite_re1_pa_val(self, 23);

	/*
	<type>* Rte_IWriteRef_<re>_<p>_<d>([IN Rte_Instance]) 

	Where re is the runnable entity name, p is the port name and d the data element within the sender-receiver interface categorizing the port.	
	*/
	RecType* r = Rte_IWriteRef_re1_ra_val(self); 
	r->field = 23;

	/*
	<data type> Rte_IrvIRead_<re>_<name>([IN Rte_Instance <inst>])
	
	Where <re> is the runnable entity name and <name> the inter-runnable variable name.
	*/	
	//SInt16 a;
	a = Rte_IrvIRead_re1_irvl(self);

	/*
	void Rte_IrvIWrite_<re>_<name>([IN Rte_Instance <inst>], IN <data>)

	Where <re> is the runnable entity name and <name> the inter-runnable variable name.
	*/
	//SInt16 a;
	Rte_IrvIWrite_re1_irvl(self, a);

	/*
	<data type> Rte_IrvRead_<re>_<name>([IN Rte_Instance <inst>])
	
	Where <re> is the runnable entity name and <name> the inter-runnable variable name.
	*/
	//SInt16 a;	
	a = Rte_IrvRead_re1_irvl(self);

	/*
	void Rte_IrvWrite_<re>_<name>([IN Rte_Instance <inst>], IN <data>)

	Where <re> is the runnable entity name and <name> the inter-runnable variable name.	
	*/
	//SInt16 a;
	Rte_IrvWrite_re1_irvl(self, a);

	/*
	Rte_IStatus
	Rte_IsUpdated
	Rte_MainFunction
	Rte_Mode
	Rte_Ports
	Rte_NPorts
	Rte_Port
	Rte_Pim
	*/

	/*
	Std_ReturnType Rte_Read_<port>_<item>([IN Rte_Instance <inst>,] OUT <data>)
	Where <port> is the port name and <item> the data element within the sender-receiver interface that categorizes the port.
	*/
	SInt16 a;
	Std_ReturnType e = Rte_Read_ra_val(self, &a);
	if (e == RTE_E_OK)
	{
		/* Read okay */
		ReadOK();
	}

	/*
	<type> Rte_DRead_<port>_<item>([IN Rte_Instance <inst>])

	Where <port> is the port name and <item> the data element within the sender-receiver interface that categorizes the port.	
	*/
	SInt16 a;
	Std_ReturnType e = Rte_DRead_ra_val(self, &a);
	if (e == RTE_E_OK)
	{	
		/* Read okay */
		ReadOK();
	}	


	/*
	Std_ReturnType Rte_Receive_<port>_<item>([IN Rte_Instance <inst>,] OUT <data>)

	Where <port> is the port name and <item> the data element within the sender-receiver interface that categorizes the port.
	*/
	SInt16 a;
	Std_ReturnType e = Rte_Receive_ra_val(self, &a);
	if (e == RTE_E_OK)
	{
		/* Receive okay */	
		ReceiveOK();
	}

	/*
	Std_ReturnType Rte_Result_<port>_<op>([IN Rte_Instance <inst>,] [OUT <out_param_1>], ..., [OUT <out_param_n>])

	Where <port> is the port name and <op> the operation within the client-server interface that categorizes the port.

	Description: The Rte_Result API is used to poll for the result and the error state of an asynchronous client-server communication. The call can be either blocking or non-blocking.
	*/	
	SInt16 a;
	Std_ReturnType e;
	Rte_Call_pa_op1(self, 1);
	e = Rte_Result_pa_op1(self, &a)
	if (e == RTE_E_OK)
	{
		/* Result received okay */
		ReceiveOK();
	}

	/*
	Rte_Send_Std_ReturnType Rte_Send_<port>_<item>([IN Rte_Instance <inst>,] IN <data>)

	Where <port> is the port name and <item> the data element within the sender-receiver interface that categorizes the port.

	Description: Initiates a sender-receiver communication using queued semantics.	
	*/
	Std_ReturnType e = Rte_Send_ra_val(self, 23);
	if (e == RTE_E_OK)
	{
		/* Transmission okay */
		TransmissionOK();
	}	


	/*
	Std_ReturnType Rte_Start( void )

	Description: This function is invoked (typically by the ECU state manager or possibly by user code) to start the RTE.
	*/
	Rte_Start();

	/*
	Std_ReturnType Rte_Stop( void )

	Description: This function is invoked (typically by the ECU state manager or possibly by user code) to stop the RTE.
	*/
	Rte_Stop();	

	/*
	Rte_Switch Std_ReturnType Rte_Switch_<port>_<item>([IN Rte_Instance <inst>,] IN <data>)

	Where <port> is the port name and <item> the mode declaration group prototype name within the sender-receiver interface categorizing the port.

	Description: Initiates a mode switch transition within a “mode graph”.	
	*/
	Std_ReturnType e;
	e = Rte_Switch_ra_mode(self, RTE_MODE_RUN);
	if (e != RTE_E_OK)
	{
		/* Mode switch request failed */
		ModeSwitchRequestFailed();
	}


	/*
	void Rte_Tick_Timeouts(void)

	Description: Rte_Tick_Timeouts ticks the Rte_Tout_Counter and sets any necessary OS events when alarms expire.
	*/
	Rte_Tick_Timeouts();


	/*
	void Rte_Trigger_<p>_<itp>(void)

	Where <p> is the port name and <itp> is the name of the InternalTriggeringPoint.	

	Description: Trigger the execution for all runnables whose ExternalTriggerOccurredEvent is associated with the trigger.
	*/
	Rte_Trigger_p_itp();

	/*
	void Rte_IrTrigger_<re>_<itp>(void)

	Where <re> is the runnable entity name and <itp> is the name of the InternalTriggeringPoint.

	Description: Trigger the execution for all runnables whose InternalTriggerOccurredEvent is associated with the trigger.
	*/
	Rte_IrTrigger_re_itp();

	/*
	Std_ReturnType Rte_Write_<port>_<data>([IN Rte_Instance <inst>,] IN <data>)

	Where <port> is the port name and <item> the data element within the sender-receiver interface that categorizes the port.	

	Description: Rte_Write initiates sender-receiver communication using “UNQUEUED” semantics.
	*/
	SInt16 a;
	Std_ReturnType e = Rte_Write_ra_val(self, a);
	if (e == RTE_E_OK)
	{
		/* Transmission okay */
		TransmissionOK();
	}

}
