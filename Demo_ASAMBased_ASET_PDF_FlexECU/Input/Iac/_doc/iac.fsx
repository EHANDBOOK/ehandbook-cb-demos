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
						<SHORT-NAME>Ignition Angle Calculation</SHORT-NAME>
						<LONG-NAME>
							<L-4 L="EN">Ignition Angle Calculation</L-4>
						</LONG-NAME>
						<CATEGORY>FCT</CATEGORY>
						<CHAPTER>
							<SHORT-NAME>Overview</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Overview</L-4>
							</LONG-NAME>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>Iac Function Overview</SHORT-NAME>
                                </FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71"></GRAPHIC>
								 </L-GRAPHIC>
							</FIGURE>
							<FIGURE>
								<FIGURE-CAPTION>
									<SHORT-NAME>IgnitionAngle.Main</SHORT-NAME>
									<LONG-NAME>
										<L-4 L="DE">
										</L-4>
									</LONG-NAME>
								</FIGURE-CAPTION>
								<L-GRAPHIC L="FOR-ALL">
									<GRAPHIC NOTATION="EPS" SCALE="0.71">
									</GRAPHIC>
								</L-GRAPHIC>
							</FIGURE>
						</CHAPTER>
						<CHAPTER>
							<SHORT-NAME>Zündwinkel</SHORT-NAME>
							<LONG-NAME>
								<L-4 L="EN">Zündwinkel</L-4>
							</LONG-NAME>
							<P>
								<L-1 L="DE">
									Im Modul Zündwinkel (IngnitionAngle) wird aus der Drehzahl
									<TT TYPE="VARIABLE">Epm_rpmEngSpd</TT>
									und der re-
									lativen Füllung
									<TT TYPE="VARIABLE">Amf_facRelAir</TT>
									zum einen der Basiszündwinkel
									<TT TYPE="VARIABLE">Iac_degIgnBase</TT>
									bestimmt
									und zum anderen der optimale Zündwinkel
									<TT TYPE="VARIABLE">Iac_degMinAdvBestTq</TT>
									. Der Basiszündwinkel
									beschreibt den Winkel des höchsten
									Drehmoments, bei dem gerade noch kein Klopfen
									auftritt. Er wird
									über das Kennfeld
									<TT TYPE="PRM">Iac_rpmEngSpdfacRelAir2degBase_MAP</TT>
									berechnet
									und kann anschließend zur Sicherheit mit dem Offset
									<TT TYPE="PRM">Iac_degIgnOptOffset</TT>
									nach spät
									verschoben werden, bevor der einzustellende Zündwinkel
									<TT TYPE="VARIABLE">Iac_degIgn</TT>
									als Nachricht weiter-
									gegeben wird. Hierbei bedeutet, im
									Gegensatz zur Smartmotorsteuerung, ein positiver Wert,
									dass die
									Zündung vor dem oberen Zündtotpunkt stattfindet, ein negativer
									Winkel danach,
									d. h. durch die Grundparametrierung des Offsets
									<TT TYPE="PRM">Iac_degIgnOptOffset</TT>
									mit -5,0°KW
									wird der Zündwinkel nach spät gezogen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Über das Kennfeld
									<TT TYPE="PRM">Iac_rpmEngSpdfacRelAir2degMinAdvBestTq_MAP</TT>
									wird der optimale
									Zündwinkel bestimmt, d. h. der Winkel, bei dem
									der Motor unter den vorherrschenden
									Bedingungen das höchste
									Drehmoment abgeben würde. Die Zündung darf in der Regel
									nicht
									bei diesem Winkel stattfinden, da unter Umständen erhebliches
									Klopfverhalten
									auftritt und der Motor in kürzester Zeit zerstört
									wird. Beide Kennfelder sind direkt dem
									Funktionsrahmen der
									Smartmotorsteuerung entnommen.
								</L-1>
							</P>
							<P>
								<L-1 L="DE">
									Die Auswertung der Funktion Iac_calc erfolgt im
									Synchron-Raster. Durch das Flag
									<TT TYPE="PRM">Iac_flgIgnCutoffReq</TT>
									kann die Zündung manuell aus- und eingeschaltet werden. Sonst
									wird zu keinem Zeitpunkt die Zündung ausgeschalten, d. h. auch
									bei Aussetzung der
									Eispritzung wird weiterhin gezündet.
								</L-1>
							</P>
							<NOTE NOTE-TYPE="HINT">
								<P>
									<L-1 L="DE">
										Vermutlich aufgrund eines Fehlers in der
										Basissoftware wird, nach einer erfolgreichen
										Synchronisation
										des Motors, kein Zündsignal ausgegeben, solange nicht
										mindestens einmal die Einspritzung eingeschaltet war. Danach
										kann die Zündung
										bis zum nächsten Verlust der Synchronisation
										unabhängig von der Einspritzung
										aus- und eingeschaltet werden,
										auch wenn diese nicht einspritzt.
									</L-1>
								</P>
							</NOTE>
						</CHAPTER>
					</SW-FEATURE>
				</SW-COMPONENTS>
			</SW-COMPONENT-SPEC>
		</SW-SYSTEM>
	</SW-SYSTEMS>
</MSRSW>
