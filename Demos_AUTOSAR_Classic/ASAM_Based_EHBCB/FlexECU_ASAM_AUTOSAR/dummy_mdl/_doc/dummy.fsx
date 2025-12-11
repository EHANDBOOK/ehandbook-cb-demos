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
						<SHORT-NAME>Component Control</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Component Control</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Dummy Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Dummy.Dummy_mdl</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="JPG" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Dummy</SHORT-NAME>							
							<P>
								<L-1 L="DE">
									Das Modul Dummy stellt einen Platzhalter für alle
									noch nicht vollständig integrierten
									Komponentenansteuerungen
									dar. Hier werden Parameter als Nachrichten weitergereicht
									um die
									Aktuatorikmodule zubedienen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Dazu geh�ren:
								</L-1>
							</P>
							<LIST TYPE="UNNUMBER">
								<ITEM>
									<P>
										<L-1 L="DE">das Tastverhältnis des Umschaltventils Sekundärluft
											dummy_facAirPumpRate_Sim</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">das Tastverhältnis des Umschaltventils Druckgeber
											dummy_facChOverVlvRate_Sim</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">der Zustand (true/false) des Hauptrelais
											dummy_stMainRelais_Sim</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">der Zustand (true/false) der Kraftstoffpumpe
											dummy_stFuelPump_Sim</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">der Zustand (true/false) des Ladeluftkühlers
											dummy_stIntercooler_Sim</L-1>
									</P>
								</ITEM>
								<ITEM>
									<P>
										<L-1 L="DE">der Zustand (true/false) der Sekundärluftpumpe
											dummy_stAirInjReacPump_Sim</L-1>
									</P>
								</ITEM>
							</LIST>
							<P>
								<L-1 L="DE">
									Ausserdem ist es zu Test- und Demonstrationszwecken
									möglich durch Setzen des Flags
									dummy_flgT2tOverride auf einen
									direkten Durchgriff des Egas-Stellers zur Drosselklappe
									umzuschalten, d. h., die Positionsanforderung
									dummy_facThrValveReq_Sim an die Drosselklappe
									entspricht eins zu
									eins der Position des Egas-Stellers Egc_facEgas_Sim. Im
									Regelfall kommt
									diese Stellgrösse aus der Funktion
									Momentenumrechnung (T2t_facThrValveReq_Sim).
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Auswertung der Funktion dummy_calc erfolgt im
									100ms-Raster.
								</L-1>
							</P>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
