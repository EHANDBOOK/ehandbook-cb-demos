<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE MSRSW PUBLIC "-//ASAM//DTD FUNCTIONAL SPECIFICATION EXCHANGE FORMAT:V1.1.0:LAI:IAI:XML:ML.FSX110.DTD//EN" "fsx_v1_1_0.ml.dtd">
<!--FS2FSX Converter Version 1.0 -->
<MSRSW>
	<CATEGORY>FSX</CATEGORY>
	<ADMIN-DATA>
		<LANGUAGE>de</LANGUAGE>
		<USED-LANGUAGES>
			<L-10 L="DE" />
		</USED-LANGUAGES>
	</ADMIN-DATA>
	<SW-SYSTEMS>
		<SW-SYSTEM>
			<SHORT-NAME>MEDC17</SHORT-NAME>
			<LONG-NAME>
				<L-4 L="EN">EDC/ME(D)17</L-4>
			</LONG-NAME>
			<SW-COMPONENT-SPEC>
				<SW-COMPONENTS>
					<SW-FEATURE>
						<SHORT-NAME>Engine Position Management</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Engine Position Management</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Epm Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Epm_dummy.Main</SHORT-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.5">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Functionality</SHORT-NAME>
							<P>
								<L-1 L="EN">
									The EPM software module provides the interface to the
									physical CAM and CRANK position sensors.
								</L-1>
							</P>
							<P>
								<L-1 L="EN">
									The EPM module provides:
								</L-1>
							</P>
							<LIST TYPE="UNNUMBER">
								<ITEM>
									<P>
										<L-1 L="EN">Calculation of the engine speed and acceleration
											from the crankshaft signal</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="EN">Generation of the angle-synchronous interrupts
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="EN">Calibration of the crankshaft and camshaft patterns
										</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="EN">Calibration of the actual number of cylinders</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="EN">Calibration of the physical firing order of the
											engine</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="EN">Calibration of the orientation between crank, cam,
											and TDC</L-1>
									</P>
								</ITEM>
							</LIST>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>
								Reference/Calibrated Position during adaptation and start
							</SHORT-NAME>
							<P>
								<L-1 L="EN">
									During engine start-up the CAM shafts must be in reference/calibrated
									(default/un-shifted) position. While minor shifts of the
									phasing is acceptable, wide variations from the calibrated
									position may lead to the inability to reach synchronization and
									run the engine.
									VVT requires that adaptation is only done while attached CAMs are
									in the reference/calibrated position.
								</L-1>
							</P>
							<NOTE NOTE-TYPE="HINT">
								<P>
									<L-1 L="EN">It is strongly recommended to minimize all
										computations performed by the AppSw until EPM initialization
										is completed. AppSw can monitor the status of the message
										EpmSyn_stCasEval for transition to the state “SWTOFF_CASPOS”
										which indicated plausibility checks of CAM and CRANK have
										completed. </L-1>
								</P>
								<P>
									<L-1 L="EN">Similar comment during the initial CAM adaptation
										after synch is reached if VVT is to be utilized sooner.</L-1>
								</P>
							</NOTE>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>